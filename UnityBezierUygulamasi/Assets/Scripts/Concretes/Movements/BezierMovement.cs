using System.Collections;
using System.Collections.Generic;
using UnityBezierUygulamasi.Abstracts.Drawings;
using UnityBezierUygulamasi.Abstracts.Movements;
using UnityBezierUygulamasi.Concretes.Controllers;
using UnityEngine;

namespace UnityBezierUygulamasi.Concretes.Movements
{
    public class BezierMovement : IBezier
    {
        private IDrawing _pen;
        private ILinear _linear;
        
        private BezierController _controller;

        public BezierMovement(BezierController controller , IDrawing pen, ILinear linear)
        {
            _controller = controller;
            _pen = pen;
            _linear = linear;
        }
        public void Bezier(Vector3 p1, Vector3 p2, Vector3 p3, Vector3 p4, float t)
        {
            _pen.DrawLines(p1, p2, Color.green);
            _pen.DrawLines(p2, p3, Color.green);
            _pen.DrawLines(p3, p4, Color.green);

            Vector3 a = _linear.LerpVector(p1, p2, t);
            Vector3 b = _linear.LerpVector(p2, p3, t);
            Vector3 c = _linear.LerpVector(p3, p4, t);

            _pen.DrawLines(a, b, Color.red);
            _pen.DrawLines(b, c, Color.red);

            Vector3 d = _linear.LerpVector(a, b, t);
            Vector3 e = _linear.LerpVector(b, c, t);

            _pen.DrawLines(d, e, Color.blue);

            Vector3 curvePoint = _linear.LerpVector(d, e, t);
            _controller.transform.position = curvePoint;
        }
    }
}