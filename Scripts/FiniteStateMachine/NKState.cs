using System.Collections.Generic;
using UnityEngine;

namespace NK.StateMachine
{
    [CreateAssetMenu(menuName = "NKTools/Finite State Machine/New State", fileName = "NewState")]
    public sealed class NKState : ScriptableObject, INKState
    {
        public List<NKAction> Actions = new List<NKAction>();
        public List<NKTransition> Transitions = new List<NKTransition>();

        public void Enter(NKStateMachine stateMachine)
        {
            Actions.ForEach(a => a.Enter(stateMachine));
        }

        public void Execute(NKStateMachine stateMachine)
        {
            Actions.ForEach(a => a.Execute(stateMachine));
            Transitions.ForEach(t => t.Check(stateMachine));
        }

        public void ExecuteFixed(NKStateMachine stateMachine)
        {
            Actions.ForEach(a => a.ExecuteFixed(stateMachine));
        }

        public void ExecuteLate(NKStateMachine stateMachine)
        {
            Actions.ForEach(a => a.ExecuteLate(stateMachine));
        }

        public void Exit(NKStateMachine stateMachine)
        {
            Actions.ForEach(a => a.Exit(stateMachine));
        }

        public void SortTransitions()
        {
            Transitions.Sort((t1, t2) => t2.Priority.CompareTo(t1.Priority));
        }
    }
}