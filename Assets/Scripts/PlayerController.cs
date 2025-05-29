using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    public float turnSpeed = 100f;

    private void Update()
    {
        Move();
        Turn();
    }

    private void Move()
    {
        float moveInput = Input.GetAxis("Vertical");
        Vector3 move = transform.forward * moveInput * speed * Time.deltaTime;
        transform.position += move;
    }

    private void Turn()
    {
        float turnInput = Input.GetAxis("Horizontal");
        float turn = turnInput * turnSpeed * Time.deltaTime;
        transform.Rotate(0, turn, 0);
    }
}