using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool gameStarted = false;
    private bool gameOver = false;
    [SerializeField]
    private BrickGenerator brickGenerator;
    [SerializeField]
    private GameObject restarText;
    [SerializeField]
    private Rigidbody ball;
    private int allbricks;

    public static int score;

    private void Start()
    {
        score = 0;
        brickGenerator.GenerateBricks(); // ABSTRACTION
        allbricks = brickGenerator.numberOfBricks;
    }

    void Update()
    {
        BrickCount();
        if (!gameStarted)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                restarText.SetActive(false);
                gameStarted = true;
                float randomDirection = Random.Range(-1.0f, 1.0f);
                Vector3 forceDirection = new Vector3(randomDirection, 1, 0);
                forceDirection.Normalize();
                ball.transform.SetParent(null);
                ball.AddForce(forceDirection * 5.0f, ForceMode.VelocityChange);
            }
        }
        else if (gameOver)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }

    public void GameOver()
    {
        gameOver = true;
        restarText.SetActive(true);
    }

    public void BrickCount()
    {
        if (allbricks == score)
        {
            GameOver();
            ball.constraints = RigidbodyConstraints.FreezePosition;
        }
    }
}
