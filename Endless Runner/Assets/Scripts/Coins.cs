using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    public float turnSpeed = 90f;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.GetComponent<Obstacles>() != null)
        {
            Destroy(gameObject);
            return;
        }
        if (other.gameObject.name != "Player")
        {
            return;
            
        }
        Destroy(gameObject);
    }
   private void Start()
    {
        
    }


   private void Update()
    {
        transform.Rotate(0, 0 , turnSpeed * Time.deltaTime);
    }
}
