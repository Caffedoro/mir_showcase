using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;

public class Player : MonoBehaviour
{
    [SerializeField] private Transform _ptrans;
   public float Speed = 2f;
    public float jumpHeight = 2f;
   public float gravity = -9f;
   
   public float rotateSpeed = 7f;

   private CharacterController controller; 
  // private Rigidbody _rb;
   private Vector3 velocity;
   private Vector2 moveInput;
   private Vector2 rotateInput;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
      void Start()
    {
        controller = GetComponent<CharacterController>();
   //     _rb = GetComponent<Rigidbody>(); 
       // _P = GameObject.Find("Player");
    }
 
 public void OnMove(InputAction.CallbackContext context){

  moveInput = context.ReadValue<Vector2>();
  Debug.Log($"move input: {moveInput}");
 }

 public void OnJump(InputAction.CallbackContext context){

  Debug.Log($"Jumping {context.performed} - is grounded: {controller.isGrounded}");
  if(context.performed && controller.isGrounded){

    Debug.Log($"yeah boy jump");
    velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
  } 
    
     }
    // Update is called once per frame
    void Update()
    {

        Vector3 forward = _ptrans.forward;

        Vector3 right = _ptrans.right;

        forward.y = 0f;

        right.y = 0f;

        forward.Normalize();
        right.Normalize();  

        Vector3 moveDirection = forward * moveInput.y + right * moveInput.x;
        controller.Move(moveDirection * Speed * Time.deltaTime);

        //Vector3 move = new Vector3(moveInput.x, 0, moveInput.y);
        //  controller.Move( move * Speed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);

       Vector3 turn = new Vector3(0, rotateInput.x, 0);
       transform.Rotate(turn * rotateSpeed * Time.deltaTime);
    }


public void OnLook(InputAction.CallbackContext context){
  rotateInput = context.ReadValue<Vector2>();
  Debug.Log($"rotate input: {rotateInput}");

}
    void FixedUpdate(){
      
    }
}
