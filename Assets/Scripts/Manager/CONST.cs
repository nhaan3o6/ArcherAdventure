using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CONST : MonoBehaviour
{
    //key and default value for saving volume
    public const string BGM_VOLUME_KEY = "BGM_VOLUME_KEY";
    public const string SE_VOLUME_KEY = "SE_VOLUME_KEY";
    public const float BGM_VOLUME_DEFAULT = 0.2f;
    public const float SE_VOLUME_DEFAULT = 1f;
    //time it takes for the BGM to fade
    public const float BGM_FADE_SPEED_RATE_HIGH = 0.9f;
    public const float BGM_FADE_SPEED_RATE_LOW = 0.3f;
}
