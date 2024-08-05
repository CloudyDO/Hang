using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IHangKeyboard
{
    delegate void HangKeyboardHangler(char key);
    event HangKeyboardHangler OnKeyPressed;
}
