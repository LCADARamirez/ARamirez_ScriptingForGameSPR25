using TMPro;
using UnityEngine;

public class UIReferenceTest : MonoBehaviour
{
    public TextMeshProUGUI textObject;
    public int numMisclicks = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        textObject.text = numMisclicks.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            RaycastHit2D rayhit = Physics2D.GetRayIntersection(Camera.main.ScreenPointToRay(Input.mousePosition));

            if(rayhit.transform != null)
            {
                if (rayhit.collider.tag == "Luigi")
                {
                    Debug.Log("Correct!");
                }
                else
                {
                    Debug.Log("Hit something else");
                }
            }
        }
    }
}
