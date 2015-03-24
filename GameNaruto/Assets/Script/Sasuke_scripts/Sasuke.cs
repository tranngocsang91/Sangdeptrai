using UnityEngine;
using System.Collections;

public class Sasuke : MonoBehaviour {
	//class nay chua can su dung, joytick tam thoi da giup Sasuke di chuyen
	public EasyJoystick joytick;
	private Vector3 pos;
	private int orientLR = 1; //1 = Right, -1 = Left
	private int orientTB = 1;
	public float speed = 1f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//transform.Translate(new Vector3(joytick.JoystickValue.x, joytick.JoystickValue.y, transform.position.z));
		if(joytick.JoystickAxis.x != 0 || joytick.JoystickAxis.y != 0)
		{
			getOrient();
			Run();
		}

	}

	void getOrient()
	{
		if(joytick.JoystickAxis.x > 0) orientLR = 1;
		else orientLR = -1;
		if(joytick.JoystickAxis.y > 0) orientTB = 1;
		else orientTB = -1;
	}

	void Run()
	{
		pos = transform.position;
		pos.x += orientLR*speed*Time.deltaTime;
		pos.y += orientTB*speed*Time.deltaTime;
		transform.position = pos;
	}
	
}
