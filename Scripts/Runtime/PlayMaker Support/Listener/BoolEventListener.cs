#if PLAYMAKER

namespace HutongGames.PlayMaker.Actions {
    public class BoolEventListener : GameEventListener<bool> {
        #region Variables

        [UIHint(UIHint.Variable)]
        public FsmBool storeArg;

        #endregion

        #region Private Function

        protected override void StoreValue(bool arg) {
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