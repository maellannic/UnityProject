using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boost : MonoBehaviour
{
    public int BoostValue;
    public GameObject player;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "PlayerCar")
        {
            float val = player.GetComponent<Control>().speed;
            float valmax = player.GetComponent<Control>().MaxSpeed;
            
            player.GetComponent<Control>().MaxSpeed += BoostValue;
            player.GetComponent<Control>().speed += BoostValue;

            StartCoroutine(Boost());

            player.GetComponent<Control>().speed = val;
            player.GetComponent<Control>().MaxSpeed = valmax;
        }
    }


    IEnumerator Boost()
    {
        yield return new WaitForSeconds(1.5f); 
    }
}
