using UnityBezierUygulamasi.Abstracts.Drawings;
using UnityBezierUygulamasi.Abstracts.Movements;
using UnityBezierUygulamasi.Concretes.Movements;
using UnityEngine;

namespace UnityBezierUygulamasi.Concretes.Controllers
{
    public class LinearController : MonoBehaviour
    {
        [SerializeField] private Transform _p1;
        [SerializeField] private Transform _p2;
        [Range(0f, 1f)][SerializeField] private float _t;

        private ILinear _linear;
        private IDrawing _drawing;

        public float T { get => _t; set => _t = value; }

        private void Awake()
        {
            _drawing = new Drawing.Drawing();
            _linear = new LinearMovement(_drawing);
        }

        private void Update()
        {
            _drawing.DrawLines(_p1.position, _p2.position, Color.white);
            Vector3 resultVector = _linear.LerpVector(_p1.position, _p2.position, T);
            transform.position = resultVector;
        }
    }
}