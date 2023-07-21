using Core;

namespace Entities.Player
{
    public abstract class PlayerState : State
    {
        public PlayerController Player { get; }

        protected PlayerState(PlayerController player, StateMachine stateMachine) : base(stateMachine)
        {
            Player = player;
        }
    }
}