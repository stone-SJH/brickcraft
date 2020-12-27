﻿using UnityEngine;

namespace Brickcraft
{
    public class Game : MonoBehaviour
    {
        public static Game Instance;

        public Shader transparentShader;

        public Material[] brickMaterials;

        public enum Layers
        {
            IgnoreRaycast = 2
        }

        private void Awake() {
            Instance = this;
        }

        public Material getBrickMaterial (string name) {
            foreach (Material material in brickMaterials) {
                if (material.name == name) {
                    return material;
                }
            }
            return null;
        }
    }
}
