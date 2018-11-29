using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fancyParent : MonoBehaviour {

    public Transform parent;

    private Vector3 myStart_pos;
    private Vector3 myStart_rot;
    private Vector3 theirStart_pos;
    private Vector3 theirStart_rot;

    // Use this for initialization
    void Start () {
        myStart_rot = this.transform.eulerAngles;
        myStart_pos = this.transform.position;
        theirStart_pos = parent.position;
        theirStart_rot = parent.eulerAngles;
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.position = myStart_pos + (parent.transform.position - theirStart_pos);
        this.transform.eulerAngles = myStart_rot + (parent.transform.eulerAngles - theirStart_rot);
	}
}
