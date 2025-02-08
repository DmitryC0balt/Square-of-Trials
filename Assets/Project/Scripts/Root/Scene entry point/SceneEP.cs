using UnityEngine;

using Scripts.Root.RootContainer;

namespace Scripts.Root.SceneEntryPoint
{
    public abstract class SceneEP : MonoBehaviour
    {
        [Header("Content presets")]
        [SerializeField]protected UIContainer _uiContainer;
        [SerializeField]protected ContentContainer _contentContainer;
        [SerializeField]protected SoundContainer _soundContainer;


        private bool _isStarted;


        protected abstract void Init();
        protected abstract void Dispose();
        protected abstract void Process();
        protected abstract void PostProcess();
        

        internal void Run()
        {
            Init();
            _isStarted = true;
        }
        
        
        internal void Stop()
        {
            _isStarted = false;
            Dispose();
        }


        private void Update()
        {
            if (!_isStarted) return;
            Process();
        }


        private void LateUpdate()
        {
            if (!_isStarted) return;
            PostProcess();
        }
    }
}