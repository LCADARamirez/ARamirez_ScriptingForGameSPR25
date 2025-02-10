using UnityEngine;

public class ConditionalPractice : MonoBehaviour
{
    public GameObject go;
    public GameObject go2;

    public Color go2ElseColor;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //ColorGameObjectByName();
        ColorGameObjectByTag();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ColorGameObjectByName()
    {
        Debug.Log("go is named " + go.name);
        Debug.Log("go2 is named " + go2.name);

        //GetComponent will look for the component on the gameObject it is being called on.
        //If there is no component of the type you are trying to get, when you use the
        //dot operator after it, it will throw a null reference exception.

        //If we create a local variable in the function that does the GetComponent call
        //once, we can use this variable multiple times that refers to this object's specific
        //MeshRenderer, which is more efficient than calling GetComponent multiple times!
        MeshRenderer goMeshRenderer = go.GetComponent<MeshRenderer>();

        if (go.name == "Cube")
        {
            
            goMeshRenderer.material.color = Color.magenta;
            //Change the color to magenta
        }
        else if (go.name == "Sphere")
        {
            goMeshRenderer.material.color = Color.cyan;
            //Change the color to cyan
        }
        else if (go.name == "Cylinder")
        {
            goMeshRenderer.material.color = Color.black;
            //Change the color to black
        }
        else
        {
            goMeshRenderer.material.color = new Color32(200, 100, 3, 255);
            //Change the color to Orange
        }

        MeshRenderer go2MeshRenderer = go2.GetComponent<MeshRenderer>();

        if (go2.name == "Cube")
        {
            go2MeshRenderer.material.color = Color.gray;
            //Change the color to gray
        }
        else if (go2.name == "Sphere")
        {
            go2MeshRenderer.material.color = Color.white;
            //Change the color to white
        }
        else if (go2.name == "Cylinder")
        {
            go2MeshRenderer.material.color = Color.red;
            //Change the color to red
        }
        else
        {
            go2MeshRenderer.material.color = go2ElseColor;
            //Change the color to our custom color
        }
    }

    void ColorGameObjectByTag()
    {

        MeshRenderer goMeshRenderer = go.GetComponent<MeshRenderer>();

        if (go.tag == "CoolGuy")
        {

            goMeshRenderer.material.color = Color.magenta;
            //Change the color to magenta
        }
        else if (go.tag == "NotCoolGuy")
        {
            goMeshRenderer.material.color = Color.cyan;
            //Change the color to cyan
        }
        else if (go.tag == "OkayGuy")
        {
            goMeshRenderer.material.color = Color.black;
            //Change the color to black
        }
        else
        {
            goMeshRenderer.material.color = new Color32(200, 100, 3, 255);
            //Change the color to Orange
        }

        MeshRenderer go2MeshRenderer = go2.GetComponent<MeshRenderer>();

        if (go2.tag == "CoolGuy")
        {
            go2MeshRenderer.material.color = Color.gray;
            //Change the color to gray
        }
        else if (go2.tag == "NotCoolGuy")
        {
            go2MeshRenderer.material.color = Color.white;
            //Change the color to white
        }
        else if (go2.tag == "OkayGuy")
        {
            go2MeshRenderer.material.color = Color.red;
            //Change the color to red
        }
        else
        {
            go2MeshRenderer.material.color = go2ElseColor;
            //Change the color to our custom color
        }
    }
}
