using System.Collections.Generic;
using UBFramework.UI.UISystem;
using UnityEngine;

namespace Prefabs.Core.UI.Screens
{
    [CreateAssetMenu(fileName = "NewUIRegisteredScreenAsset", menuName = "UI Manager/Screen Data")]
    public class RegisteredScreens : ScriptableObject
    {
        public List<UIScreen> Screens;
    }
}
