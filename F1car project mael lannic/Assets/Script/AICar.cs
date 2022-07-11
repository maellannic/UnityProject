using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AICar : MonoBehaviour
{

    public Transform[] points;
    public int pts = 0;
    public float speed;


    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "AI pts")
        {
            pts++;
            if (pts == points.Length)
            {
                pts = 0;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        LookAt2D(points[pts],speed);
        transform.position = Vector2.MoveTowards(transform.position,points[pts].position,speed * Time.deltaTime);
    }


    void LookAt2D(Transform target, float speed){
        Vector3 vectortotarget = target.position - transform.position;
        float angle = Mathf.Atan2(vectortotarget.y,vectortotarget.x) * Mathf.Rad2Deg;
        angle -= (float)90;
        Quaternion q = Quaternion.AngleAxis (angle,Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * speed);
    }
}
