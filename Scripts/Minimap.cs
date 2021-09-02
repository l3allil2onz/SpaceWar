using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minimap : MonoBehaviour
{
    public GameObject target;
    Vector3 pos;

    private void Start()
    {
        if(target == null)
        {
            target = GameObject.Find("Player");
        }
    }
    void Update()
    {
        if (target != null)
        {
            pos = target.transform.position;
            transform.localPosition = new Vector3(pos.x, pos.y, -10);
        }
    }
}
