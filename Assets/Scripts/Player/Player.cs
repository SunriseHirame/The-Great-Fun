using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hirame {

    public class Player : MonoBehaviour {

        public GameEvent PlayerDeathEvent;

        public ResourceAttribute Health;

        private void Update () {
            if (Health.Current <= 0f) {
                PlayerDeathEvent.Raise ();
                gameObject.SetActive (false);
            }
        }

    }

}