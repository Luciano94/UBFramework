namespace UBFramework.Core.UpdateSystem
{
    public interface IFixedUpdateManager
    {
        public void RegisterObserver(IFixedUpdateObserver updateObserver);
        public void UnregisterObserver(IFixedUpdateObserver updateObserver);
    }
}
