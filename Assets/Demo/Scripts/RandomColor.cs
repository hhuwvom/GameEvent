using UnityEngine;

namespace IdleGame {
    public class RandomColor : MonoBehaviour {
        #region Variables

        private new Renderer renderer;

        #endregion

        #region Behaviour

        private void Awake() {
            renderer = GetComponent<Renderer>();
        }

        public void Change() {
            renderer.material.color = new Color(Random.value, Random.value, Random.value);
        }

        #endregion
    }
}