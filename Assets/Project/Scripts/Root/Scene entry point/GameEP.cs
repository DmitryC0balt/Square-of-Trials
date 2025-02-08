using UnityEngine;

namespace Scripts.Root.SceneEntryPoint
{
    public class GameEP : SceneEP
    {
        protected override void Init()
        {
            Debug.Log("Game scene is loaded");
        }


        protected override void Dispose()
        {
            Debug.Log("Game scene is disposed");      
        }


        protected override void Process()
        {
            
        }


        protected override void PostProcess()
        {
            
        }


        
    }
}