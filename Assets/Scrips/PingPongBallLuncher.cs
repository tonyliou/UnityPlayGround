using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PingPongBallLuncher : MonoBehaviour
{
    public float lunchForce = 5.0f;
    private Rigidbody m_rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        m_rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        m_rigidbody.AddForce(Vector3.forward * lunchForce * -1);
    }
}
