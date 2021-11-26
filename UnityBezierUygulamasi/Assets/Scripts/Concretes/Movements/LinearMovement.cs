using UnityBezierUygulamasi.Abstracts.Drawings;
using UnityBezierUygulamasi.Abstracts.Movements;
using UnityEngine;

namespace UnityBezierUygulamasi.Concretes.Movements
{
    public class LinearMovement : ILinear
    {
        private IDrawing _pen;

        public LinearMovement(IDrawing pen)
        {
            _pen = pen;
        }

        private void Awake()
        {
            _pen = new Drawing.Drawing();
        }

        public Vector3 LerpVector(Vector3 p1, Vector3 p2, float t)
        {
            return p1 + ((p2 - p1) * t);
        }
    }
}