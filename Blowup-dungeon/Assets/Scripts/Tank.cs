using UnityEngine;

public class Tank : MonoBehaviour
{
    public Gun gun;
    public Track trackLeft;
    public Track trackRight;
    public Rigidbody2D tankRigidBody;

    public string keyForward;
    public string keyBackward;
    public string keyRight;
    public string keyLeft;
    public bool doIntro;

    bool locked = false;
    float startTime;

    bool moveForwards = false;
    bool moveBackwards = false;
    float moveSpeed = 0f;
    float moveSpeedBack = 0f;
    float moveAcceleration = 0.1f;
    float moveDeceleration = 0.20f;
    float moveSpeedMax = 2.5f;

    bool rotateRight = false;
    bool rotateLeft = false;
    float rotateSpeedRight = 0f;
    float rotateSpeedLeft = 0f;
    float rotateAcceleration = 4f;
    float rotateDeceleration = 10f;
    float rotateSpeedMax = 130f;

    public int health = 100;
    public int maxHealth = 100;


    void Start()
    {
        if (doIntro)
        {
            locked = true;
            startTime = Time.time;
        }
    }
            

    // Update is called once per frame
    void Update()
    {
        if (!locked)
        {
            // Left
            rotateLeft = (Input.GetKeyDown(keyLeft)) ? true : rotateLeft;
            rotateLeft = (Input.GetKeyUp(keyLeft)) ? false : rotateLeft;

            if (rotateLeft) rotateSpeedLeft = (rotateSpeedLeft < rotateSpeedMax) ? rotateSpeedLeft + rotateAcceleration : rotateSpeedMax;
            else rotateSpeedLeft = (rotateSpeedLeft > 0) ? rotateSpeedLeft - rotateDeceleration : 0;

            transform.Rotate(0f, 0f, rotateSpeedLeft * Time.deltaTime);

            // Right
            rotateRight = (Input.GetKeyDown(keyRight)) ? true : rotateRight;
            rotateRight = (Input.GetKeyUp(keyRight)) ? false : rotateRight;

            if (rotateRight) rotateSpeedRight = (rotateSpeedRight < rotateSpeedMax) ? rotateSpeedRight + rotateAcceleration : rotateSpeedMax;
            else rotateSpeedRight = (rotateSpeedRight > 0) ? rotateSpeedRight - rotateDeceleration : 0;

            transform.Rotate(0f, 0f, rotateSpeedRight * Time.deltaTime * -1);

            // Forward
            moveForwards = (Input.GetKeyDown(keyForward)) ? true : moveForwards;
            moveForwards = (Input.GetKeyUp(keyForward)) ? false : moveForwards;

            if (moveForwards) moveSpeed = (moveSpeed < moveSpeedMax) ? moveSpeed + moveAcceleration : moveSpeedMax;
            else moveSpeed = (moveSpeed > 0) ? moveSpeed - moveDeceleration : 0;

            transform.Translate(0f, moveSpeed * Time.deltaTime, 0f);

            // Backward
            moveBackwards = (Input.GetKeyDown(keyBackward)) ? true : moveBackwards;
            moveBackwards = (Input.GetKeyUp(keyBackward)) ? false : moveBackwards;

            if (moveBackwards) moveSpeedBack = (moveSpeedBack < moveSpeedMax) ? moveSpeedBack + moveAcceleration : moveSpeedMax;
            else moveSpeedBack = (moveSpeedBack > 0) ? moveSpeedBack - moveDeceleration : 0;

            transform.Translate(0f, moveSpeedBack * Time.deltaTime * -1f, 0f);

            if (rotateLeft || rotateRight || moveBackwards || moveForwards) trackStart();
            else trackStop();
        }
        else
        {
            trackStart();
            moveTankLeft();
        }
    }

    void trackStart()
    {
        trackLeft.animator.SetBool("isMoving", true);
        trackRight.animator.SetBool("isMoving", true);
    } 
    
    void trackStop()
    {
        trackLeft.animator.SetBool("isMoving", false);
        trackRight.animator.SetBool("isMoving", false);
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        gun.GetComponent<Rigidbody2D>().SendMessage("OnCollisionStay2D", collision);
    }

    private void moveTankLeft()
    {
        if (startTime + 3 > Time.time)
        {
            transform.Translate(0f, 0.012f, 0f);
        }
        else
        {
            locked = false;
            trackStop();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        

        if (collision.gameObject.tag == "QuestGiver")
        {
            Debug.Log("ce");
            collision.gameObject.GetComponent<QuestGiver>().OpenQuestWindow();
        }
    }
}