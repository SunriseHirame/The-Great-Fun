using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hirame {

    public class Crosshair : MonoBehaviour {

        public bool HideCursorOnStart;

        public void ShowCursor () {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }

        public void HideCursor () {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }

        private void Start () {
            if (HideCursorOnStart)
                HideCursor ();
        }

        private void Update () {
            if (Input.GetKeyDown (KeyCode.Escape)) {
                ShowCursor ();
            }
        }


    }

}