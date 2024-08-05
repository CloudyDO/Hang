using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SimpleChar : MonoBehaviour, IHangChar
{

    private float _x = 0;
    private float _y = 0;
    private float _width;
    private float _height;

    private GameObject _parent;

    private bool _isMasked;
    public char RealChar { get; set; }
    public char MaskChar { get; set; }
    public bool IsMasked
    {
        get { return _isMasked; }
        set
        {
            _isMasked = value;
            if (UText != null)
            {
                UText.text = _isMasked ? MaskChar.ToString() : RealChar.ToString();
            }
        }
    }
    public float X
    {
        get => _x;
        set
        {
            _x = value;
            Geo.transform.localPosition = new Vector3(_x, _y, 0);
        }
    }

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
    public float Y { get; set; }
    public float Height
    {
        get => _height;

        set
        {
            _height = value;
            RectTransform rt = Geo.GetComponent<RectTransform>();
            rt.sizeDelta = new Vector2(_width, _height);
        }
    }
    public float Width
    {
        get => _width;

        set
        {
            _width = value;
            RectTransform rt = Geo.GetComponent<RectTransform>();
            rt.sizeDelta = new Vector2(_width, _height);
        }
    }
    public GameObject Geo { get; set; }
    private Text UText { get; set; }
    private List<SimpleChar> _allChars = new List<SimpleChar>();
    public void SimpleCharInit(char realChar, char maskChar)
    {
        IsMasked = true;
        RealChar = realChar;
        MaskChar = maskChar;
        Geo = new GameObject("HangChar");
        UText = Geo.AddComponent<Text>();
        UText.text = maskChar.ToString();

        UText.alignment = TextAnchor.MiddleCenter;
        Width = 50;
        Height = 70;

        Geo.transform.localPosition = new Vector3(X, Y);
        UText.fontSize = 64;
        UText.resizeTextMaxSize = 60;
        UText.font = Resources.GetBuiltinResource(typeof(Font), "LegacyRuntime.ttf") as Font;
        UText.resizeTextForBestFit = true;

        _allChars.Add(this);
    }
    void Start()
    {

    }
    void Update()
    {
    }
}
