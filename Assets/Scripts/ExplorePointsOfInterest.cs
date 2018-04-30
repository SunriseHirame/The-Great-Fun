using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hirame {

    [RequireComponent (typeof (EnemyAI))]
    public class ExplorePointsOfInterest : MonoBehaviour {

        public PointsOfInterest Pois;
        public float WaitTime = 2f;

        new Transform transform;
        Transform target;
        EnemyAI ai;

        private void Start () {
            transform = GetComponent<Transform> ();
            ai = GetComponent<EnemyAI> ();
            SwitchTarget ();
        }

        private void Update () {
            if ((target.position - transform.position).sqrMagnitude < 1.5f) {
                enabled = false;
                Invoke ("SwitchTarget", WaitTime);
            }
        }

        void SwitchTarget () {
            enabled = true;
            target = Pois.GetRandom ();
            ai.SetNavigationTarget (target);
        }

    }

}