using UnityEngine;

namespace NK.StateMachine
{
    public abstract class NKAction : ScriptableObject
    {
        public virtual void Enter(NKStateMachine stateMachine) {}

        public virtual void Execute(NKStateMachine stateMachine) {}

        public virtual void ExecuteFixed(NKStateMachine stateMachine) {}

        public virtual void ExecuteLate(NKStateMachine stateMachine) {}

        public virtual void Exit(NKStateMachine stateMachine) {}
    }
}