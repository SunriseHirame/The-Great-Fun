using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hirame {

    public class DestroyOnContact : MonoBehaviour {

        private void OnCollisionEnter () {
            Destroy (gameObject);
        }

        private void OnTriggerEnter () {
            OnCollisionEnter ();
        }
    }

}