using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PingPongBallGenerator : MonoBehaviour
{
    public GameObject ballLuncherGun;
    public GameObject pingPongBallPrefab;
    public float intervalSec = 1.0f;
    private float delta = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if(this.delta > this.intervalSec)
        {
            this.delta = 0;
            GameObject go = Instantiate(pingPongBallPrefab) as GameObject;

            float px = Random.Range(-1.0f, 1.0f);
            ballLuncherGun.transform.position = new Vector3(px, 3, 4);
            Vector3 ballPosition = ballLuncherGun.transform.position;
            go.transform.position = ballPosition;
        }
    }
}
