using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    [SerializeField]
GameObject Car1;
 void LateUpdate() 
{
transform.position=new Vector3(Car1.transform.position.x, Car1.transform.position.y,-7);    
}
}
