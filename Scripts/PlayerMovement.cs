using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public Vector3 jump;
    public float numOfJumps;

    public float jumpForce = 2.0f;
    public float sidewaysForce;
    public float speed;

    public bool isGrounded = true;
    public bool jumpPill = false;
    public float amountOfJumps = 0;

    public float jumpsMade;

    public bool respawn;

    public void MoveForward()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }

    public void MoveBackward()
    {
        transform.Translate(-1 * Vector3.forward * Time.deltaTime * speed);
    }

    public void MoveLeft()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
    }

    public void MoveRight()
    {
        transform.Translate(Vector3.right * Time.deltaTime * speed);
    }

    public void MoveUp()
    {
        if (isGrounded && jumpPill)
        {
            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
            isGrounded = false;
            jumpPill = false;
            --amountOfJumps;
            ++jumpsMade;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        jumpsMade = 0;
        jumpPill = false;
    }

    void OnCollisionStay()
    {
        isGrounded = true;
    }

    void Update()
    {
        Respawn();
    }

    public void Respawn()
    {
        if (this.transform.position.y < -10)
        {
            this.transform.position = new Vector3(30, 2, 0);
        }
    }
}
