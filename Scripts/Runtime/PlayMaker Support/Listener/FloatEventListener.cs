#if PLAYMAKER

namespace HutongGames.PlayMaker.Actions {
    public class FloatEventListener : GameEventListener<float> {
        #region Variables

        [UIHint(UIHint.Variable)]
        public FsmFloat storeArg;

        #endregion

        #region Private Function

        protected override void StoreValue(float arg) {
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