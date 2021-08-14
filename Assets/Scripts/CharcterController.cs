using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CharcterController : MonoBehaviour
{
    int lives = 2;
    public Text liveText;
    public GameObject Enemy;
    public GameObject Player;
    Animator animator;
    public float moveSpeed;
    public float catWalk;
    public CharacterController character;
    Vector3 moveInput;
    public Transform player;
    public Gamemanager gamemanager;
    public float rotationRate = 360;
    ScoreScript score;
    public static CharcterController instance;
    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        score = FindObjectOfType<ScoreScript>();
        liveText.text = "Live:" + lives;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.UpArrow)|| Input.GetKeyDown(KeyCode.DownArrow)|| Input.GetKeyDown(KeyCode.LeftArrow)|| Input.GetKeyDown(KeyCode.RightArrow))
        {
            animator.SetTrigger("Walk");
        }


        character.Move(moveInput);

        Vector3 horMove = transform.right * Input.GetAxis("Horizontal") * moveSpeed;
        Vector3 verMove = transform.forward * Input.GetAxis("Vertical") * moveSpeed;
        moveInput = horMove + verMove;
        moveInput = moveInput * moveSpeed * Time.deltaTime;
        float xAxis = Input.GetAxis("Mouse X");
        transform.rotation = Quaternion.Euler(0, xAxis, 0) * transform.rotation;

    }

    
    public void SetSpeed(float speed)
    {
        catWalk = speed;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {


            lives = lives - 1;
            liveText.text = "Live: " + lives;



            //speed = speed + 5;
            if (lives <= 1)
            {

                Enemy.SetActive(false);
                Player.SetActive(false);
                gamemanager.NGameOver();
            }
            if (lives <= 0)
            {
                gamemanager.GameOver();


            }

        }
        if (other.gameObject.tag == "Level")
        {
            SceneManager.LoadScene(3);
        }
        if (other.gameObject.tag == "Coin")
        {

            Destroy(other.gameObject);
            score.IncrementScore();
        }
    }
}
