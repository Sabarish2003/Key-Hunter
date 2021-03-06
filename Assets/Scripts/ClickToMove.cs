﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ClickToMove : MonoBehaviour
{
    public float HeightOffset = 1; // adjustment for Gvr Editor Simulator

    public NavMeshAgent _navMeshAgent;
    private Camera _camera;

    void Start()
    {
        _camera = Camera.main;
    }

    void Update()
    {
        _camera.transform.Translate(new Vector3(0, HeightOffset, 0)); // Gvr Editor Simulator forces us to be at 0, 0, 0, we need to fix that adjustment

        if (Input.GetButton("Fire1"))
        {
            WalkTo();
        }
    }

    private void WalkTo()
    {
        // shoot a raycast from the center of our screen
        Ray ray = _camera.ViewportPointToRay(new Vector3(0.5F, 0.5F, 0));
        RaycastHit hit; // output variable to get what we collided against
        if (Physics.Raycast(ray, out hit))
        {
            // If we hit something, set our nav mesh to go to it
            if (hit.transform != null)
            {
                _navMeshAgent.SetDestination(hit.point);
            }
        }
    }
}