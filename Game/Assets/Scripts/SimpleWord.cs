using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SimpleWord : HangWordBase
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
                item.X = offset;
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
    public float Spacing { get; } = 10;

    public void SimpleWordInit(string word)
    {
        HangChars = new List<IHangChar>();
        Geo = new GameObject("HangWord");
        foreach (var item in word)
        {
            SimpleChar ch = Geo.AddComponent<SimpleChar>();
            ch.SimpleCharInit(item, '_');
            ch.Parent = Geo;
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
