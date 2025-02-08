using UnityEngine;

namespace Scripts.Root.RootContainer
{
    public abstract class UIContainer : MonoBehaviour
    {
        internal virtual void Init()
        {
            Debug.Log("UI container is loaded");
        }
    }
}