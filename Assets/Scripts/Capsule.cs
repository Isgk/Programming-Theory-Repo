using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : Shape
{
    public override void DisplayText()
    {
        base.DisplayText();
        shapeIdText.text = shapeIdText.text + "  " + "Cap Cap";

    }


    //

}
