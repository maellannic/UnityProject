using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{

    public float speed;
    public float acceleration;
    public float deccelaration;
    public int laps = -1;
    public float MaxSpeed;
    public int CoefRotation;
    private AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate() {
        if (0 < Input.GetAxis("Vertical"))
        {
             speed = Mathf.Min(MaxSpeed, speed + acceleration*Input.GetAxis("Vertical")*Time.fixedDeltaTime);
        }
        else
        {
            speed = Mathf.Max(0, speed - deccelaration*(1 - Input.GetAxis("Vertical"))*Time.fixedDeltaTime);
        }
        transform.Translate(Vector2.up * speed);
        transform.Rotate(0,0,-Input.GetAxis("Horizontal") * CoefRotation * Time.deltaTime);
        audio.pitch = Input.GetAxis("Vertical") + 1.5f;
    }
}
