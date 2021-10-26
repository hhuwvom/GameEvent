using UnityEngine;

namespace Game.GameEvent {
    public class GameEvent<T> : ScriptableObject {
        public delegate void BaseGameEventHandler(T arg);

        private event BaseGameEventHandler Events;

        public T arg = default;

        public void Raise(T arg) {
            this.arg = arg;
            Events?.Invoke(arg);
        }

        public void Raise() {
            Events?.Invoke(arg);
        }

        public void Register(BaseGameEventHandler handler) => Events += handler;
        public void Unregister(BaseGameEventHandler handler) => Events -= handler;
    }

    public class GameEvent<T, T1> : ScriptableObject {
        public delegate void BaseGameEventHandler(T arg, T1 arg1);

        private event BaseGameEventHandler Events;

        public T arg = default;
        public T1 arg1 = default;

        public void Raise(T arg, T1 arg1) {
            this.arg = arg;
            this.arg1 = arg1;
            Events?.Invoke(arg, arg1);
        }

        public void Raise() {
            Events?.Invoke(arg, arg1);
        }

        public void Register(BaseGameEventHandler handler) => Events += handler;
        public void Unregister(BaseGameEventHandler handler) => Events -= handler;
    }

    public class GameEvent<T, T1, T2> : ScriptableObject {
        public delegate void BaseGameEventHandler(T arg, T1 arg1, T2 arg2);

        private event BaseGameEventHandler Events;

        public T arg = default;
        public T1 arg1 = default;
        public T2 arg2 = default;

        public void Raise(T arg, T1 arg1, T2 arg2) {
            this.arg = arg;
            this.arg1 = arg1;
            this.arg2 = arg2;
            Events?.Invoke(arg, arg1, arg2);
        }

        public void Raise() {
            Events?.Invoke(arg, arg1, arg2);
        }

        public void Register(BaseGameEventHandler handler) => Events += handler;
        public void Unregister(BaseGameEventHandler handler) => Events -= handler;
    }

    public class GameEvent<T, T1, T2, T3> : ScriptableObject {
        public delegate void BaseGameEventHandler(T arg, T1 arg1, T2 arg2, T3 arg3);

        private event BaseGameEventHandler Events;

        public T arg = default;
        public T1 arg1 = default;
        public T2 arg2 = default;
        public T3 arg3 = default;

        public void Raise(T arg, T1 arg1, T2 arg2, T3 arg3) {
            this.arg = arg;
            this.arg1 = arg1;
            this.arg2 = arg2;
            this.arg3 = arg3;
            Events?.Invoke(arg, arg1, arg2, arg3);
        }

        public void Raise() {
            Events?.Invoke(arg, arg1, arg2, arg3);
        }

        public void Register(BaseGameEventHandler handler) => Events += handler;
        public void Unregister(BaseGameEventHandler handler) => Events -= handler;
    }
}