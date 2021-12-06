using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PingPongGameProjectConfigScrip : MonoBehaviour
{
    [SerializeField] private float lunchForce = 5;
    [SerializeField] private float hitForce = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetLuncherForce(float _lunchForce)
    {
        lunchForce = _lunchForce;
    }

    public float GetLuncherForce()
    {
        return lunchForce;
    }

    public void SetHitForce(float _hitForce)
    {
        hitForce = _hitForce;
    }

    public float GetHitForce()
    {
        return hitForce;
    }
}
