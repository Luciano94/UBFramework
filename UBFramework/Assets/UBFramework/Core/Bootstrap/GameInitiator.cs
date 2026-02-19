using UnityEngine;
using UnityEngine.Rendering;
using UBFramework.Core.UpdateManager;
using UBFramework.Core.UpdateManager.Test;
using Zenject;


namespace UBFramework.Core.Bootstrap
{
    public class GameInitiator : MonoInstaller
    {
        [SerializeField] private Camera _cameraPrefab;
        [SerializeField] private Light _lightPrefab;
        [SerializeField] private Volume _volumePrefab;
        [SerializeField] private ObserverTest _updateObserverPrefab;
        [SerializeField] private UpdateManager.UpdateManager _updateManagerPrefab;
        [SerializeField] private LateUpdateManager _lateUpdateManagerPrefab;
        [SerializeField] private FixedUpdateManager _fixedUpdateManagerPrefab;
        
        private Camera _camera;
        private Light _light;
        private Volume _volume;
        private ObserverTest _updateObserver;
        private LateUpdateManager _lateUpdateManager;
        private FixedUpdateManager _fixedUpdateManager;
        private UpdateManager.UpdateManager _updateManager;
        
        /// <summary>
        /// This should be the only Start method in the game, and here is where all objects and systems are initialized.
        /// </summary>
        public override void Start()
        {
            base.Start();
            BindObjects();
            InitializeServices();
            CreateObjects();
            PrepareGame();
            BeginGame();
        }

        /// <summary>
        /// Step 0: Bind systems to being injected later.
        /// </summary>
        public override void InstallBindings()
        {
            Container.Bind<IUpdateManager>().To<UpdateManager.UpdateManager>().AsSingle();
            Container.Bind<IFixedUpdateManager>().To<FixedUpdateManager>().AsSingle();
            Container.Bind<ILateUpdateManager>().To<LateUpdateManager>().AsSingle();
        }
        
        /// <summary>
        /// Step 1: Create the main objects of the game and save their instances.
        /// </summary>
        private void BindObjects()
        {
            _camera = Instantiate(_cameraPrefab);
            _light = Instantiate(_lightPrefab);
            _volume = Instantiate(_volumePrefab);
            _updateManager = Instantiate(_updateManagerPrefab);
            _lateUpdateManager = _updateManager.GetComponent<LateUpdateManager>();
            _fixedUpdateManager = _updateManager.GetComponent<FixedUpdateManager>();
            _updateObserver = Instantiate(_updateObserverPrefab);
        }
        
        /// <summary>
        /// Step 2: Initialize services like analytics, input system, UI system, etc.
        /// </summary>
        /// async Task
        private void InitializeServices()
        {
        }
        
        /// <summary>
        /// Step 3: Create heavy assets from resources, asset bundles, or addressable.
        /// </summary>
        /// async Task
        private void CreateObjects()
        {
        }
        
        /// <summary>
        /// Step 4: Prepare the created objects for the game.
        /// </summary>
        private void PrepareGame()
        {
        }
        
        /// <summary>
        /// Step 5: Start the game flow.
        /// </summary>
        private void BeginGame()
        {
        }
    }
}
