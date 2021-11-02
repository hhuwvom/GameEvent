using UnityEngine;
using UnityEngine.Events;

namespace Game.GameEvent {
    public class GameEventListener<T> : MonoBehaviour {
        [System.Serializable]
        public class GameUnityEvent : UnityEvent<T> { }

        #region Variables

        [SerializeField]
        private GameEvent<T> gameEvent;
        [SerializeField]
        private GameUnityEvent unityEvent;

        #endregion

        #region Behaviour

        private void Awake() => gameEvent.Register(unityEvent.Invoke);
        private void OnDestroy() => gameEvent.Unregister(unityEvent.Invoke);

        #endregion
    }

    public class GameEventListener<T, T1> : MonoBehaviour {
        [System.Serializable]
        public class GameUnityEvent : UnityEvent<T, T1> { }

        #region Variables

        [SerializeField]
        private GameEvent<T, T1> gameEvent;
        [SerializeField]
        private GameUnityEvent unityEvent;

        #endregion

        #region Behaviour

        private void Awake() => gameEvent.Register(unityEvent.Invoke);
        private void OnDestroy() => gameEvent.Unregister(unityEvent.Invoke);

        #endregion
    }
}

