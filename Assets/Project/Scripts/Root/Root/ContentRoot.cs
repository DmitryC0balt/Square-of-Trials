using UnityEngine;

namespace Scripts.Root.Root
{
    public class ContentRoot : MonoBehaviour
    {
        [SerializeField]private Transform _container;

        public void LoadContainer(GameObject container)
        {
            CleanContainer();

            container.transform.SetParent(_container,false);
        }


        private void CleanContainer()
        {
            var childCount = _container.transform.childCount;

            for (var i = 0; i < childCount; i++)
            {
                Destroy(_container.GetChild(i).gameObject);
            }
        }
    }
}