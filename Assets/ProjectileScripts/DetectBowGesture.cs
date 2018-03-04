using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectBowGesture : MonoBehaviour {

    public GameObject LeftHandThumb;
    public GameObject RightHandThumb;
    public GameObject projectile;

    private bool leftHandInPosition = false;
    private bool rightHandInPosition = false;
    private bool startedGesture = false;

    private GameObject currentProjectile;
    
    public void SetRightHandState(bool state)
    {
        rightHandInPosition = state;
    }

    public void SetLeftHandState(bool state)
    {
        leftHandInPosition = state;
    }

    void FixedUpdate()
    {
        if(!startedGesture && leftHandInPosition && rightHandInPosition)
        {
            //Check proximity of hands
            if(Vector3.Distance(LeftHandThumb.transform.position, RightHandThumb.transform.position) < 5.0F)
            {
                startedGesture = true;
                print("Starting bow gesture");
                currentProjectile = Instantiate(projectile, this.transform.position, Quaternion.identity);
            }
        }

        if (startedGesture)
        {
            if(leftHandInPosition && rightHandInPosition)
            {
                currentProjectile.transform.position = LeftHandThumb.transform.position;
            }
            else
            {
                startedGesture = false;
                Destroy(currentProjectile);
            }
        }
    }
}
