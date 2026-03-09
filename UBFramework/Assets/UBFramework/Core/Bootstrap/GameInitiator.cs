using UBFramework.Core.UpdateSystem;
using UBFramework.UI.UISystem;
using UnityEngine;
using UnityEngine.Rendering;
using Zenject;


namespace UBFramework.Core.Bootstrap
{
    public class GameInitiator : MonoInstaller<GameInitiator>
    {
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
            Container.Bind<IUpdateManager>().To<UpdateManager>().FromNewComponentOnNewGameObject().AsSingle();
            Container.Bind<IFixedUpdateManager>().To<FixedUpdateManager>().FromNewComponentOnNewGameObject().AsSingle();
            Container.Bind<ILateUpdateManager>().To<LateUpdateManager>().FromNewComponentOnNewGameObject().AsSingle();
            
            Container.Bind<Camera>().To<Camera>().FromNewComponentOnNewGameObject().AsSingle();
            Container.Bind<Light>().To<Light>().FromNewComponentOnNewGameObject().AsSingle();
            Container.Bind<Volume>().To<Volume>().FromNewComponentOnNewGameObject().AsSingle();
            
            Container.Bind<IUIManager>().To<UIManager>().FromNewComponentOnNewGameObject().AsSingle();
        }
        
        /// <summary>
        /// Step 1: Create the main objects of the game and save their instances.
        /// </summary>
        private void BindObjects()
        {
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
