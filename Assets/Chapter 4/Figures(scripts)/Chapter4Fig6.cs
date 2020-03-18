﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter4Fig6 : MonoBehaviour
{
    public GameObject particleSystemCh4F6;
    Vector3 origin;
    particleSystemChapter4Fig6 pSCh4F6;

    // Start is called before the first frame update
    void Start()
    {
        origin = new Vector3(Random.Range(-10f, 10f), 5f, 0f);
        createParticleSystem(origin);

    }

    void createParticleSystem(Vector3 origin)
    {
        particleSystemCh4F6 = Instantiate(particleSystemCh4F6);
        pSCh4F6 = particleSystemCh4F6.GetComponent<particleSystemChapter4Fig6>();
    }

    void Update() {
        Vector3 gravity = new Vector3(0f, -10f, 0f);
        pSCh4F6.applyForce(gravity);
    }
}
