#if PLAYMAKER

namespace HutongGames.PlayMaker.Actions {
    public class IntEventRaise : GameEventRaise<int> {
        #region Variables

        public FsmInt arg;

        #endregion

        #region Private Function 

        protected override void SetValue() {
            gameEvent.arg = arg.Value;
        }

        #endregion

        #region Fsm

        public override void Reset() {
            arg = null;
            base.Reset();
        }

        #endregion
    }
}

#endif