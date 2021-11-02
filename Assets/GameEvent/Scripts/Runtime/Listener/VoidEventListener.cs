using UnityEngine;
using UnityEngine.Events;

namespace Game.GameEvent {
    public class VoidEventListener : MonoBehaviour {
        #region Variables

        [SerializeField]
        private VoidEvent gameEvent;
        [SerializeField]
        private UnityEvent unityEvent;

        #endregion

        #region Behaviour

        private void Awake() => gameEvent.Register(unityEvent.Invoke);
        private void OnDestroy() => gameEvent.Unregister(unityEvent.Invoke);

        #endregion
    }
}

