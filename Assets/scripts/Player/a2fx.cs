using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.ImageEffects;

public class a2fx : MonoBehaviour
{
    public VignetteAndChromaticAberration chromatic_Vignette;
    public Twirl twirl;
    public ColorCorrectionCurves curves;
    // Use this for initialization
    void Start()
    {
        chromatic_Vignette = GetComponent<VignetteAndChromaticAberration>();
        twirl = GetComponent<Twirl>();
        curves = GetComponent<ColorCorrectionCurves>();
    }

    // Update is called once per frame
    void Update()
    {
        chromatic_Vignette.chromaticAberration = 10 + Mathf.PingPong(Time.time*10, 26);
        twirl.angle = Mathf.PingPong(Time.time * 3, 5);
        curves.saturation = 0.8f + Mathf.PingPong(Time.time, 1.8f);
    }
}
