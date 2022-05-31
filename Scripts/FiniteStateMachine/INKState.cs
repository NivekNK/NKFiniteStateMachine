namespace NK.StateMachine
{
    public interface INKState
    {
        void Enter(NKStateMachine stateMachine);
        void Execute(NKStateMachine stateMachine);
        void ExecuteFixed(NKStateMachine stateMachine);
        void ExecuteLate(NKStateMachine stateMachine);
        void Exit(NKStateMachine stateMachine);

        void SortTransitions();
    }
}