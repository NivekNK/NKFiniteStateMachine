using System.Collections.Generic;
using UnityEngine;

namespace NK.StateMachine
{
    [CreateAssetMenu(menuName = "NKTools/Finite State Machine/New StateMachine", fileName = "NewStateMachine")]
    public sealed class NKStateMachine : ScriptableObject
    {
        [SerializeField] private INKState m_InitialState;
        [SerializeField] private List<INKState> m_States = new List<INKState>();

        public INKState CurrentState { get; private set; }

        public void Initialize()
        {
            m_States.ForEach(state => state.SortTransitions());

            CurrentState = m_InitialState;
            if (CurrentState != null)
                CurrentState.Enter(this);
        }

        public void Execute() => CurrentState.Execute(this);

        public void ExecuteFixed() => CurrentState.ExecuteFixed(this);

        public void ExecuteLate() => CurrentState.ExecuteLate(this);

        public void ChangeState(INKState newState)
        {
            if (newState == null)
                return;

            if (CurrentState != null)
                CurrentState.Exit(this);

            CurrentState = newState;

            if (CurrentState != null)
                CurrentState.Enter(this);
        }
    }
}