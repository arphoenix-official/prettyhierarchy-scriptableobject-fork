using UnityEngine;
using UnityEditor;

namespace PrettyHierarchy
{
    [DisallowMultipleComponent]
    public class PrettyObject : MonoBehaviour
    {
#if UNITY_EDITOR
        public PrettyObjectSO prettySO;

        public bool UseDefaultBackgroundColor { get {
                return prettySO != null ? prettySO.useDefaultBackgroundColor : true;
            } }
        public Color32 BackgroundColor { get {
                return prettySO != null ? new Color32(prettySO.backgroundColor.r, prettySO.backgroundColor.g, prettySO.backgroundColor.b, 255) :
                    new Color32(0, 0, 0, 255); 
            } }

        public bool UseDefaultTextColor { get {
                return prettySO != null ? prettySO.useDefaultTextColor : true; 
            } }
        public Color32 TextColor { get {
                return prettySO != null ? prettySO.textColor : new Color32(255, 255, 255, 255); 
            } }
        public Font Font { get {
                return prettySO != null ? prettySO.font : null;
            } }
        public int FontSize { get {
                return prettySO != null ? prettySO.fontSize : 12; 
            } }
        public FontStyle FontStyle { get {
                return prettySO != null ? prettySO.fontStyle : FontStyle.Normal; 
            } }
        public TextAnchor Alignment { get {
                return prettySO != null ? prettySO.alignment : TextAnchor.UpperLeft; 
            } }
        public bool TextDropShadow { get {
                return prettySO != null ? prettySO.textDropShadow : false; 
            } }

        private void OnValidate()
        {
            EditorApplication.RepaintHierarchyWindow();
        }
#endif
    }
}