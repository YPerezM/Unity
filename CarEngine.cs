﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CarEngine : MonoBehaviour {

    public Transform path;
    public float maxSteerAngle = 45f;
    public WheelCollider wheelFL;
    public WheelCollider wheelFR;
    //public float maxSteerAngle = 40f;

    private List<Transform> nodes;
    private int currentNode = 0;

	// Use this for initialization
	void Start () {
        Transform[] pathTransforms = path.GetComponentsInChildren<Transform>();
        nodes = new List<Transform>();

        for (int i = 0; i < pathTransforms.Length; i++)
        {
            if (pathTransforms[i] != path.transform)
            {
                nodes.Add(pathTransforms[i]);
            }
        }

    }
	
	// Update is called once per frame
	void fixedUpdate () {
        ApplySteer();
	
	}

    private void ApplySteer()
    {
        Vector3 relativeVector = transform.InverseTransformPoint(nodes[currentNode].position);
        float newSteer = (relativeVector.x / relativeVector.magnitude) * maxSteerAngle;
        wheelFL.steerAngle = newSteer;
        wheelFR.steerAngle = newSteer;
        //relativeVector = relativeVector / relativeVector.magnitude;
        //relativeVector /= relativeVector.magnitude;
    }
}
