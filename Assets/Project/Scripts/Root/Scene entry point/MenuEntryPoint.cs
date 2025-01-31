using Scripts.Root.GameEntryPoint;
using UnityEngine;

namespace Scripts.Root.SceneEntryPoint
{
    public class MenuEntryPoint : MonoBehaviour
    {
        [SerializeField]private GameMaster _gameMaster;


        internal void Run(GameMaster gameMaster)
        {
            _gameMaster = gameMaster;
        }
    }
}