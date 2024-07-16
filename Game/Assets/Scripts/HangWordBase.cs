using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HangWordBase : MonoBehaviour, IHangWord
{
    private GameObject _parent;
    
    private float _width;
    private float _height = 24;
    public virtual float X { get; set; }
    public virtual float Y { get; set; }

    public List<IHangChar> HangChars { get; set; }
    public GameObject Parent
    {
        get => _parent;
        set
        {
            _parent = value;
            if (Geo != null)
            {
                Geo.transform.SetParent(_parent.transform, false);
            }
        }
    }
    public float Width
    {
        get => _width;
        set
        {
            _width = value;
            RectTransform rt = Geo.GetComponent<RectTransform>();
            rt.sizeDelta = new Vector2(_width,_height);
        }
    }
    public float Height
    {
        get => _height;
        set
        {
            _height = value;
            RectTransform rt = Geo.GetComponent<RectTransform>();
            rt.sizeDelta = new Vector2(_width,_height);
        }
    }
    public GameObject Geo { get; set; }
    public void Show()
    {

    }
    public void Hide()
    {

    }
    public bool checkCharacter(char character)
    {
        bool res = false;
        if (HangChars == null) return res;

        for (int i = 0; i < HangChars.Count; i++)
        {
            if (HangChars[i].RealChar == character)
            {
                res = true;
                break;
            }
        }
        return res;
    }

    public void unmaskCharacter(char character)
    {
        if (HangChars == null) return;

        for (int i = 0; i < HangChars.Count; i++)
        {
            if (HangChars[i].RealChar == character)
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
