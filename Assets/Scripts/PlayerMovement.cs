using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   
   public float moveSpeed = 5f; 
   private Rigidbody rb; 
   
   void Start()
   {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(moveX, 0, moveZ) * moveSpeed;
        rb.MovePosition(rb.position + move * Time.fixedDeltaTime);
    }
}
