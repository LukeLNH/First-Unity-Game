using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
  public Transform Player;
  public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
      Player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    public void FindPlayer(){
      Player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
      transform.position = Player.position + offset;
      // transform pos of obj (camera) = tansform pos of Player (cube)
      // if just leave it like that however, camera snaps to be inside the cube
      // -> use a vector3 (we named offset) -> move the camera back accordingly.

    }
}
