using UnityEngine;

public class ObstacleSpawning : MonoBehaviour
{
    public GameObject player;

    public GameObject obstacle;
    public float amountOfObstacles;

    public float minX, maxX;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");

        for (int i = 0; i < amountOfObstacles; i++)
        {
            float xAxis, yAxis;
            xAxis = Random.Range(minX, maxX);
            yAxis = Random.Range(transform.localPosition.y - 10, transform.localPosition.y -30);

            Vector3 pos = new Vector3(xAxis, yAxis, 0);
            Instantiate(obstacle, pos, Quaternion.identity);
        }
    }
}
