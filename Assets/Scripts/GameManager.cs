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
    private Rigidbody Ball;

    private void Start()
    {
        brickGenerator.GenerateBricks();
    }
    // Update is called once per frame
    void Update()
    {
        if (!gameStarted)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                restarText.SetActive(false);
                gameStarted = true;
                float randomDirection = Random.Range(-1.0f, 1.0f);
                Vector3 forceDirection = new Vector3(randomDirection, 1, 0);
                forceDirection.Normalize();
                Ball.transform.SetParent(null);
                Ball.AddForce(forceDirection * 5.0f, ForceMode.VelocityChange);
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
}
