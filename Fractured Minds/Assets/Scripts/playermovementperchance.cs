    using UnityEngine;
    public class playermovementperchance : MonoBehaviour
    {
    CharacterController cc;
     
        void Start()
        {
            cc = GetComponent<CharacterController>();
        }
     
        void Update()
        {
            Vector3 velocity=cc.velocity+(Physics.gravity*Time.deltaTime);  // Get the current "velocity" and add gravity
            if (Physics.SphereCast(transform.position,0.5f,Vector3.down,out RaycastHit hit,0.6f))  // CharacterController's isGrounded can be unreliable when jumping up slopes and so we can use SphereCast instead
            {
                if (Input.GetButtonDown("Jump"))
                    velocity.y+=5;
                else
                {
                    velocity+=((transform.right*Input.GetAxisRaw("Horizontal"))+(transform.forward*Input.GetAxisRaw("Vertical"))).normalized*50*Time.deltaTime;
                    velocity-=velocity*4*Time.deltaTime; // ground friction
                    velocity.y=-6; // helps to keep the character pinned to the ground when going down slopes
                }
            }
            cc.Move(velocity * Time.deltaTime);
        }
    }
     
