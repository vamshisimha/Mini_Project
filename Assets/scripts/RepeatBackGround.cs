﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackGround : MonoBehaviour
{
    private Vector3 StartPos;
    float repeatWidth;
    // Start is called before the first frame update
    void Start()
    {
        StartPos = transform.position;
        repeatWidth = GetComponent<BoxCollider>().size.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < StartPos.x - repeatWidth)
        {
            transform.position = StartPos;
        }
    }
}
