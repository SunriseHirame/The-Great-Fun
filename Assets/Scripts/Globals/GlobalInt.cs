using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hirame {

    [CreateAssetMenu (menuName = "Hirame/Globals/Global Int")]
    public class GlobalInt : GlobalValue<int> {

        public void Increment () {
            ++value;
        }

        public void Decrement () {
            --value;
        }
    }

}
