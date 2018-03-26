using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFunction : MonoBehaviour {

    public Transform player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        SetPosition();
		
	}

    void SetPosition()
    {
        transform.position = new Vector3(player.position.x + 5, 
            transform.position.y, transform.position.z);
    }
}
