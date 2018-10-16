using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour {

    float speed = 0;

    Vector3 startPos;
    private AudioSource audioSource;

	// Use this for initialization
	void Start () {
        audioSource = this.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetMouseButtonDown(0)) {
            this.startPos = Input.mousePosition;
        }
        if(Input.GetMouseButtonUp(0)) {
            this.speed = (Input.mousePosition - this.startPos).x;
            this.speed /= 500.0f;


            this.audioSource.Play();
        }



        transform.Translate(this.speed, 0, 0);
        this.speed *= 0.98f;
	}
}
