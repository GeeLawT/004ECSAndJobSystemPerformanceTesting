﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LegacyMethod {
    public class Movement : MonoBehaviour
    {
        void Update()
        {
            Vector3 pos = transform.position;
            pos += transform.forward * GameManager.GM.enemySpeed * Time.deltaTime;

            if (pos.z < GameManager.GM.bottomBound)
                pos.z = GameManager.GM.topBound;

            transform.position = pos;
        }
    }
}


