#if PLAYMAKER

using Game.GameEvent;

namespace HutongGames.PlayMaker.Actions {
    [ActionCategory("Game Event")]
    public class VoidEventRaise : FsmStateAction {
        #region Variables

        [RequiredField]
        [DisplayOrder(0)]
        public VoidEvent gameEvent;

        #endregion

        #region Private Function 

        protected void DoRaise() {
            if (gameEvent == null)
                return;

            gameEvent.Raise();
            Finish();
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