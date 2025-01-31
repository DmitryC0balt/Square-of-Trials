using System.Collections;

using UnityEngine;
using UnityEngine.SceneManagement;

using Scripts.Scenes;
using Scripts.Root.Root;
using Scripts.Root.SceneEntryPoint;


namespace Scripts.Root.GameEntryPoint
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

            Application.targetFrameRate = (int)_instance._gameMaster.GameFrameRate(true);
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

            if (sceneName == SceneNaming.MENU)
            {
                _gameMaster.StartCoroutine(LoadMenuScene());
                return;
            }

            if (sceneName == SceneNaming.GAME)
            {
                _gameMaster.StartCoroutine(LoadGameScene());
                return;
            }

            if (sceneName != SceneNaming.BOOT)
            {
                return;
            }

#endif

            LoadMenuScene();
        }

//===========================================================================================

#region scene_loading

        private IEnumerator LoadScene(string sceneName)
        {
            yield return SceneManager.LoadSceneAsync(sceneName);
        }


        private IEnumerator LoadMenuScene()
        {
            _uiRoot.ShowLoadingScreen(true);

            yield return LoadScene(SceneNaming.BOOT);
            yield return LoadScene(SceneNaming.MENU);
            yield return new WaitForSeconds(1);

            var sceneEntryPoint = Object.FindFirstObjectByType<MenuEntryPoint>();
            sceneEntryPoint.Run(_gameMaster);

            _uiRoot.ShowLoadingScreen(false);
        }


        private IEnumerator LoadGameScene()
        {
            _uiRoot.ShowLoadingScreen(true);

            yield return LoadScene(SceneNaming.BOOT);
            yield return LoadScene(SceneNaming.GAME);
            yield return new WaitForSeconds(1);

            var sceneEntryPoint = Object.FindFirstObjectByType<GameplayEntryPoint>();
            sceneEntryPoint.Run(_gameMaster);

            _uiRoot.ShowLoadingScreen(false);
        }
    }

#endregion

//===========================================================================================

}