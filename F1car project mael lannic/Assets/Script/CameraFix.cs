using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFix : MonoBehaviour
{

    public GameObject cameratarget;
    
    // Update is called once per frame
    void Update()
    {
      transform.position = new Vector3(cameratarget.transform.position.x,cameratarget.transform.position.y,-20);  
    }
}
