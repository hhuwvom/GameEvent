using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IdleGame {
    public class Starter : MonoBehaviour {
        #region Variables

        public GameObject prefab;

        #endregion

        #region Behaviour

        private void Start() {
            if (prefab == null)
                return;

            Instantiate(prefab);
        }

        #endregion
    }
}