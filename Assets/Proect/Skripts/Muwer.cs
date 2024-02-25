using UnityEngine;
using System.Collections;

public class Muwer : MonoBehaviour {
    public Vector3 muvePlatform { get; set; }
    public Vector3 muve { get; set; }
    public Vector2 rute { get; set; }
    public float sensitivity = 1.1f;
	public Transform cam;
	public float minimumY = -60F;
	public float maximumY = 60F;
	public float speed = 6.0F;
	public float gravity = 20.0F;
    public Animator anim;
	private Vector3 moveDirection = Vector3.zero;
	float rotationY = 0F;
	public CharacterController controller { get; set; }
	public static Muwer rid {get; set;}
    private Vector3 pos;
	void Awake(){
		if (rid == null) {
			rid = this;
		} else {
			Destroy (this);
		}
	}
	void OnDestroy(){
		rid = null;
	}

	void Start () {
		controller = GetComponent<CharacterController>();
        pos = transform.position;
	}
    public void Restarter()
    {
        transform.position = pos;
    }
	void Update() {
		if (controller.enabled) {
			if (cam != null) {
				if (Time.timeScale > 0) {
					float rotationX = transform.localEulerAngles.y + rute.x * sensitivity;
					rotationY += rute.y * sensitivity;
					rotationY = Mathf.Clamp (rotationY, minimumY, maximumY);

					cam.transform.localEulerAngles = new Vector3 (-rotationY, 0, 0);
					transform.localEulerAngles = new Vector3 (0, rotationX, 0);
				}
			}

			if (controller.isGrounded) {
				moveDirection = muve+muvePlatform;
				moveDirection = transform.TransformDirection (moveDirection);
				moveDirection *= speed;
                if (controller.velocity.magnitude > 0.1f)
                {
                    anim.SetBool("Run", true);
                    anim.SetFloat("Speed", controller.velocity.magnitude);
                }
                else
                {
                    anim.SetBool("Run", false);
                }
			} else {
				moveDirection.y -= gravity * Time.deltaTime;
			}

			controller.Move (moveDirection * Time.deltaTime);
		} 
	}
}
