using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunTrack : MonoBehaviour {

    public Transform sun;
    public Transform marker;
    private Vector3 earthPos;
    private Transform t;

    private float targetSurfaceDist;
	// Use this for initialization
	void Awake () {
        t = sun.transform;
        earthPos = marker.parent.position;
        targetSurfaceDist = (earthPos - marker.position).magnitude;
        Debug.Log("Max distance: " + targetSurfaceDist);
    }
	
	// Update is called once per frame
	void Update () {
        simpleRotate();
        //Vector3 direction = target.right - t.position;

        //Debug.Log("dist: " + targetDist + " " + earthDist);
        //if (targetDist < earthDist)
        //{
           
        //    if (distMag < 0.05f)
        //    {
        //        Debug.Log("max sun " + distMag);
        //    }
          
        //}
        //Vector3 localNormal = target.InverseTransformDirection(Vector3.forward);

        //Vector3 forward = target.right;
        //float angle = Vector3.Angle(targetDir, localNormal);
        //t.LookAt(localNormal);
	}
    void simpleRotate()
    {
        Vector3 targetDir = marker.position - sun.position;
        float targetDist = targetDir.magnitude;
        float earthDist = (earthPos - sun.position).magnitude;

        float markerDelta = earthDist - targetDist;
        float distMag = (targetSurfaceDist - markerDelta)/targetSurfaceDist;

        float angle = 180 * ( distMag);
        if (angle != 0)
        {
            transform.eulerAngles = new Vector3(angle, 0, 0);
        }
       
    }
}
