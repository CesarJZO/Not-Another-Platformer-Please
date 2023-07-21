using System;
using Core;

namespace Player.States
{
    public sealed class IdleState : State
    {
        public IdleState(StateMachine stateMachine) : base(stateMachine) { }

        public static event Action<IdleState> Started;

        public static event Action<IdleState> Ended;

        public override void OnStart()
        {
            Started?.Invoke(this);
        }

        public override void OnEnd()
        {
            Ended?.Invoke(this);
        }

        public override string ToString() => nameof(IdleState);
    }
}
