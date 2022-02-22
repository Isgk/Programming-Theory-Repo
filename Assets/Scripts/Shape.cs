using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class Shape : MonoBehaviour
{

    public GameObject shapeId;
    private Renderer renderer;
    public Material shapeMat;
    public TextMeshProUGUI shapeIdText;

    public string shapeName;
    public string shapeColor;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();

        shapeColor = shapeMat.name;
        shapeId = GameObject.Find("Id");
        shapeIdText = shapeId.GetComponent<TextMeshProUGUI>();
        shapeName = gameObject.name;






    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseEnter()
    {
        


        renderer.material.color = Color.blue;
        
    }

    private void OnMouseExit()
    {
        renderer.material = shapeMat;
    }

    private void OnMouseDown()
    {
        DisplayText(); 
        
    }

    public virtual void DisplayText()
    {
        shapeIdText.text = "This Is a " + shapeColor + " " + shapeName;
    }

    

}
