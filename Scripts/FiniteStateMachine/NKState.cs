using UnityEngine;

namespace NK.StateMachine
{
    public abstract class NKState
    {
        protected NKStateMachine m_StateMachine;

        protected NKState(NKStateMachine stateMachine)
        {
            m_StateMachine = stateMachine;
        }

        public virtual void Enter() {}
        public virtual void Update() {}
        public virtual void FixedUpdate() {}
        public virtual void LateUpdate() {}
        public virtual void Exit() {}
    }

    public class NKState<TBlackboard> : NKState
        where TBlackboard : ScriptableObject
    {
        protected TBlackboard m_Blackboard;

        public NKState(NKStateMachine stateMachine, TBlackboard blackboard) : base(stateMachine)
        {
            m_Blackboard = blackboard;
        }
    }
}