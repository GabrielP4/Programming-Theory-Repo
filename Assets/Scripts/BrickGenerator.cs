using UnityEngine;
public class BrickGenerator : MonoBehaviour
{
    public GameObject brickPrefab;
    [SerializeField]
    private int lineCount;
    private int perLine = 5;
    const float space = 1.75f;

    public int numberOfBricks { get; private set; }

    // Start is called before the first frame update
    public int GenerateBricks()
    {
        for (int i = 0; i < lineCount; i++)
        {
            for (int j = 0; j < perLine; j++)
            {
                Vector3 position = new Vector3(-3.5f + space * j, 8f + i * -0.75f, 0);
                Instantiate(brickPrefab, position, Quaternion.identity);
            }
        }
        return numberOfBricks = GameObject.FindGameObjectsWithTag("Brick").Length;
    }

}
