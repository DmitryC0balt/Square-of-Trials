using Scripts.Root.RootContainer;

using UnityEngine;

namespace Scripts.Root.Root
{
    public class SoundRoot : MonoBehaviour
    {
        [SerializeField]private Transform _container;


        internal void LoadContainer(SoundContainer container)
        {
            CleanContainer();

            container.transform.SetParent(_container,false);
        }


        private void CleanContainer()
        {
            var childCount = _container.childCount;

            for (var i = 0; i < childCount; i++)
            {
                Destroy(_container.GetChild(i).gameObject);
            }
        }
    }
}