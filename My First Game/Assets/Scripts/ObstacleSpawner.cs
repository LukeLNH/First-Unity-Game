using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
  public Transform[] spawnPoints;
  public GameObject blockPrefab;
  public Vector3 offset;

  private float timeBetweenWaves = 1f;
  private float timeToSpawn = 1f;

    // Start is called before the first frame update
    void spawnObstacles()
    {
      int randomIndex = Random.Range(0, spawnPoints.Length);
      for (int i = 0; i < spawnPoints.Length; i++){
        if(i != randomIndex){
          Instantiate(blockPrefab, spawnPoints[i]. position + offset, Quaternion.identity);
        }
      }
    }

    // Update is called once per frame
    void Update()
    {

      if(timeToSpawn <= 0){
        spawnObstacles();
        timeToSpawn = timeBetweenWaves;
      }else {
        timeToSpawn -= Time.deltaTime;
      }
    }
}
