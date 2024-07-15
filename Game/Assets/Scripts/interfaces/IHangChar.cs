using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IHangChar
{
   char RealChar { get; set; }
   bool IsMasked { get; set; }
   float X { get; set; }
   float Y { get; set; }
   float Height { get; set; }
   float Width { get; set; }
   GameObject Geo { get; set; }
   GameObject Parent { get; set; }
}
