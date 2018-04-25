using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hirame {

    [CreateAssetMenu (menuName = "Hirame/Instanciatable")]
    public class Instanciatable : ScriptableObject {

        public GameObject Prefab;
        public int MaxChildCount = 1;

        public GameObject LastInstanciated { get; private set; }

        public void IntanciateAt (Vector3 position) {
            LastInstanciated = Instantiate (Prefab, position, Quaternion.identity);
            LastInstanciated.SetActive (true);
        }

        public void InstanciateAsChild (Transform transform) {
            if (transform.childCount >= MaxChildCount)
                return;

            LastInstanciated = Instantiate (Prefab, transform.position, transform.rotation, transform);
            LastInstanciated.SetActive (true);
        }
    }

}