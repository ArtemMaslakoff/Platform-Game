using System.Collections;
using System.Collections.Generic;
using System.IO.Compression;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Vector3 lastCheckPoint;
    // Start is called before the first frame update
    void Start()
    {
        lastCheckPoint = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("r"))
        {
            transform.position = lastCheckPoint + new Vector3(0,0.2f,0);
        }
    }
}
