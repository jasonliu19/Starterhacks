using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap.Unity.Interaction;

public class GestureHandlerLeft : MonoBehaviour {

    // Use this for initialization
    public GameObject slotObject;
    public GameObject grenade;
    public AnchorGroup group;

	public void CreateGrenade()
    {
        GameObject newGrenade = Instantiate(grenade, slotObject.transform.position, Quaternion.identity);
        newGrenade.GetComponent<AnchorableBehaviour>().anchorGroup = group;
        newGrenade.GetComponent<AnchorableBehaviour>().anchor = slotObject.GetComponent<Anchor>();
        newGrenade.GetComponent<AnchorableBehaviour>().isAttached = true;
    }
}
