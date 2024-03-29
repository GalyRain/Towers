﻿using EnemySpawn;
using TurretSpawn;
using UnityEditor;
using UnityEngine;

namespace AssetsRoot
{
    [CreateAssetMenu(menuName = "Assets/Level Asset", fileName = "Level Asset")]
    public class LevelAsset : ScriptableObject
    {
        public SceneAsset SceneAsset;
        public SpawnWavesAsset SpawnWavesAsset;
        public TurretMarketAsset TurretMarketAsset;

        public int StartHealth;
        public int StartMoney;
    }
}