using UnityEngine;
using Zenject;

namespace UBFramework.UI.UISystem
{
    public class UIScreen : MonoBehaviour
    {
        [Inject]
        public IUIManager _uiManager;
    }
}
