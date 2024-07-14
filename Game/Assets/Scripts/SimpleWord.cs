using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SimpleWord :  HangWordBase
{
    private float _x;
    private float _y;

    public override float X
    {
        get => _x;
        set
        {
            _x = value;
            float offset = 0;
            foreach (var item in HangChars)
            {
                item.X = _x + offset;
                offset += Spacing + item.Width;
            }
        }
    }
    public override float Y 
    {
        get => _y; 
        set
        {
            _y = value;
            foreach (var item in HangChars)
            {
                item.Y = _y;
            }
        }
    }
    public float Spacing { get; } = 10;

    public void SimpleWordInit(string word)
    {
        HangChars = new List<IHangChar>();
        foreach (var item in word)
        {
            // GameObject go = GameObject.Find("MainObject");
            // GameObject go = this.transform.parent.gameObject;
            SimpleChar ch = this.AddComponent<SimpleChar>();
            ch.SimpleCharInit(item,'_');
            ch.Parent = this.gameObject;
            HangChars.Add(ch);
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
