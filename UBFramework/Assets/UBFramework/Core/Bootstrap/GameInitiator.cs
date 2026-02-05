using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Rendering;

namespace UBFramework.Core.Bootstrap
{
    public class GameInitiator : MonoBehaviour
    {
        [SerializeField] private Camera _cameraPrefab;
        [SerializeField] private Light _lightPrefab;
        [SerializeField] private Volume _volumePrefab;
        
        private Camera _camera;
        private Light _light;
        private Volume _volume;
        
        /// <summary>
        /// This should be the only Start method in the game, and here is where all objects and systems are initialized.
        /// </summary>
        private async void Start()
        {
            BindObjects();
            await InitializeServices();
            await CreateObjects();
            PrepareGame();
        }

        /// <summary>
        /// Step 1: Create the main objects of the game and save their instances.
        /// </summary>
        private void BindObjects()
        {
            _camera = Instantiate(_cameraPrefab);
            _light = Instantiate(_lightPrefab);
            _volume = Instantiate(_volumePrefab);
        }
        
        /// <summary>
        /// Step 2: Initialize services like analytics, input system, UI system, etc.
        /// </summary>
        private async Task InitializeServices()
        {
        }
        
        /// <summary>
        /// Step 3: Create heavy assets from resources, asset bundles, or addressable 
        /// </summary>
        private async Task CreateObjects()
        {
        }
        
        /// <summary>
        /// Step 4: Prepare the created objects for the game.
        /// </summary>
        private void PrepareGame()
        {
        }
    }
}
