using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hirame {

    public class SingletonBehaviour<T> : MonoBehaviour where T : SingletonBehaviour<T> {

        private static T instance;
        public static T Instance => instance;

    }

}