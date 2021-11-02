#if PLAYMAKER

namespace HutongGames.PlayMaker.Actions {
    public class StringEventListener : GameEventListener<string> {
        #region Variables

        [UIHint(UIHint.Variable)]
        public FsmString storeArg;

        #endregion

        #region Private Function

        protected override void StoreValue(string arg) {
            storeArg.Value = arg;
        }

        #endregion

        #region Fsm

        public override void Reset() {
            storeArg = null;

            base.Reset();
        }

        #endregion
    }
}

#endif