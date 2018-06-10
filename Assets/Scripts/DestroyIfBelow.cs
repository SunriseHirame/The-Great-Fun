using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hirame {

    public class DestroyIfBelow : MonoBehaviour {
        public float HeightVertical = -20f;

        private void OnEnable () {
            StartCoroutine (Checker ());
        }

        IEnumerator Checker () {
            var wait = new WaitForSeconds (1f);
            yield return wait;
            while (enabled) {
                if (transform.position.y <= HeightVertical)
                    Destroy (gameObject);
                yield return wait = new WaitForSeconds (1f);
            }
        }
    }
}
