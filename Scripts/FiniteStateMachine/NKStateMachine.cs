namespace NK.StateMachine
{
    public class NKStateMachine
    {
        public NKState CurrentState { get; private set; }

        public void Initialize(NKState initialState)
        {
            CurrentState = initialState;
            CurrentState?.Enter();
        }

        public void ChangeState(NKState newState)
        {
            CurrentState?.Exit();
            CurrentState = newState;
            CurrentState?.Enter();
        }
    }
}