using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape
{
    public override void DisplayText()
    {
        base.DisplayText();
        shapeIdText.text = shapeIdText.text + "  " + "Booom";

    }





}
