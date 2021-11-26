using System.Collections;
using System.Collections.Generic;
using UnityBezierUygulamasi.Abstracts.Inputs;
using UnityEngine;

namespace UnityBezierUygulamasi.Concretes.Inputs
{
    public class PcInput : IInput
    {
        public float MouseX => Input.GetAxis("Mouse X");
        public float MouseY => Input.GetAxis("Mouse Y");
        public float Vertical => Input.GetAxis("Vertical");
    }
}