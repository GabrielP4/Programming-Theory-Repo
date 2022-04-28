using UnityEngine;

public class BrickGenerator : MonoBehaviour
{
    public GameObject brickPrefab;
    [SerializeField]
    private int lineCount = 5;
    private int perLine = 5;
    const float space = 1.75f;
    // Start is called before the first frame update
    public void GenerateBricks()
    {
        for (int i = 0; i < lineCount; i++)
        {
            for (int j = 0; j < perLine; j++)
            {
                Vector3 position = new Vector3(-3.5f + space * j, 8f + i * -0.75f, 0);
                Instantiate(brickPrefab, position, Quaternion.identity);
            }
        }
        //brickCount = GameObject.FindGameObjectsWithTag("Brick").Length;
    }
}
