using UnityEngine;
using System.Collections;

public class FixCamera : MonoBehaviour {

	public GameObject goSasuke;

	private Vector3 tempPos;
	private float minBorderCam; //limitation x = [-3; 3]
	private float minBorderCamLeft;
	private float minBorderCamRight;
	private float tempX;
	// Use this for initialization
	void Start () {
		minBorderCam = ((float)Screen.width)/((float)Screen.height);
		minBorderCamLeft = -3f+minBorderCam;
		minBorderCamRight = 3f-minBorderCam;
		//Debug.Log(minBorderCamLeft + "  " + minBorderCamRight);
	}
	
	// Update is called once per frame
	void LateUpdate () {
		fixPosCam();
	}

	private void fixPosCam()
	{
		tempX = goSasuke.transform.position.x;

		if(tempX >= minBorderCamLeft && tempX <= minBorderCamRight)
		{
			tempPos = transform.position;
			tempPos.x = tempX;
			transform.position = tempPos;
		}
	}
}
