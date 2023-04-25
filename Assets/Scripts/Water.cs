using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour
{
    public float timeoffset; 
    public float bobspeed;
    public float bobdampening;
    public float startoffset;
    // Update is called once per frame
    void Update()
    {
        float bob = Mathf.Sin((Time.time + timeoffset) * bobspeed) * bobdampening;
        transform.localPosition = new Vector3(transform.localPosition.x, startoffset + bob, transform.localPosition.z);
    }
}
