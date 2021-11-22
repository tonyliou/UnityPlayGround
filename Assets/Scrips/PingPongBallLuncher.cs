using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PingPongBallLuncher : MonoBehaviour
{
    public float lunchForce = 5.0f;
    private Rigidbody m_rigidbody;
    private bool addForceStatus = true;
    // Start is called before the first frame update
    void Start()
    {
        m_rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (true == addForceStatus)
            m_rigidbody.AddForce(Vector3.forward * lunchForce * -1);

        /* 球太低、發球台射出後速度趨近靜止，即刪除球物件 */
        if (addForceStatus == false)
        {
            if ((transform.position.y < 0.1)
            || (m_rigidbody.velocity.magnitude < 0.1))
                Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        /* 碰觸到球桌，球停止加速 */
        if(other.gameObject.CompareTag("PingPongTable"))
        {
            Debug.Log("PingPongTable trigger!");
            addForceStatus = false;
        }
    }
}
