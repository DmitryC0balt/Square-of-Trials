using Scripts.Root.RootContainer;

using UnityEngine;

namespace Scripts.Root.Root
{
    public class UIRoot : MonoBehaviour
    {
        [SerializeField]private GameObject _loadingScreen;
        [SerializeField]private Transform _uiContainer;


        internal void ShowLoadingScreen(bool value) => _loadingScreen.SetActive(value);


        internal void LoadContainer(UIContainer container)
        {
            CleanContainer();

            container.transform.SetParent(_uiContainer,false);
        }


        private void CleanContainer()
        {
            var childCount = _uiContainer.childCount;

            for (var i = 0; i < childCount; i++)
            {
                Destroy(_uiContainer.GetChild(i).gameObject);
            }
        }
    }
}