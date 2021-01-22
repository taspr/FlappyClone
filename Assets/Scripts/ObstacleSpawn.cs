using UnityEngine;

public class ObstacleSpawn : MonoBehaviour
{
    [SerializeField]
    private Transform obstacle;

    private float time = 0;

    // Start is called before the first frame update
    void Start()
    {
        Random.InitState(System.Environment.TickCount);
    }

    // Update is called once per frame
    void Update()
    {
        
        time += Time.deltaTime;

        if (time > 1)
        {
            
            Instantiate(obstacle, new Vector3(12.0f, Random.Range(-1 + Random.Range(-0.2f, 0.2f), 1 + Random.Range(-0.2f, 0.2f)), 0), transform.rotation);
            time = 0;
        }
    }
}