using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackLocation : MonoBehaviour

{
    public Vector3 ChangePosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += ChangePosition;
    }
}
