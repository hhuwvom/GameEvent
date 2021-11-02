#if PLAYMAKER

namespace HutongGames.PlayMaker.Actions {
    public class StringEventRaise : GameEventRaise<string> {
        #region Variables

        public FsmString arg;

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