using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public delegate void HangKeyboardHangler(char key);
    public static event  HangKeyboardHangler OnKeyPressed;
    public static void OnKeyDown(char key)
    {
        OnKeyPressed?.Invoke(key);
    }
}
