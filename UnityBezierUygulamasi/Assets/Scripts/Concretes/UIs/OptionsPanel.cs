using System.Collections;
using System.Collections.Generic;
using UnityBezierUygulamasi.Abstracts.Inputs;
using UnityBezierUygulamasi.Concretes.Controllers;
using UnityBezierUygulamasi.Concretes.Inputs;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityBezierUygulamasi.Concretes.UIs
{
    public class OptionsPanel : MonoBehaviour
    {
        [SerializeField] private BezierController[] _beziers;
        [SerializeField] private LinearController[] _linears;

        private bool _isDrawing;

        public void DrawButtonPressed()
        {
            _isDrawing = true;
        }
        public void CleanButtonPressed()
        {
            SceneManager.LoadScene(0);
        }
        public void QuitButtonPressed()
        {
            Application.Quit();
        }

        private void Update()
        {
            if (_isDrawing)
            {

                for (int i = 0; i < _beziers.Length; i++)
                {
                    if (_beziers[i].T >= 1f) _beziers[i].T = 1;
                    _beziers[i].T += Time.deltaTime;
                }
                for (int i = 0; i < _linears.Length; i++)
                {
                    if (_linears[i].T >= 1f) _linears[i].T = 1;
                    _linears[i].T += Time.deltaTime;
                }
            }
        }
    }
}