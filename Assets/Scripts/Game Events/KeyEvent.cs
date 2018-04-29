using UnityEngine;
using UnityEngine.Events;

namespace Hirame {

    public class KeyEvent : MonoBehaviour {

        public KeyCode Key;
        public UnityEvent KeyDown;

        private void Update () {
            if (Input.GetKeyDown (Key)) {
                KeyDown.Invoke ();
            }
        }

    }

}