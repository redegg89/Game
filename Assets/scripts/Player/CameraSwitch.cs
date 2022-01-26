using UnityEngine;
using System.Collections;

public class CameraSwitch : MonoBehaviour
{

	public GameObject ControllerCam;
	

	void Start()
	{
		
	}

	void Update()
	{
		if (Input.GetAxis("Mouse X") != 0 || Input.GetAxis("Mouse Y") != 0)
		{
			ControllerCam.SetActive(false);
		}
		if (Input.GetAxis("Joystick X") != 0 || Input.GetAxis("Joystick Y") != 0)
		{
			ControllerCam.SetActive(true);
		}
	}
}