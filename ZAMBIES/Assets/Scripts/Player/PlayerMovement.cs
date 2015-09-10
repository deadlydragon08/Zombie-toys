using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	Public float speed = 6f;

	Vector3 movement;
	Animator anim;
	Rigidbody playerRigidbody;
	int floorMask;
	float camRayLength = 100f

		void Awake()
	{
		floorMask = LayerMask.GetMask ("Floor");
		Animator = GetComponent <Animator> ();
		PlayerRigidbody = GetComponent<Rigidbody> ();
	}

	void FixedUpdate()
	{
		float h = Input.GetAxisRaw("Horizontal");
		float v = Input.GetAxisRaw ("Vertical");

	}
	void Move (float h, float v)

	{
		 movment.Set (h,0f, v);
		 movement = movement.normalized * speed * Time.deltaTime;

		 playerRigidbody.MovePosition (transform.position + movement);
		 }

		 void Turning()
		 {
		Ray CamRay = Camera.main.ScreenPointToRay(Input.mousePosition);

		RaycastHit floorHit;

		if(Physics.Raycast (camRay, out floorHit
}
