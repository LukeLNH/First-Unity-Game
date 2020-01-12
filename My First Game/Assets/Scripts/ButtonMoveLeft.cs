using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class ButtonMoveLeft : MonoBehaviour, IPointerDownHandler, IPointerUpHandler {

public bool buttonPressed = false;
public GameObject player;

void FixedUpdate(){
  if(buttonPressed){
    player.GetComponent<PlayerMovement>().MoveInX(-1);
  }
}

public void OnPointerDown(PointerEventData eventData){
     buttonPressed = true;
}

public void OnPointerUp(PointerEventData eventData){
    buttonPressed = false;
  }

  public void FindPlayer(){
    player = GameObject.FindGameObjectWithTag("Player");
  }

  public void SetPressFalse(){
    buttonPressed = false;
  }
}
