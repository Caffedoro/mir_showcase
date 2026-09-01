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
    
    }

    public void PressO(InputAction.CallbackContext context){

        Debug.Log($"ShowGoals");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
