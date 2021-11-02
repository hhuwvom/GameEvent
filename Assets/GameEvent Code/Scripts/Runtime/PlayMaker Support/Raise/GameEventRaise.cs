#if PLAYMAKER

using Game.GameEvent;

namespace HutongGames.PlayMaker.Actions {
    [ActionCategory("Game Event")]
    public abstract class GameEventRaise<T> : FsmStateAction {
        #region Variables

        [RequiredField]
        [DisplayOrder(0)]
        public GameEvent<T> gameEvent;

        #endregion

        #region Private Function 

        protected virtual void SetValue() {}

        private void DoRaise() {
            if (gameEvent == null)
                return;

            SetValue();
            gameEvent.Raise();
        }

        #endregion

        #region Fsm

        public override void Reset() {
            gameEvent = null;
        }

        public override void OnEnter() {
            DoRaise();
            Finish();
        }

        #endregion
    }
}

#endif