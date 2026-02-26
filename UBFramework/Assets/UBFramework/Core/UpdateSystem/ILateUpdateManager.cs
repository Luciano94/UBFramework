namespace UBFramework.Core.UpdateSystem
{
    public interface ILateUpdateManager
    {
        public void RegisterObserver(ILateUpdateObserver updateObserver);
        public void UnregisterObserver(ILateUpdateObserver updateObserver);
    }
}
