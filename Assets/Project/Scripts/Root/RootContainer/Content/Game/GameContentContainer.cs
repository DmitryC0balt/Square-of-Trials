using UnityEngine;

using Scripts.Model.PlayerCamera;
using Scripts.Model.ObjectPool;
using Scripts.Model.Stage;
using Scripts.Model.Basement;
using Scripts.Model.Session;
using Scripts.Model.Shop;


namespace Scripts.Root.RootContainer
{
    public class GameContentContainer : ContentContainer
    {
        [Header("Management presets")]
        
        [SerializeField]private PoolBuilder _poolBuilder;//1
        [SerializeField]private StageBuilder _stageBuilder;//2
        [SerializeField]private BasementBuilder _basementBuilder;//3
        [SerializeField]private CameraSystem _cameraSystem;//4


        private SessionMaster _sessionMaster;//RT1
        private ShopMaster _shopMaster;//RT2
        

        internal override void Init()
        {
            _poolBuilder = GetComponent<PoolBuilder>();
            _poolBuilder.Init();

            _stageBuilder = GetComponent<StageBuilder>();
            _stageBuilder.Init();

            _basementBuilder = GetComponent<BasementBuilder>();
            _basementBuilder.Init();

            _cameraSystem = GetComponent<CameraSystem>();
            //_cameraSystem.Init();


            _sessionMaster = new SessionMaster();
            _shopMaster = new ShopMaster();

            
            base.Init();
        }
    }
}

