#if PLAYMAKER

using Game.GameEvent;

namespace HutongGames.PlayMaker.Actions {
    [ActionCategory("Game Event")]
    public abstract class GameEventListener<T> : FsmStateAction {
        #region Variables

        [RequiredField]
        [DisplayOrder(0)]
        public GameEvent<T> gameEvent;
        [DisplayOrder(1)]
        public FsmEvent fsmEvent;

        #endregion

        #region Private Function

        protected virtual void StoreValue(T arg) {}

        private void DoListener(T arg) {
            StoreValue(arg);

            Fsm.Event(fsmEvent);
            Finish();
        }

        #endregion

        #region Fsm

        public override void Reset() {
            gameEvent = null;
            fsmEvent = null;
        }

        public override void OnEnter() {
            gameEvent.Register(DoListener);
        }

        public override void OnExit() {
            gameEvent.Unregister(DoListener);
        }

        public override string ErrorCheck() {
            if (gameEvent == null)
                return "gameEvent must be assigned.";

            return base.ErrorCheck();
        }

        #endregion
    }
}

#endif