using UnityEngine;

public class PlayerMovement : MonoBehaviour{
	[SerializeField] private float speed; //[SF] makes it directly editable in unity
	[SerializeField] private float jump;
	private Rigidbody2D body;

	private void Awake(){ //Awake is called when the script is being loaded
		body = GetComponent<Rigidbody2D>(); //Access Rigidbody2D
	}

	private void Update(){ //Called every frame of the game
		body.linearVelocity = new Vector2(Input.GetAxis("Horizontal") * speed, body.linearVelocity.y); //Rigidbody2D oldugu icin Vector2, 3D olsa Vector3 olurdu

		if(Input.GetKeyDown(KeyCode.Space)) //GetKey is a boolean var returns becomes true when the key is pressed
		body.linearVelocity = new Vector2(body.linearVelocity.x, jump);
	}
}
