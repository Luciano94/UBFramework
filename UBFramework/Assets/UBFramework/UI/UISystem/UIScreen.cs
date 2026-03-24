using UnityEngine;
using Zenject;

namespace UBFramework.UI.UISystem
{
    public class UIScreen : MonoBehaviour
    {
        [Inject]
        private IUIManager _uiManager;
        
        [SerializeField]
        private ScreenID _screenID;
    }
}
