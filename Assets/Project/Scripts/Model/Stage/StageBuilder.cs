using UnityEngine;

namespace Scripts.Model.Stage
{
    public class StageBuilder : MonoBehaviour
    {
        [SerializeField]private int _stageRadius;
        [SerializeField]private int _stageOffset;

        [SerializeField]private HeroPlacement _heroPlacement;
        [SerializeField]private TowerPlacement _towerPlacement;
        [SerializeField]private SpawnerPlacement _spawnerPlacement;

        internal void Init()
        {
            _towerPlacement.Init();
            _heroPlacement.Init();
        }
    }
}