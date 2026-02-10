namespace UBFramework.Core.UpdateManager
{
    public interface IFixedUpdateManager
    {
        public void RegisterObserver(IFixedUpdateObserver updateObserver);
        public void UnregisterObserver(IFixedUpdateObserver updateObserver);
    }
}
