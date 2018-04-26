using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hirame {

    [CreateAssetMenu (menuName = "Hirame/Player Profile")]
    public class PlayerProfile : ScriptableObject {

        public string PlayerName;
        public int ProfileLevel;

    }

}