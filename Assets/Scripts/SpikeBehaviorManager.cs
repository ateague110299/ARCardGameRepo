using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeBehaviorManager : MonoBehaviour
{
    public Transform startPoint;
    public Transform endPoint;
    public Transform spikes;
    public float shiftSpeed;
    public bool direction;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (spikes.position.y < endPoint.position.y)
        {
            direction = true;
        }

        if (spikes.position.y > startPoint.position.y)
        {
            direction = false;
        }

        if (direction == true)
        {
            spikes.localPosition += new Vector3(0, shiftSpeed, 0);
        }

        else
        {
            spikes.localPosition -= new Vector3(0, shiftSpeed, 0);
        }
    }
}
