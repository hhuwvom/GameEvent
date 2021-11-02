#if PLAYMAKER

using Game.GameEvent;

namespace HutongGames.PlayMaker.Actions {
    [ActionCategory("Game Event")]
    public class VoidEventListener : FsmStateAction {
        #region Variables

        [RequiredField]
        public VoidEvent gameEvent;
        public FsmEvent fsmEvent;

        #endregion

        #region Private Function

        private void DoRaise() {
            Fsm.Event(fsmEvent);
            Finish();
        }

        #endregion

        #region Fsm

        public override void Reset() {
            fsmEvent = null;
        }

        public override void OnEnter() {
            gameEvent.Register(DoRaise);
        }

        public override void OnExit() {
            gameEvent.Unregister(DoRaise);
        }

        #endregion
    }
}

#endif