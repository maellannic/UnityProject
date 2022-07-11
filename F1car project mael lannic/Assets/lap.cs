using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lap : MonoBehaviour
{
    public GameObject player;
    public Camera playercamera;
    public Camera maincam;
    public GameObject victoryscreen;
    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "PlayerCar")
        {
            player.GetComponent<Control>().laps += 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (player.GetComponent<Control>().laps == 5)
        {
            playercamera.enabled = false;
            maincam.enabled = true;
            victoryscreen.SetActive(true);

            StartCoroutine(end());

            SceneManager.LoadScene(1);
        }
    }

    IEnumerator end(){
        yield return new WaitForSeconds(.5f);
    }
}
