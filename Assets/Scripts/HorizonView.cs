using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizonView : MonoBehaviour {

    public GameObject Sun;
    public GameObject SurfacePoint;
   
	// Use this for initialization
	void Start () {
		if (Sun == null)
        {
            Sun = GameObject.Find("Sun");
        }
	}
	
	// track the surface point
	void Update () {
        Debug.DrawLine(SurfacePoint.transform.position, Sun.transform.position);
        transform.LookAt(SurfacePoint.transform);
        transform.eulerAngles = new Vector3(-33, transform.rotation.y, 0);
	}

}
