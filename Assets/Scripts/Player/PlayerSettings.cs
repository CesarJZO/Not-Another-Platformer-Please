using UnityEngine;

namespace Player
{
    [CreateAssetMenu(fileName = "Player Settings", menuName = "Player/Player Settings")]
    public sealed class PlayerSettings : ScriptableObject
    {
        [SerializeField] private float speed;
        public float Speed => speed;

        [SerializeField] private float jumpHeight;
        public float JumpHeight => jumpHeight;
    }
}
