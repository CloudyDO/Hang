using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenKeyboard : MonoBehaviour, IHangKeyboard
{
    public event IHangKeyboard.HangKeyboardHangler OnKeyPressed;
 
    void OnKeyDown(char ch)
    {
       OnKeyPressed?.Invoke(ch);
    }

    void Awake()
    {
        var keys1 = gameObject.GetComponents<KeyboardKey>();
        var keys2 = GetComponents<KeyboardKey>();
        var keys = GetComponentsInChildren<KeyboardKey>();
        foreach (var key in keys)
        {
            key.OnKeyClicked += OnKeyDown;
        }
    }
}
