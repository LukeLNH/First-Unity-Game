using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool hasEnded = false;

    public GameObject GameOverScreen;
    public GameObject GameStartScreen;
    public GameObject player;
    public ManageScripts scriptManager;
    public GameObject playerPrefab;
    public Text scoreDisplay;
    public GameObject moveRightButton;
    public GameObject moveLeftButton;
    public HighScoreCounter highScoreCounter;
    public Text highScoreDisplay;




    private Vector3 startPos = new Vector3(0f, 0.9f, 0f);

    void Start()
    {

    }

    // Update is called once per frame
    public void StartGame(){
      hasEnded = false;

      // Turning off al the welcome screens
      GameStartScreen.SetActive(false);
      GameOverScreen.SetActive(false);

      // enabling the move buttons
      moveRightButton.SetActive(true);
      moveLeftButton.SetActive(true);

      // make sure the move buttons are not registering anything
      moveRightButton.GetComponent<ButtonMoveRight>().SetPressFalse();
      moveLeftButton.GetComponent<ButtonMoveLeft>().SetPressFalse();

      // instantiating the player and all necessary scripts
      Instantiate(playerPrefab, startPos, Quaternion.identity);
      player = GameObject.FindGameObjectWithTag("Player");
      scriptManager.EnableScripts(true);

    }

    public void EndGame(){
      if(! hasEnded){
        hasEnded = true;

        moveRightButton.SetActive(false);
        moveLeftButton.SetActive(false);

        scoreDisplay.text = player.GetComponent<PlayerScore>().GetScore().ToString();
        GameOverScreen.SetActive(true);
        scriptManager.EnableScripts(false);
        highScoreCounter.UpdateHighScore(player.GetComponent<PlayerScore>().GetScore());
        highScoreDisplay.text = highScoreCounter.GetHighScore().ToString();

        Destroy(player);
      }
    }
}
