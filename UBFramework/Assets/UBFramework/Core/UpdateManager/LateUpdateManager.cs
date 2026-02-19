using System.Collections.Generic;
using UnityEngine;

namespace UBFramework.Core.UpdateManager
{
    public class LateUpdateManager : MonoBehaviour, ILateUpdateManager
    {
        private List<ILateUpdateObserver> _observers;
        private List<ILateUpdateObserver> _pendingObservers;
        private int _currentUpdateIndex;

        private void Awake()
        {
            _observers = new List<ILateUpdateObserver>();
            _pendingObservers = new List<ILateUpdateObserver>();
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

        public void RegisterObserver(ILateUpdateObserver updateObserver)
        {
            _pendingObservers.Add(updateObserver);
        }

        public void UnregisterObserver(ILateUpdateObserver updateObserver)
        {
            _observers.Remove(updateObserver);
            _currentUpdateIndex--;
        }
    }
}
