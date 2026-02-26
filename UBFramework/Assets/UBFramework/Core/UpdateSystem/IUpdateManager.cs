namespace UBFramework.Core.UpdateSystem
{
    public interface IUpdateManager
    {
        public void RegisterObserver(IUpdateObserver updateObserver);
        public void UnregisterObserver(IUpdateObserver updateObserver);
    }
}
