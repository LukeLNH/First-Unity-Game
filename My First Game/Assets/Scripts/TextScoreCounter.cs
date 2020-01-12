using UnityEngine;
using UnityEngine.UI;

public class TextScoreCounter : MonoBehaviour
{
  //public int score;
  public PlayerScore score;
  public Text scoreText;


  void Start(){
    score = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerScore>();
  }
    // Update is called once per frame

    void Update()
    {
      scoreText.text = score.GetScore().ToString();
    }

    public void FindPlayer(){
      score = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerScore>();
    }
}
