using UnityEngine;

namespace Scripts.Root.RootContainer
{
    public abstract class ContentContainer : MonoBehaviour
    {
        internal virtual void Init()
        {
            Debug.Log("Content container is loaded");
        }
    }
}