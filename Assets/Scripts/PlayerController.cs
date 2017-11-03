using UnityEngine;

public class PlayerController : MonoBehaviour
{

	public float speed;

	Rigidbody2D rb2d;

	void Start()
	{
		rb2d = GetComponent<Rigidbody2D>();
	}

	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");
		var movement = new Vector2(moveHorizontal, moveVertical).normalized * speed * Time.deltaTime;
		rb2d.AddForce(movement);
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag("PickUp")) other.gameObject.SetActive(false);
	}

}