using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Required when Using UI elements.

public class SliderControlScrip : MonoBehaviour
{
    [SerializeField] private Slider lunchForceSlier;
    [SerializeField] private PingPongGameProjectConfigScrip configScrip;

    [SerializeField] private Text lunchForceHintText;
    // Start is called before the first frame update
    void Start()
    {
        //Adds a listener to the main slider and invokes a method when the value changes.
        lunchForceSlier.onValueChanged.AddListener(delegate {ValueChangeCheck(); });
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Invoked when the value of the slider changes.
    private void ValueChangeCheck()
    {
        float value = (int)(lunchForceSlier.value * 100f);

        Debug.Log(value);
        lunchForceHintText.text =  "Lunch Force: " + value.ToString();
        configScrip.SetLuncherForce(value);
    }
}
