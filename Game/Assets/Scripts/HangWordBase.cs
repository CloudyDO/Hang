using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HangWordBase : MonoBehaviour, IHangWord
{
    public virtual float X {get; set;}
    public virtual float Y {get; set;}

    public List<IHangChar> HangChars {get; set;}
    public void Show()
    {

    }
    public void Hide()
    {

    }
    public bool checkCharacter(char character)
    {
        bool res = false;
        if(HangChars == null) return res;

        for(int i = 0; i < HangChars.Count; i++)
        {
            if(HangChars[i].RealChar == character)
            {
                res = true;
                break;
            }
        }
        return res;
    }
    
    public void unmaskCharacter(char character)
    {
        if(HangChars == null) return;

        for(int i = 0; i < HangChars.Count; i++)
        {
            if(HangChars[i].RealChar == character)
            {
                HangChars[i].IsMasked = false;
            }
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
