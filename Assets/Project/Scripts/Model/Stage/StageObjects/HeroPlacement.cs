using UnityEngine;

namespace Scripts.Model.Stage
{
    public class HeroPlacement : MonoBehaviour
    {
        [SerializeField]private Transform _leftHeroPlace;
        [SerializeField]private Transform _rightHeroPlace;
        [SerializeField]private Transform _upHeroPlace;
        [SerializeField]private Transform _downHeroPlace;

        
        internal void Init()
        {
            
        }
    }
}