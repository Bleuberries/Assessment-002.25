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

        Vector3 move = new Vector3(moveX, 0, moveZ).normalized;

        if (move.magnitude > 0.01f)
        {
            //move the player
            rb.MovePosition(rb.position + move * Time.fixedDeltaTime);

            //Rotate the player to face movement direction
            Quaternion toRotation = Quaternion.LookRotation(move, Vector3.up);
            rb.MoveRotation(toRotation);
        }
        
    }

    void OnTriggerEnter(Collider other)
{
    if (other.CompareTag("Shard"))
    {
        Destroy(other.gameObject);
        Debug.Log("Shard collected!");
    }
}
    

}
