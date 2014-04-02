using UnityEngine;
using System.Collections;

public class cameraMotion : MonoBehaviour {
	private Compass compass;
	private int yaw = 0;
	private int dif = 0;
	private int absDif = 0;
	private int oldYaw = 0;
	// Use this for initialization
	void Start () {
		// Enable the compass.
		//Input.location.Start();
		compass = Input.compass;
		compass.enabled = true;
		transform.Rotate(0,45,0);
	}
	
	// Update is called once per frame
	void Update () {
		yaw = (int)compass.trueHeading;
		dif = yaw-oldYaw;
		absDif =  Mathf.Abs(yaw-oldYaw);
		if(absDif > 10){
			//transform.rotation = Quteranion.Euler(0, yaw, 0);
			transform.Rotate(0,dif,0);
			oldYaw = yaw;
		}
	}

	void OnGUI() {
		if (compass != null)
			GUI.Label(new Rect(10, Screen.height / 2 + 100, 500, 100),
			          "heading: " + compass.trueHeading);
	}
}
