using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketControl : MonoBehaviour
{
    public float speed = 500f;

    private enum eSwipeStatus
    {
        SWIPE_IDLE,
        SWIPE_LEFT,
        SWIPE_RIGHT,
    };

    private eSwipeStatus swipeStatus = eSwipeStatus.SWIPE_IDLE;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Swipe_Update();
        Swipe_Control();
    }

    private void Swipe_Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            swipeStatus = eSwipeStatus.SWIPE_LEFT;
        }

        else if (Input.GetButtonUp("Fire1"))
        {
            swipeStatus = eSwipeStatus.SWIPE_IDLE;
        }
        else if (Input.GetButtonDown("Fire2"))
        {
            swipeStatus = eSwipeStatus.SWIPE_RIGHT;
        }

        else if (Input.GetButtonUp("Fire2"))
        {
            swipeStatus = eSwipeStatus.SWIPE_IDLE;
        }

    }

    private void Swipe_Control()
    {
        if (swipeStatus == eSwipeStatus.SWIPE_IDLE)
            this.transform.localRotation = Quaternion.RotateTowards(this.transform.localRotation, Quaternion.Euler(new Vector3(28f, -45f, -16f)), Time.deltaTime * speed);
        
        else if (swipeStatus == eSwipeStatus.SWIPE_LEFT)
            this.transform.localRotation = Quaternion.RotateTowards(this.transform.localRotation, Quaternion.Euler(new Vector3(28f, -120f, -16f)), Time.deltaTime * speed);
        
        else if (swipeStatus == eSwipeStatus.SWIPE_RIGHT)
            this.transform.localRotation = Quaternion.RotateTowards(this.transform.localRotation, Quaternion.Euler(new Vector3(28f, 30f, -16f)), Time.deltaTime * speed);
    }

}
