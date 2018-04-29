using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hirame {

    public class ResourceAttribute : MonoBehaviour {

        public ActorAttributeType AttributeType;

        public float Starting;
        public float Max;

        public float Current;

        private void Awake () {
            Current = Starting;
        }
    }

}