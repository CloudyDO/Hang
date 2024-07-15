using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IHangWord
{
    float X { get; set; }
    float Y { get; set; }
    List<IHangChar> HangChars { get; set; }
    void unmaskCharacter(char character);
    bool checkCharacter(char character);
    GameObject Parent { get; set; }
}
