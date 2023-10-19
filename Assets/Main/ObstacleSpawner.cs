using System.Collections;
using TMPro;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstacle;

    public float obstacleSpeed;
    public float inSky;
    public float inFloor;

    public float waitingTime=5f;
    public float minWaitingTime=0.1f;
    public float timeToLevelUp = 5;

    private int level = 1;

    public TextMeshProUGUI pointsText;

    private float startTime; 
   
    void Start()
    {
        startTime = Time.time;
        StartCoroutine(SpawnObstacle());
    }

    void Update() {
        pointsText.text = "Points: " + Mathf.Round(100 * (Time.time - startTime)).ToString() + "     Level: " + level;
        if (Time.time - startTime > level * timeToLevelUp) {
            level +=1;
        }
    }

    // Update is called once per frame
    private IEnumerator SpawnObstacle(){
        while(true){
            Vector3 pos = new Vector3(transform.position.x,Random.Range(inFloor,inSky),transform.position.z);
            GameObject instance = Instantiate(obstacle,pos,Quaternion.identity);
            instance.GetComponent<MoveObstacle>().speed = obstacleSpeed * (1 + Mathf.Log(level));
            yield return new WaitForSeconds(waitingTime * Mathf.Max(minWaitingTime, 1 - (level * 0.1f)));
        }
    }
}
