using UnityEngine;

namespace UnityBezierUygulamasi.Abstracts.Movements
{
    public interface IBezier
    {
        void Bezier(Vector3 p1, Vector3 p2, Vector3 p3, Vector3 p4, float t);
    }
}