using System;
using System.Collections.Generic;
using UnityEngine;

namespace UBFramework.Core.UpdateManager
{
    public class UpdateManager : MonoBehaviour, IUpdateManager
    {
        private List<IUpdateObserver> _observers;
        private List<IUpdateObserver> _pendingObservers;
        private int _currentUpdateIndex;

        private void Awake()
        {
            _observers = new List<IUpdateObserver>();
            _pendingObservers = new List<IUpdateObserver>();
        }

        private void Update()
        {
            for (_currentUpdateIndex = _observers.Count - 1; _currentUpdateIndex >= 0; _currentUpdateIndex--)
            {
                _observers[_currentUpdateIndex].ObserverUpdate();
            }
        
            _observers.AddRange(_pendingObservers);
            _pendingObservers.Clear();
        }

        public void RegisterObserver(IUpdateObserver updateObserver)
        {
            _pendingObservers.Add(updateObserver);
        }

        public void UnregisterObserver(IUpdateObserver updateObserver)
        {
            _observers.Remove(updateObserver);
            _currentUpdateIndex--;
        }
    }
}
