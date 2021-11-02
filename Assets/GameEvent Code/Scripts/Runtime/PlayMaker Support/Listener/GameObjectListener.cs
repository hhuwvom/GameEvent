#if PLAYMAKER

using UnityEngine;

namespace HutongGames.PlayMaker.Actions {
    public class GameObjectEventListener : GameEventListener<GameObject> {
        #region Variables

        [UIHint(UIHint.Variable)]
        public FsmGameObject storeArg;

        #endregion

        #region Private Function

        protected override void StoreValue(GameObject arg) {
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