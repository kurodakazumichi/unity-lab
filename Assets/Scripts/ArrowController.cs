using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0, -0.1f, 0);

        if (transform.position.y < -5.0f) {
            Destroy(this.gameObject);
        }
	}
}
