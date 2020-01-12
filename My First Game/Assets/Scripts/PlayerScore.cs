using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{
    public int score;
    // Start is called before the first frame update
    void Start()
    {
      score = 0;
    }

/*
    // Update is called once per frame
    void Update()
    {

      //Debug.Log(obstacle.Destroyed());
        if(obstacle.Destroyed()){
          score++;
        }
    }*/

    public void IncrementScore(){
      //Debug.Log(this.score);
      score++;

    }

    public int GetScore(){
      //Debug.Log(this.score);
      return score / 2;
    }

    public void ResetScore(){
      score = 0;
    }
}
