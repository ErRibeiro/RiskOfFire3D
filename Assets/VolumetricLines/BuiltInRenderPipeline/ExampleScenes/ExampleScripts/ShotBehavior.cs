using UnityEngine;
using System.Collections;

public class ShotBehavior : MonoBehaviour {

	// Use this for initialization
	PlayerHealth ph;
	
	void Start () {
		Destroy(this.gameObject, 5);
		ph.GetComponent<PlayerHealth>();
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += transform.forward * Time.deltaTime * 20f;
	
	}
	
	
}
