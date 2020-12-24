using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

[RequireComponent(typeof(PostProcessVolume))]
public class BlurEnabler : MonoBehaviour
{
    private PostProcessVolume _volume;
    private DepthOfField _depthOfField;

    private void Awake()
    {
        _volume = GetComponent<PostProcessVolume>();
        if (_volume.profile.TryGetSettings(out DepthOfField depth))
            _depthOfField = depth;
    }

    public void Activate()
    {
        _depthOfField.active = true;
    }

    public void Deactivate()
    {
        _depthOfField.active = false;
    }
}
