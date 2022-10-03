﻿using UnityEngine;

namespace Code.Infrastructure
{
    public sealed class GameBootstrapper :
        MonoBehaviour
    {
        private Game _game;

        private void Awake()
        {
            _game = new Game();
            _game.stateMachine.Enter<BootstrapState>();

            DontDestroyOnLoad(this);
        }
    }
}