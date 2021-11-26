using UnityEngine;

namespace UnityBezierUygulamasi.Abstracts.Drawings
{
    public interface IDrawing
    {
        void DrawLines(Vector3 p1, Vector3 p2, Color drawingColor);
    }
}