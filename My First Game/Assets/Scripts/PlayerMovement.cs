using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float HorizontalForce = 500f;
    // Start is called before the first frame update
    void Start()
    {

      rb = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate() //FixedUpdate for physics stuff cuz we are adding force :)
    {
      //rb.AddForce(0, 0, ForwardForce * Time.deltaTime, ForceMode.VelocityChange); //add this so that frame rate is not an issue

      if (Input.GetKey("d")){
        MoveInX(1);
      }

      if (Input.GetKey("a")){
        MoveInX(-1);
      }

    }

    public void MoveInX(int n){ //@param can only be 1 or -1
      rb.AddForce(n * HorizontalForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }
}
