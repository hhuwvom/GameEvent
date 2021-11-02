#if PLAYMAKER

using UnityEngine;

namespace HutongGames.PlayMaker.Actions {
    public class GameObjectEventRaise : GameEventRaise<GameObject> {
        #region Variables

        public FsmGameObject arg;

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