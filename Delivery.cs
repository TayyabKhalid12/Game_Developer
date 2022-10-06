using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    // [SerializeField]
    // Sprite hasPackageSprite;
    // [SerializeField]
    // Sprite noPackageSprite;
    [SerializeField]
    Color hasPackageColor = new Color(1,1,1,1);
    [SerializeField]
    Color noPackageColor = new Color(1,1,1,1);
    bool hasPackage = false;
    SpriteRenderer carSR;
    void Start()
{
     carSR = GetComponent<SpriteRenderer>();   
}

  void  OnTriggerEnter2D(Collider2D other) 
{
    if(other.tag == "Package" && hasPackage == false)
{
        hasPackage = true;
        Destroy(other.gameObject,0.1f);
        // carSR.color = hasPackageColor;
        carSR.color=hasPackageColor;
        Debug.Log("Package Collected");
}
    if(other.tag == "Customer" && hasPackage == true)
{
        hasPackage = false;
        carSR.color = noPackageColor;
        Debug.Log("Package Delivered");
}
}   
}
