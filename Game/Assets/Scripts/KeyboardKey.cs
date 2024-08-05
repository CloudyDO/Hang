using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class KeyboardKey : MonoBehaviour
{
    public delegate void OnKeyClickedDelegate(char ch);
    public event OnKeyClickedDelegate OnKeyClicked;
    public void OnClick()
    {
        var t = this.GetComponentInChildren<TextMeshProUGUI>();
        OnKeyClicked?.Invoke(t.text[0]);
    }
}
