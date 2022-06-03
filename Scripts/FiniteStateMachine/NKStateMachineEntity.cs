using UnityEngine;

namespace NK.StateMachine
{
    public abstract class NKStateMachineEntity<TBlackboard> : MonoBehaviour
         where TBlackboard : ScriptableObject
    {
        public TBlackboard Blackboard;
        public NKStateMachine StateMachine { get; private set; }

        public virtual void Awake()
        {
            StateMachine = new NKStateMachine();
        }

        public virtual void Update()
        {
            StateMachine.CurrentState?.Update();
        }

        public virtual void FixedUpdate()
        {
            StateMachine.CurrentState?.FixedUpdate();
        }

        public virtual void LateUpdate()
        {
            StateMachine.CurrentState?.LateUpdate();
        }
    }
}