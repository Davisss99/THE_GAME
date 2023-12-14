using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{   
    private Timer timer ;
    public float moveSpeed = 5f;
    public float highMoveSpeed = 10f;
    public float highSpeedSeconds = 0f;
    public Rigidbody2D rb;
    private Vector2 moveDirection;
    public string nextScene;

    public int remainingDuration;

     // Impostazione della durata del timer a 35 secondi
     void Start()
     {
         timer = GetComponent<Timer>();
         timer.SetDuration(remainingDuration).Begin();    
     }
   

    // Update is called once per frame
    void Update()
    {
        if (highSpeedSeconds > 0.0f) {
            highSpeedSeconds -= Time.deltaTime;
        }
        ProcessInputs();
        if (timer.remainingDuration <= 0){
            SceneManager.LoadScene(nextScene); 
        }
    }

    // FixedUpdate is called once per physics update
    void FixedUpdate()
    {
        Move();
    }

    void ProcessInputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        moveDirection = new Vector2(moveX, moveY).normalized;
    }

    void Move()
    {   
        float speed = moveSpeed;
        if (highSpeedSeconds > 0.0f)
        {
            speed = highMoveSpeed;
        }
        rb.velocity = new Vector2(moveDirection.x * speed, moveDirection.y * speed);
    }
}
