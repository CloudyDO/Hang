using UnityEngine;

public class RegularKeyboard : MonoBehaviour, IHangKeyboard
{
    public event IHangKeyboard.HangKeyboardHangler OnKeyPressed;

    void OnKeyDown(char ch)
    {
       OnKeyPressed?.Invoke(ch);
    }
    void OnGUI()
    {
        if (Event.current.isKey)
        {
            OnKeyDown(Event.current.character);
        }
    }
}
