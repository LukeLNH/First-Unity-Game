using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
  public Rigidbody rb;
  public float speed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
      rb.AddForce(0, 0, -speed * Time.deltaTime, ForceMode.VelocityChange);
    }
}
