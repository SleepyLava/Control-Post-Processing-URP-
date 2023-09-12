using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class URP_Settings : MonoBehaviour
{
    [SerializeField] Volume volume;

    Tonemapping toneMapping;
    Vignette vignette;
    DepthOfField depthOfField;
    Bloom bloom;
    ShadowsMidtonesHighlights shm;

    // Start is called before the first frame update
    void Start()
    {
        volume.profile.TryGet(out toneMapping);
        volume.profile.TryGet(out vignette);
        volume.profile.TryGet(out depthOfField);
        volume.profile.TryGet(out bloom);
        volume.profile.TryGet(out shm);
    }

    public void VolumeToggle(Toggle v)
    {
        volume.gameObject.SetActive(v.isOn);
    }

    public void ToneMappingToggle(Toggle v)
    {
        toneMapping.active = v.isOn;
    }

    public void VignetteToggle(Toggle v)
    {
        vignette.active = v.isOn;
    }

    public void DepthOfFieldToggle(Toggle v)
    {
        depthOfField.active = v.isOn;
    }

    public void BloomToggle(Toggle v)
    {
        bloom.active = v.isOn;
    }

    public void ShadowsMidtonesHighlightsToggle(Toggle v)
    {
        shm.active = v.isOn;
    }
}
