using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGPatternMovement : MonoBehaviour
{
    [Range(0,5)]
    public float speed;

    void Update()
    {
        transform.Translate(new Vector2(-speed, 0), Space.Self);
    }
}
