using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hirame {

    public class DestroyIfBelow : MonoBehaviour {
        const int MAX_PER_FRAME = 10;

        static Coroutine checker;
        static Queue<DestroyIfBelow> checkQueue = new Queue<DestroyIfBelow> ();

        public float DistanceVertical = -40f;

        new Transform transform;
        bool isChecker;

        IEnumerator DoDestroyCheck () {
            WaitForEndOfFrame wait;
            yield return wait = new WaitForEndOfFrame ();

            while (checkQueue.Count > 0) {
                var thisFrame = Mathf.Min (checkQueue.Count, MAX_PER_FRAME);
                for (var i = thisFrame; i >= 0; i--) {
                    var toCheck = checkQueue.Dequeue ();

                    if (toCheck == null)
                        continue;

                    if (toCheck.transform.position.y <= DistanceVertical)
                        Destroy (toCheck.gameObject);
                    else
                        checkQueue.Enqueue (toCheck);
                }
                yield return wait = new WaitForEndOfFrame ();
            }
        }

        private void Start () {
            transform = GetComponent<Transform> ();
            checkQueue.Enqueue (this);

            if (checker == null) {
                isChecker = true;
                checker = StartCoroutine (DoDestroyCheck ());
            }
        }

        private void OnDestroy () {
            if (isChecker) {
                while (checkQueue.Count > 0) {
                    var next = checkQueue.Dequeue ();
                    if (next == null)
                        continue;
                    checker = next.StartCoroutine (next.DoDestroyCheck ());
                }
            }
        }

    }
}
