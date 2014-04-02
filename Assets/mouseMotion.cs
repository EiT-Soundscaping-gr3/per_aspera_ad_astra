using UnityEngine;
using System.Collections;

public class mouseMotion : MonoBehaviour {
	//private double sens = 0.05;
	//private Gyroscope gyro;
	private float sensitivity = 2f;
	// Use this for initialization
	void Start () {
		//gyro = Input.gyro; // Store the reference for Gyroscope sensor
		//gyro.enabled = true; //Enable the Gyroscope sensor
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetAxis("Mouse Y") != 0){
			transform.Rotate(-Input.GetAxis("Mouse Y")*sensitivity, 0, 0, Space.Self);

		}
		if(Input.GetAxis("Mouse X") != 0){
			transform.Rotate(0, Input.GetAxis("Mouse X")*sensitivity, 0, Space.World);
			
		}

		/*if(gyro.rotationRateUnbiased.x > sens | gyro.rotationRateUnbiased.x < -sens){
			transform.Rotate(-gyro.rotationRateUnbiased.x, -gyro.rotationRateUnbiased.y, gyro.rotationRateUnbiased.z);
		}
		else if(gyro.rotationRateUnbiased.y > sens | gyro.rotationRateUnbiased.y < -sens){
			transform.Rotate(-gyro.rotationRateUnbiased.x, -gyro.rotationRateUnbiased.y, gyro.rotationRateUnbiased.z);
		}
		else if(gyro.rotationRateUnbiased.z > sens | gyro.rotationRateUnbiased.z < -sens){
			transform.Rotate(-gyro.rotationRateUnbiased.x, -gyro.rotationRateUnbiased.y, gyro.rotationRateUnbiased.z);
		}
*/
	}
}
