using UnityEngine;
using System.Collections;

public class Portal : MonoBehaviour {

    public GameObject exitPortal;

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    /*void OnTriggerEnter (Collider other) {
        if (other.tag != "Portable") return;
        Vector3 relativePos = other.transform.position - transform.position;
        var clone = (GameObject)Instantiate(other.gameObject);
        clone.transform.position = exitPortal.transform.position + relativePos;
        
    }

    void OnTriggerExit (Collider other) {
        if (other.tag != "Portable") return;

    }*/
}
