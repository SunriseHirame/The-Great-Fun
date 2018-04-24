using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hirame {

    public class ResourceAttribute : MonoBehaviour {

        public ActorAttributeType AttributeType;

        public float Starting;
        public float Max;

        float current;

        public float Current => current;
    }

}