using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField]
    float steerSpeed=100.50f;
    [SerializeField]
    float movement = 10f;
    [SerializeField]
    float boostSpeed = 30f;
    [SerializeField]
    float slowSpeed =2f;
  
      void Update()
{
        float steeramount=Input.GetAxis("Horizontal")*steerSpeed*Time.deltaTime;
        float moveAmount=Input.GetAxis("Vertical")*movement*Time.deltaTime;
        transform.Translate(0,moveAmount,0);
        transform.Rotate(0,0,-steeramount);
}
void  OnTriggerEnter2D(Collider2D other) 
{
    if(other.tag == "SpeedUp")
    {
        movement = boostSpeed;
    }
}


void  OnCollisionEnter2D(Collision2D other)
{
        movement = slowSpeed; 
}

}
