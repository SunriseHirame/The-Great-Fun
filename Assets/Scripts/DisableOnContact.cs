using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hirame {

    public class DisableOnContact : MonoBehaviour {

        private void OnTriggerEnter () {
            gameObject.SetActive (false);
        }
    }

}