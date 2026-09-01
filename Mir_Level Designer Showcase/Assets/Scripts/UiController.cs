using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;

public class UiController : MonoBehaviour
{
    public GameObject textObject1;
    public GameObject textObject2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }


    public void PressP(InputAction.CallbackContext context){

        Debug.Log($"NikolasMir");
        if(textObject1 != null)
        {
            textObject1.SetActive(!textObject1.activeSelf);
        }
        
    }

    public void PressO(InputAction.CallbackContext context){

        Debug.Log($"ShowGoals");
        
        if (textObject2 != null)
        {
            textObject2.SetActive(!textObject2.activeSelf);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
