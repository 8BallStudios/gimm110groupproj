﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//On moving platforms in main scene
public class WaypointFollower : MonoBehaviour
{
    [SerializeField] private GameObject[] waypoints;
    private int currentWaypointIndex = 0;

    [SerializeField] private float speed = 2f;

    // Update is called once per frame
    private void Update()
    {
        //If there is distance between waypoints then the platform will move between them
        if (Vector2.Distance(waypoints[currentWaypointIndex].transform.position, transform.position) < .001f) 
        {
            currentWaypointIndex++;
            if (currentWaypointIndex >= waypoints.Length) 
            {
                currentWaypointIndex = 0;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, waypoints[currentWaypointIndex].transform.position, Time.deltaTime * speed);
    }
}
