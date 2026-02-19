using System.Collections.Generic;
using UnityEngine;

namespace UBFramework.Core.UpdateManager
{
    public class FixedUpdateManager : MonoBehaviour, IFixedUpdateManager
    {
        private List<IFixedUpdateObserver> _observers;
        private List<IFixedUpdateObserver> _pendingObservers;
        private int _currentUpdateIndex;

        private void Awake()
        {
            _observers = new List<IFixedUpdateObserver>();
            _pendingObservers = new List<IFixedUpdateObserver>();
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

        public void RegisterObserver(IFixedUpdateObserver updateObserver)
        {
            _pendingObservers.Add(updateObserver);
        }

        public void UnregisterObserver(IFixedUpdateObserver updateObserver)
        {
            _observers.Remove(updateObserver);
            _currentUpdateIndex--;
        }
    }
}
