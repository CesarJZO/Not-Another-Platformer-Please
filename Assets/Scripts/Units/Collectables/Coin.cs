﻿using Core;
using UnityEngine;

namespace Units.Collectables
{
    public sealed class Coin : MonoBehaviour, ICollectable<Coin>
    {
        [SerializeField] private int value;

        public int Value => value;

        public Coin Collect()
        {
            Destroy(gameObject);
            return this;
        }
    }
}
