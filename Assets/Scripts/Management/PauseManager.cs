﻿using System;
using Core;
using Input;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

namespace Management
{
    public class PauseManager : MonoBehaviour
    {
        public static PauseManager Instance { get; private set; }

        public static event Action Paused;
        public static event Action Resumed;

        [SerializeField] private UnityEvent onPause;
        [SerializeField] private UnityEvent onResume;

        private void Awake()
        {
            Instance = this;
        }

        private void Start()
        {
            GameInput.PausePerformed += OnPausePerformed;
        }

        private void OnDestroy()
        {
            GameInput.PausePerformed -= OnPausePerformed;
        }

        private void OnPausePerformed(InputAction.CallbackContext context)
        {
            switch (GameManager.Instance.CurrentState)
            {
                case GameState.Playing: Pause(); break;
                case GameState.Paused: Resume(); break;
            }
        }

        public void Pause()
        {
            GameManager.Instance.CurrentState = GameState.Paused;

            Time.timeScale = 0f;
            Paused?.Invoke();
            onPause?.Invoke();
        }

        public void Resume()
        {
            GameManager.Instance.CurrentState = GameState.Playing;

            Time.timeScale = 1f;
            Resumed?.Invoke();
            onResume?.Invoke();
        }
    }
}