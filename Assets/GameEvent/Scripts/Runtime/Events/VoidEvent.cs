using UnityEngine;

namespace Game.GameEvent {
    [CreateAssetMenu(menuName = "Game Event/Void Event", fileName = "Void Event")]
    public class VoidEvent : ScriptableObject {
        public delegate void BaseGameEventHandler();

        private event BaseGameEventHandler events;

        public void Raise() => events?.Invoke();
        public void Register(BaseGameEventHandler handler) => events += handler;
        public void Unregister(BaseGameEventHandler handler) => events -= handler;
    }
}