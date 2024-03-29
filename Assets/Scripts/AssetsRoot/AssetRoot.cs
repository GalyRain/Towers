﻿using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace AssetsRoot
{
    [CreateAssetMenu(menuName = "Assets/Asset Root", fileName = "Asset Root")]
    public class AssetRoot : ScriptableObject
    {
        public SceneAsset UIScene;
        public List<LevelAsset> Levels;
    }
}