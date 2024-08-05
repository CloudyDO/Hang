using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

[RequireComponent(typeof(UIDocument))]
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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
