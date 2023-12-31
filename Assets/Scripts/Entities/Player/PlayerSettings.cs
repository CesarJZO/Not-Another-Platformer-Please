using UnityEngine;

namespace Entities.Player
{
    [CreateAssetMenu(fileName = "Player Settings", menuName = "Player/Player Settings")]
    public sealed class PlayerSettings : BaseEntitySettings
    {
        [SerializeField] private float speed;
        public float Speed => speed;

        [SerializeField] private float jumpHeight;
        public float JumpHeight => jumpHeight;

        [SerializeField, Range(0f, 1f)] private float airInputInfluence;
        public float AirInputInfluence => airInputInfluence;

        [SerializeField] private LayerMask collectableLayer;
        public LayerMask CollectableLayer => collectableLayer;
    }
}
