using UnityEngine;

namespace NK.StateMachine
{
    [CreateAssetMenu(menuName = "NKTools/Finite State Machine/New Transition", fileName = "NewTransition")]
    public sealed class NKTransition : ScriptableObject
    {
        public NKDecision Decision;
        public INKState TrueState;
        public INKState FalseState;
        public int Priority = 0;

        public void Check(NKStateMachine stateMachine)
        {
            stateMachine.ChangeState(Decision.Decide(stateMachine) ? TrueState : FalseState);
        }
    }
}