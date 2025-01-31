using UnityEngine;

using Scripts.Root.GameEntryPoint;

namespace Scripts.Root.SceneEntryPoint
{
    public class GameplayEntryPoint : MonoBehaviour
    {
        [SerializeField]private GameMaster _gameMaster;


        internal void Run(GameMaster gameMaster)
        {
            _gameMaster = gameMaster;

            Debug.Log("Gameplay scene loaded");
        }


        internal void Stop()
        {
            Debug.Log("Gameplay scene stopped");
        }
    }
}