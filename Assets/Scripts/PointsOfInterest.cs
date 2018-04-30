using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hirame {

    public class PointsOfInterest : MonoBehaviour {

        public bool CreateFromChildred;

        public List<Transform> Points;

        private void Awake () {
            var count = transform.childCount;
            for (var i = 0; i < count; i++) {
                Points.Add (transform.GetChild (i));
            }
        }

        public Transform GetRandom () {
            return Points[Random.Range (0, Points.Count)];
        }
    }

}