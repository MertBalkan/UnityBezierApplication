using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityBezierUygulamasi.Abstracts.Inputs
{
    public interface IInput
    {
        float MouseX { get; }
        float MouseY { get; }
        float Vertical { get; }
    }
}