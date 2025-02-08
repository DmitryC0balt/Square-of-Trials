using UnityEngine;

namespace Scripts.Root.SceneEntryPoint
{
    public class MenuEP : SceneEP
    {
        protected override void Init()
        {
            Debug.Log("Menu scene is loaded");
        }


        protected override void Dispose()
        {
            Debug.Log("Menu scene is disposed");
        }


        protected override void Process()
        {
            
        }
        

        protected override void PostProcess()
        {
            
        }  
    }
}