using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Hirame {

    public class EnemyAI : MonoBehaviour {

        public GameEvent SpawnedEvent;

        public NavMeshAgent Navigator;

        public Transform Target;
        Vector3 currentTargetPosition;

        Coroutine targetUpdater;

        private void Start () {
            SpawnedEvent?.Raise ();
        }

        public void SetNavigationTarget (Transform transform) {
            Target = transform;
            Navigator.SetDestination (transform.position);
            if (targetUpdater == null)
                targetUpdater = StartCoroutine (UpdateTarget ());
        }

        IEnumerator UpdateTarget () {
            var wait = new WaitForSeconds (1f);
            yield return wait;

            while (Target != null) {
                if ((currentTargetPosition - Target.position).sqrMagnitude > 3f)
                    Navigator.SetDestination (Target.position);
                yield return wait = new WaitForSeconds (0.3f);
            }
        }

    }

}
