using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{

    private float playerSpeed;
   // public float sprintSpeed = 4f;
    public float walkSpeed = 2f;

    /********CONTROLLER 3*******/
    // public CharacterController characterController;
    // public Transform cam;
    /**************************/


    /********CONTROLLER 1*******/
    // public float mouseSensitivity = 2f;
    //  public float jumpHeight = 3f;
    //private bool isMoving = false;//commented out oct 12 to remove errors
    /**************************/
    private bool isSprinting = false;
    private float yRot;

    private Animator anim;
    public Rigidbody rigidBody;
    public float turnSmoothtime = 0.1f;
    float turnSmoothVel;
    // Use this for initialization
    void Start()
    {

        playerSpeed = walkSpeed;
        anim = GetComponent<Animator>();
        rigidBody = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        /*********************************************************************************************************************/
        //                                                 CONTROLLER 1
        /*********************************************************************************************************************/
        // yRot += Input.GetAxis("Mouse X") * mouseSensitivity;
        // transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, yRot, transform.localEulerAngles.z);

        //isMoving = false; //commented out oct 12 to remove errors

        //if (Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f)
        //{
        //    //transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * playerSpeed);
        //    rigidBody.velocity += transform.right * Input.GetAxisRaw("Horizontal") * playerSpeed;
        //    isMoving = true;
        //}
        //if (Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f)
        //{
        //    //transform.Translate(Vector3.forward * Input.GetAxis("Vertical") * playerSpeed);
        //    rigidBody.velocity += transform.forward * Input.GetAxisRaw("Vertical") * playerSpeed;
        //    isMoving = true;
        //}

        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    transform.Translate(Vector3.up * jumpHeight);
        //}

        //if (Input.GetAxisRaw("Sprint") > 0f)
        //{
        //    playerSpeed = sprintSpeed;
        //    isSprinting = true;
        //}
        //else if (Input.GetAxisRaw("Sprint") < 1f)
        //{
        //    playerSpeed = walkSpeed;
        //    isSprinting = false;
        //}


        /*********************************************************************************************************************/
        //                                              CONTROLLER 2
        /*********************************************************************************************************************/
        if (Input.GetKey("a"))
        {

            rigidBody.AddForce(0, 0, playerSpeed * Time.deltaTime, ForceMode.VelocityChange);//time deltatime for FPS

        }

        if (Input.GetKey("d"))
        {
            rigidBody.AddForce(0, 0, -playerSpeed * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (Input.GetKey("w"))
        {
            rigidBody.AddForce(playerSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("s"))
        {
            rigidBody.AddForce(-playerSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        /*******************************************************************************************************************/
        //                          CONTROLLER 3
        /*******************************************************************************************************************/
        //float horizontal = Input.GetAxisRaw("Horizontal");
        //float vertical = Input.GetAxisRaw("Vertical");
        //Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;
        //if (direction.magnitude >= 0.1f)
        //{
        //    float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg*cam.eulerAngles.y;
        //    float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVel, turnSmoothtime);
        //    transform.rotation = Quaternion.Euler(0f, angle, 0f);

        //    Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;

        //    characterController.Move(moveDir * playerSpeed * Time.deltaTime);
        //}

        /*********************************************************************************************************************/
        //                                              CONTROLLER 4
        /*********************************************************************************************************************/
        //float moveH = Input.GetAxis("Horizontal");
        //float moveV = Input.GetAxis("Vertical");
        //Vector3 movem = new Vector3(moveH, 0.0f, moveV);
        //rigidBody.AddForce(movem * playerSpeed);


        //**************************************************************//
        //  anim.SetBool("isMoving", isMoving);
        // anim.SetBool("isSprinting", isSprinting);

    }
}
