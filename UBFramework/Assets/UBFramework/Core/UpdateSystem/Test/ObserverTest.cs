using UnityEngine;
using Zenject;

namespace UBFramework.Core.UpdateSystem.Test
{
    public class ObserverTest : MonoBehaviour, IUpdateObserver, IFixedUpdateObserver, ILateUpdateObserver
    {
        private IUpdateManager _updateManager;
        private IFixedUpdateManager _fixedUpdateManager;
        private ILateUpdateManager _lateUpdateManager;

        [Inject]
        public void Construct(IUpdateManager updateManager, IFixedUpdateManager fixedUpdateManager,
                              ILateUpdateManager lateUpdateManager)
        {
            Debug.Log("Constructing Observer Test");
            _updateManager = updateManager;
            _fixedUpdateManager = fixedUpdateManager;
            _lateUpdateManager = lateUpdateManager;
        }

        private void OnEnable()
        {
            _updateManager.RegisterObserver(this);
            _fixedUpdateManager.RegisterObserver(this);
            _lateUpdateManager.RegisterObserver(this);
        }

        private void OnDisable()
        {
            _updateManager.UnregisterObserver(this);
            _fixedUpdateManager.UnregisterObserver(this);
            _lateUpdateManager.UnregisterObserver(this);
        }

        void IUpdateObserver.ObserverUpdate()
        {
            Debug.Log("Observer Update");
        }

        void IFixedUpdateObserver.ObserverUpdate()
        {
            Debug.Log("Fixed Observer Update");
        }

        void ILateUpdateObserver.ObserverUpdate()
        {
            Debug.Log("Late Observer Update");
        }
    }
}
