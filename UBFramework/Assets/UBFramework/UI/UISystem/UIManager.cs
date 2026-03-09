using System;
using System.Collections.Generic;
using UBFramework.Core.UpdateSystem;
using UnityEngine;
using UnityEngine.Rendering;
using Zenject;

namespace UBFramework.UI.UISystem
{
    // A unique ID that identifies each Screen.
    public enum ScreenID
    {
    }

    public interface IUIManager
    {
        public Camera UICamera { get; }
    }
    
    public class UIManager : MonoBehaviour, IUpdateObserver, IUIManager
    {
        [Inject] private Camera _uiCamera;
        [Inject] private Light _light;
        [Inject] private Volume _volume;
        
        // Dependencies
        private IUpdateManager _updateManager;
        
        // Private fields
        private List<UIScreen> _uiScreens;
        
        // Public accessors
        public Camera UICamera => _uiCamera;
        
        [Inject]
        public void Construct(IUpdateManager updateManager)
        {
            _updateManager = updateManager;
        }

        private void OnEnable()
        {
            _updateManager.RegisterObserver(this);
        }

        private void OnDisable()
        {
            _updateManager.RegisterObserver(this);
        }

        // Update UI.
        public void ObserverUpdate()
        {
        }
    }
}
