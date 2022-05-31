using UnityEngine;

namespace NK.StateMachine
{
    public sealed class NKStateMachineEntity : MonoBehaviour
    {
        [SerializeField] private NKStateMachine m_StateMachine;

        private void Awake()
        {
            if (m_StateMachine != null)
                m_StateMachine.Initialize();
        }

        private void Update()
        {
            if (m_StateMachine != null)
                m_StateMachine.Execute();
        }

        private void FixedUpdate()
        {
            if (m_StateMachine != null)
                m_StateMachine.ExecuteFixed();
        }

        private void LateUpdate()
        {
            if (m_StateMachine != null)
                m_StateMachine.ExecuteLate();
        }
    }
}