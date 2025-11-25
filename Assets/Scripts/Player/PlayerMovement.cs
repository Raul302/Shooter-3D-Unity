using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController character;

    public float speed = 10f;

    private float gravity = -9.81f;

    public Transform ground_check;
    public float sphereRadius = 0.3f;
    public LayerMask ground_mask;

    bool is_grounded;


    public float jump_height = 2;




    Vector3 velocity;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {

        is_grounded = Physics.CheckSphere(ground_check.position, sphereRadius, ground_mask);



        if (is_grounded && velocity.y < 0) 
        {
            velocity.y = -2f;

        }


        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        

        Vector3 move = transform.right * x + transform.forward * z;

        if (Input.GetKeyDown(KeyCode.Space) && is_grounded)
        {

            velocity.y = Mathf.Sqrt(jump_height * -2 * gravity);

        }



        character.Move(move * speed * Time.deltaTime);
        
        velocity.y += gravity*Time.deltaTime;

        character.Move(velocity * Time.deltaTime);


    }
}
