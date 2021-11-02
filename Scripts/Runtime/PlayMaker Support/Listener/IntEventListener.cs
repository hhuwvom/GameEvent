#if PLAYMAKER

namespace HutongGames.PlayMaker.Actions {
    public class IntEventListener : GameEventListener<int> {
        #region Variables

        [UIHint(UIHint.Variable)]
        public FsmInt storeArg;

        #endregion

        #region Private Function

        protected override void StoreValue(int arg) {
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