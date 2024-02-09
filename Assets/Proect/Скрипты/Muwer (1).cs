using UnityEngine;
using System.Collections;

public class Muwer : MonoBehaviour 

{
	public float jumpSpeed = 10.0f;
	public bool grunded;
	public LayerMask mask;
	public float radius = 0.5f;
	public Vector3 muve;
	public float sensitivity = 1.1f;
	public Transform cam;
	public float minimumY = -60F;
	public float maximumY = 60F;
	public float speed = 6.0F;
	public float gravity = 20.0F;

	private Vector3 moveDirection = Vector3.zero;
	float rotationY = 0F;
	private CharacterController controller;
	public static Muwer rid {get; set;}
	

	void Awake()

	{
		if (rid == null) 
		{
			rid = this;
		} 
		else 
		{
			Destroy (this);
		}
	}

	void OnDestroy()

	{
		rid = null;
	}

	void Start() 

	{
		controller = GetComponent<CharacterController>();
	}

	void Update() 

	{
		Collider[] serch = Physics.OverlapSphere(transform.position + new Vector3(-1,-1,-1) , radius , mask);	
		if(serch.Length > 0)
		{
			grunded = true;
		}
		else
		{
			grunded = false;
		}
		if(Input.GetKeyDown(KeyCode.Space))
		{
			Jumper();
		}
        transform.parent = null;
        if (cam != null)
        {
            if (Time.timeScale > 0)
            {
                float rotationX = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * sensitivity;
                rotationY += Input.GetAxis("Mouse Y") * sensitivity;
                rotationY = Mathf.Clamp(rotationY, minimumY, maximumY);

                cam.transform.localEulerAngles = new Vector3(-rotationY, 0, 0);
                transform.localEulerAngles = new Vector3(0, rotationX, 0);
            }
        }

        if (grunded)
        {
            //moveDirection = new Vector3 (Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical"));
            moveDirection = muve;
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;

        }
        else
        {
            moveDirection.y -= gravity * Time.deltaTime;
        }

        controller.Move(moveDirection * Time.deltaTime);
    }

	void Jumper()

	{
		if(grunded)
		{
			muve.y = jumpSpeed;
		}
	}

    void OnDrawGizmos()

    {
		Gizmos.color = Color.red;
		Gizmos.DrawSphere(transform.position, radius);
    }

}
