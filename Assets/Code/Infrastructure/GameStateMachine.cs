using System;
using System.Collections.Generic;
using Code.Infrastructure.States;

namespace Code.Infrastructure
{
    public sealed class GameStateMachine
    {
        private readonly Dictionary<Type, IState> _states;
        private IState _activeState;

        public GameStateMachine(SceneLoader sceneLoader)
        {
            _states = new Dictionary<Type, IState>
            {
                [typeof(BootstrapState)] = new BootstrapState(this, sceneLoader),
                [typeof(LoadLevelState)] = new LoadLevelState(this, sceneLoader),
            };
        }

        public void Enter<TState>()
            where TState : IState
        {
            _activeState?.Exit();
            var state = _states[typeof(TState)];
            _activeState = state;
            state.Enter();
        }
    }
}