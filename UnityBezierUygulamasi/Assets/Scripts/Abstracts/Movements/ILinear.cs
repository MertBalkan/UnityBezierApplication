using UnityEngine;

namespace UnityBezierUygulamasi.Abstracts.Movements
{
    public interface ILinear
    {
        Vector3 LerpVector(Vector3 p1, Vector3 p2, float t);
    }
}