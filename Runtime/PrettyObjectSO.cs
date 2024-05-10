using UnityEngine;

[CreateAssetMenu(fileName = "New Pretty Object Setting", menuName = "Scriptable Objects/PrettyObject")]
public class PrettyObjectSO : ScriptableObject
{
    public bool useDefaultBackgroundColor;
    public Color32 backgroundColor = new Color32(255, 255, 255, 255);
    public bool useDefaultTextColor;
    public Color32 textColor = new Color32(255, 255, 255, 255);
    public Font font;
    public int fontSize = 12;
    public FontStyle fontStyle = FontStyle.Normal;
    public TextAnchor alignment = TextAnchor.UpperLeft;
    public bool textDropShadow;
}
