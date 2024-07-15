using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SimpleWord : HangWordBase
{
    private float _x;
    private float _y;
    private float _border;
    public float Border
    {
        get => _border;
        set => _border = value;
    }

    public override float X
    {
        get => _x;
        set
        {
            _x = value;
            float offset = -this.Width/2;
            foreach (var item in HangChars)
            {
                item.X = offset + item.Width/2 + Border/2;
                offset += Spacing + item.Width;
            }

            Geo.transform.localPosition = new Vector3(_x, _y, 0);
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

            Geo.transform.localPosition = new Vector3(_x, _y, 0);
        }
    }
    public float Spacing { get; } = 0;

    public void SimpleWordInit(string word)
    {
        HangChars = new List<IHangChar>();
        Geo = new GameObject("HangWord");
        Geo.AddComponent<RectTransform>();

        SimpleChar let = new SimpleChar();
        let.SimpleCharInit('a','_');
        //this.Width = 100;
        //this.Height = 100;

        Border = 10;
        this.Width = word.Length * let.Width + Border;
        this.Height = let.Height + 5;
        //Geo.anchorMin = new Vector2(0.5f, 1);
        //panelRectTransform.anchorMax = new Vector2(0.5f, 1);
        //panelRectTransform.pivot = new Vector2(0.5f, 0.5f);

        foreach (var item in word)
        {
            SimpleChar ch = Geo.AddComponent<SimpleChar>();
            ch.SimpleCharInit(item, '_');
            ch.Parent = Geo;
            //ch.transform.localPosition = new Vector3(-this.Width/2+ch.Width/2,0,0);
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
