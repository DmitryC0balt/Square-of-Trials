using UnityEngine;

namespace Scripts.Model.PlayerCamera
{
    public class CameraSystem : MonoBehaviour
    {
        private Camera _camera;

        private int _minHorizontalVector, _minVerticalVector;
        private int _maxHorizontalVector, _maxVerticalVector;

        internal void Init(uint stageRadius)
        {
            _camera = Camera.main;
        }

    }
}