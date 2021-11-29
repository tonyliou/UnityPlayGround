using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PingPongBallLuncher : MonoBehaviour
{
    private enum eStatus
    {
        ACCELERATE,
        DIS_ACCELERATE,
        HIT,
        DESTROY,
    }
    eStatus status = eStatus.ACCELERATE;

    public float lunchForce = 5.0f;
    public float hitForce = 5.0f;
    private Rigidbody m_rigidbody;
    private float speed = 0;
    // Start is called before the first frame update
    void Start()
    {
        m_rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        speed = m_rigidbody.velocity.magnitude;

        PingPongBall_Update();
        PingPongBall_Control();
    }

    private void PingPongBall_Update()
    {
        if ((status == eStatus.ACCELERATE)
        || (status == eStatus.HIT))
        {
            if(speed > 100)
                status = eStatus.DESTROY;
        }

        else if (status == eStatus.DIS_ACCELERATE)
        {
            if ((transform.position.y < 0.1)
            || (speed < 0.1))
                status = eStatus.DESTROY;
        }
    }

    private void PingPongBall_Control()
    {
        if (status == eStatus.ACCELERATE)
        {
            m_rigidbody.AddForce(Vector3.forward * lunchForce * -1);
        }

        else if (status == eStatus.HIT)
        {
            Vector3 dir = new Vector3(0, -0, 1);
            m_rigidbody.AddForce(dir * hitForce);
        }

        else if(status == eStatus.DESTROY)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("PingPongTable"))
        {
            Debug.Log("PingPong trigger!");
            status = eStatus.DIS_ACCELERATE;
        }

        else if (other.gameObject.CompareTag("Racket"))
        {
            Debug.Log("Racket trigger!");
            status = eStatus.HIT;
        }
    }
}
