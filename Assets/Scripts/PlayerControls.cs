using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    [SerializeField]
    private float MoveSpeed = 0;

    [SerializeField]
    private float JumpForce = 0;

 
    private Rigidbody2D rb2d;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        PlayerControl();
        //Jump();
    }

	private void PlayerControl()
    {
        float run = Input.GetAxis("Horizontal") * MoveSpeed;
        Vector3 movement = new Vector3(run, 0, 0);

        rb2d.AddForce(Vector2.right * movement);
       
    }

  

  // private void Jump()
   //{
    // if(Input.GetButton("Jump"))
     //   {
         
      //  }
     
  // }
			
}
