using UnityBezierUygulamasi.Abstracts.Drawings;
using UnityEngine;

namespace UnityBezierUygulamasi.Concretes.Drawing
{
    public class Drawing : IDrawing
    {
        public void DrawLines(Vector3 p1, Vector3 p2, Color drawingColor)
        {
            Debug.DrawLine(p1, p2, drawingColor);
        }
    }
}