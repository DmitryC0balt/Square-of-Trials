using System.Collections;

using UnityEngine;
using UnityEngine.SceneManagement;

using Scripts.Root.Root;
using Scripts.Root.RootContainer;
using Scripts.Root.SceneEntryPoint;


namespace Scripts.Root.EntryPoint
{
    public class GameEntryPoint
    {
        private static GameEntryPoint _instance;


        private GameMaster _gameMaster;

        private UIRoot _uiRoot;
        private ContentRoot _contentRoot;
        private SoundRoot _soundRoot;


//===========================================================================================

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        public static void Launch()
        {
            _instance = new GameEntryPoint();

            Application.targetFrameRate = 60;
            Screen.sleepTimeout = SleepTimeout.NeverSleep;

            _instance.StartGame();
        }

//===========================================================================================

        private GameEntryPoint()
        {
            var gameMaster = Resources.Load<GameMaster>("Root/GameMaster");
            _gameMaster = Object.Instantiate(gameMaster);
            Object.DontDestroyOnLoad(_gameMaster.gameObject);


            var contentRoot = Resources.Load<ContentRoot>("Root/ContentRoot");
            _contentRoot = Object.Instantiate(contentRoot);
            Object.DontDestroyOnLoad(_contentRoot.gameObject);


            var uiRoot = Resources.Load<UIRoot>("Root/UIRoot");
            _uiRoot = Object.Instantiate(uiRoot);
            Object.DontDestroyOnLoad(_uiRoot);


            var soundRoot = Resources.Load<SoundRoot>("Root/SoundRoot");
            _soundRoot = Object.Instantiate(soundRoot);
            Object.DontDestroyOnLoad(_soundRoot);
        }


        private void StartGame()
        {
            var sceneName = SceneManager.GetActiveScene().name;

#if UNITY_EDITOR

            if ((sceneName == SceneNaming.MENU) || (sceneName == SceneNaming.GAME))
            {
                _gameMaster.StartCoroutine(LoadTargetScene(sceneName));
                return;
            }


            if (sceneName != SceneNaming.BOOT)
            {
                return;
            }

#endif

            LoadTargetScene(SceneNaming.MENU);
        }

//===========================================================================================

#region scene_loading

        internal void SwitchScene(string sceneName) => _gameMaster.StartCoroutine(LoadTargetScene(sceneName));


        private IEnumerator LoadScene(string sceneName)
        {
            yield return SceneManager.LoadSceneAsync(sceneName);
        }


        private void LoadSceneContainer(SceneEP sceneEntryPoint)
        {
            sceneEntryPoint.Run();
        }


        private IEnumerator LoadTargetScene(string sceneName)
        {
            _uiRoot.ShowLoadingScreen(true);

            yield return LoadScene(SceneNaming.BOOT);
            yield return LoadScene(sceneName);
            yield return new WaitForSeconds(1.5f);

            var sceneEntryPoint = Object.FindFirstObjectByType<SceneEP>();
            LoadSceneContainer(sceneEntryPoint);

            _uiRoot.ShowLoadingScreen(false);
        } 

#endregion

//===========================================================================================

    }
}