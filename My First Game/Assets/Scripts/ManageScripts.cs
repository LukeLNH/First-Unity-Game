using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageScripts : MonoBehaviour
{
    public FollowPlayer followPlayer;
    public ObstacleSpawner obstacleSpawner;
    public TextScoreCounter textScoreCounter;
    public ButtonMoveRight buttonMoveRight;
    public ButtonMoveLeft buttonMoveLeft;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void EnableScripts(bool b){
      //accepts a boolean to enable all the scripts maybe?
//      playerMovement.enabled = b;
      // turn off the movement script once we hit an object -> cube stops moving
      if(b){
        followPlayer.FindPlayer();
        textScoreCounter.FindPlayer();
        buttonMoveRight.FindPlayer();
        buttonMoveLeft.FindPlayer();
      }


      followPlayer.enabled = b;
      obstacleSpawner.enabled = b;
      textScoreCounter.enabled = b;
      buttonMoveRight.enabled = b;
      buttonMoveLeft.enabled = b;
    }

/*    public void DisableScripts(){
      followPlayer.enabled = b;
      // Stop the camera from following the player after it is hit
      obstacleSpawner.enabled = b;

      textScoreCounter.enabled = b;
    }*/
}
