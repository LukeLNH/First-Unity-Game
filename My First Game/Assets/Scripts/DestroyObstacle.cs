using UnityEngine;

public class DestroyObstacle : MonoBehaviour
{

    public GameObject player;
    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
      player = GameObject.FindGameObjectWithTag("Player");
      gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
//      Debug.Log(score);
        if(gameManager.hasEnded){
          Destroy(gameObject);
        }else if (transform.position.z < player.transform.position.z){
          player.GetComponent<PlayerScore>().IncrementScore();
          Destroy(gameObject);
        }
    }
}
