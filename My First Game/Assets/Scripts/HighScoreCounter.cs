using UnityEngine;

public class HighScoreCounter : MonoBehaviour
{

    // Start is called before the first frame update
    void Start(){
      PlayerPrefs.GetInt("HighScore",0);
    }

    // Update is called once per frame
    void Update()
    {

    }



    // getter method
    //public int getHighScore() { return highScore; }

    public void UpdateHighScore(int playerScore) {
      if(playerScore > PlayerPrefs.GetInt("HighScore",0)){
        PlayerPrefs.SetInt("HighScore", playerScore);
      }
    }

    public int GetHighScore(){
      return PlayerPrefs.GetInt("HighScore",0);
    }
}
