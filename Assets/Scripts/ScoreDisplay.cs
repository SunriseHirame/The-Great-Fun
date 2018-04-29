using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace Hirame {

    public class ScoreDisplay : MonoBehaviour {

        public Text text;


        public int EnemiesLeft;

        public void OnEnemySpawned () {
            EnemiesLeft++;
            UpdateText ();
        }

        public void OnEnemyDeath () {
            EnemiesLeft--;
            UpdateText ();
        }

        void UpdateText () {
            Debug.Log (EnemiesLeft);
            text.text = EnemiesLeft.ToString ();
        }
    }

}