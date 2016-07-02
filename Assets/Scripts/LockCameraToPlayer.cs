using UnityEngine;
using System.Collections;

public class LockCameraToPlayer : MonoBehaviour {

	public Transform LockTarget;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position = new Vector3 (LockTarget.position.x, this.transform.position.y, this.transform.position.z);
	}
}
