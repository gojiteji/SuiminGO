using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class sun : MonoBehaviour
{

    float minAngle = 0.0F;
    float maxAngle = 90.0F;

    void Start()
	{
    }

	void Update() {
        float angle = Mathf.LerpAngle(minAngle, maxAngle, Time.time);
        transform.eulerAngles = new Vector3(0, angle, 0);
    }
}
