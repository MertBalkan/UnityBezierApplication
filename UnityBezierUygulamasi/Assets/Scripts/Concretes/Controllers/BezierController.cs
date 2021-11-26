using System.Collections;
using System.Collections.Generic;
using UnityBezierUygulamasi.Abstracts.Drawings;
using UnityBezierUygulamasi.Abstracts.Movements;
using UnityBezierUygulamasi.Concretes.Movements;
using UnityEngine;

namespace UnityBezierUygulamasi.Concretes.Controllers
{
    public class BezierController : MonoBehaviour
    {
        [SerializeField] private Transform _p1 = default;
        [SerializeField] private Transform _p2 = default;
        [SerializeField] private Transform _p3 = default;
        [SerializeField] private Transform _p4 = default;

        [Range(0, 1f)] [SerializeField] private float _t = default;

        private IDrawing _pen;
        private IBezier _bezier;
        private ILinear _linear;

        public float T { get => _t; set => _t = value; }

        private void Awake()
        {
            _pen = new Drawing.Drawing();
            _linear = new LinearMovement(_pen);
            _bezier = new BezierMovement(this, _pen, _linear);
        }

        private void Update()
        {
            _bezier.Bezier(_p1.position, _p2.position, _p3.position, _p4.position, T);
        }
    }
}