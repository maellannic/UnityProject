using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class soloplay : MonoBehaviour
{

    public void update(){
        if(Input.GetKeyDown("escape")){
            Application.Quit();
        }
    }
    public void IArace(){
        SceneManager.LoadScene(2);
    }

    public void hardtrack(){
        SceneManager.LoadScene(3);
    }

    public void mediumtrack(){
        SceneManager.LoadScene(5);
    }

    public void easytrack(){
        SceneManager.LoadScene(4);
    }

    public void easybutnottoeasy(){
        SceneManager.LoadScene(6);
    }

    public void mediumnotmedium(){
        SceneManager.LoadScene(7);
    }

    public void difficulties()
    {
        SceneManager.LoadScene(1);
    }
}
