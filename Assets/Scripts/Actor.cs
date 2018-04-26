using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Hirame {

    public class Actor : MonoBehaviour {

        public ResourceAttribute Health;

        public UnityEvent ActorDeath;

        private void Update () {
            if (Health.Current <= 0) {
                ActorDeath.Invoke ();
                enabled = false;
                return;
            }
        }

    }

}