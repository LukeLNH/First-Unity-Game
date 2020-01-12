using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

  public Transform player;
  public GameManager gameManager;


  void Start(){
  player = GameObject.FindGameObjectWithTag("Player").transform;
  gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
  }


  void OnCollisionEnter(Collision collisionInfo){ //Unity's specific method for handling collisions
    if(collisionInfo.collider.tag == "Obstacle"){ //get the tag of the object we are hitting, make sure it is an obstacle
      gameManager.EndGame();
      }
    }

    void Update(){
      if(player.position.y < 0.5f){
        gameManager.EndGame();
      }
    }
  }
