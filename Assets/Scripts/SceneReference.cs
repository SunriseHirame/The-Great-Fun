using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

#if UNITY_EDITOR
using UnityEditor;
#endif

namespace Hirame {

    [CreateAssetMenu (menuName = "Hirame/Scene Reference")]
    public class SceneReference : ScriptableObject {

#if UNITY_EDITOR
        public SceneAsset Scene;
#endif

        public void LoadScene () {
            LoadScene (LoadSceneMode.Single);
        }

        public void LoadScene (LoadSceneMode loadSceneMode) {
            SceneManager.LoadScene (Scene.name, loadSceneMode);
        }
    }

}