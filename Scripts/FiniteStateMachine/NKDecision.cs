using UnityEngine;

namespace NK.StateMachine
{
    public abstract class NKDecision : ScriptableObject
    {
        public abstract bool Decide(NKStateMachine stateMachine);
    }
}