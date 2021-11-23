using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            // transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
        }
        else if (Input.GetButtonUp("Fire1"))
        {
            // transform.rotation = Quaternion.Euler(38f, -53f, -30f);
            transform.localRotation = Quaternion.Euler(38f, -53f, -30f);

        }
    }
}
