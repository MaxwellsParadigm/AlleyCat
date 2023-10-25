using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class Kot : MonoBehaviour{
    public float moveSpeed = 5f;      // Character movement speed
    public float jumpForce = 10f;    // Jump force
    private bool isGrounded;         // Check if the character is on the ground
    private Rigidbody2D rb;
    bool leg = false;
    public SpriteRenderer spriteRenderer;
    [SerializeField] private Sprite sprite1;
    [SerializeField] private Sprite sprite2;
    [SerializeField] private Sprite sprite3;
    [SerializeField] private Sprite sprite4;

    private void Awake()
    {      
        Debug.Log("Start");
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float moveDirection = 0;

        if (Input.GetKey("a"))
        {
            moveDirection = -1;
        }
        if (Input.GetKey("d"))
        {
            moveDirection = 1;
        }

        Vector2 move = new Vector2(moveDirection * moveSpeed, rb.velocity.y);
        rb.velocity = move;

        if (rb.velocity.y == 0 && Input.GetKeyDown("w"))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode2D.Impulse);
        }



        int temp = Random.Range(0, 40);
        if (temp == 1) {
            leg = !leg;
        }

        if (move[0] > 0 && leg == false) {
            spriteRenderer.sprite = sprite1;
        }
        else if (move[0] > 0 && leg == true) {
            spriteRenderer.sprite = sprite2;
        }
        else if (move[0] < 0 && leg == false) {
            spriteRenderer.sprite = sprite3;
        }
        else if (move[0] < 0 && leg == true) {
            spriteRenderer.sprite = sprite4;
        }
    }

}