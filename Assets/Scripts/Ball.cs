using UnityEngine;

public class Ball : MonoBehaviour
{
    private new Rigidbody2D rigidbody2D;
    private float moveSpeed = 10;

    private void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

   
	private void Update()
    {
        rigidbody2D.velocity = rigidbody2D.velocity.normalized * moveSpeed;
    }

	private void OnTriggerEnter2D(Collider2D other)
	{
		Debug.Log("win");
		GameControl.lives = 5;
		GameControl.level++;

	}

        
}