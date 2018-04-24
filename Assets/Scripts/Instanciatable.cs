using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hirame {

    [CreateAssetMenu (menuName = "Hirame/Instanciatable")]
    public class Instanciatable : ScriptableObject {

        public GameObject Prefab;

        public GameObject InstanciateAsChild (Transform transform) {
            var p = Instantiate (Prefab, transform.position, transform.rotation, transform);
            p.SetActive (true);
            return p;
        }
    }

}