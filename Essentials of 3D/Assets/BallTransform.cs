using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTransform : MonoBehaviour
{
    public Vector3 ScaleChange;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale += ScaleChange;
    }
}
