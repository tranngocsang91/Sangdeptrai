using UnityEngine;
using System.Collections;

public class Sa_movement : MonoBehaviour {

	public EasyJoystick joytick;
	Animator aniTor;
	//chuan hoa vi tri trong Scene
	private Vector3 tempPos;
	private float minBorderXLeft;
	private float minBorderXRight;
	private float minBorderYUp;
	private float minBorderYDown;

	//di chuyen
	private bool orientJoytickRight = true;
	private bool orientJoytickUp = true; 
	// Use this for initialization
	void Start () {
		aniTor = GetComponent<Animator>();
		getBorderValue();

	}

	private void getBorderValue()
	{
		minBorderXRight = MapInfo.borderX - 0.2f;
		minBorderXLeft = -MapInfo.borderX + 0.2f;
		minBorderYUp = MapInfo.borderY;
		minBorderYDown = -MapInfo.borderY;
	}
	
	// Update is called once per frame
	void Update () {
		//huong va di chuyen khi Joytick duoc cham
		if(joytick.JoystickAxis.x != 0 || joytick.JoystickAxis.y != 0)
		{
			getOrient();
			//doi huong
			setOrient();
			//doi state run
			setAniRun();
		}
		else
		{
			setAniIdle();
		}

		//chuan hoa vi tri
		standardlizePos();


	}

	private void standardlizePos()
	{
		if(transform.position.x < minBorderXLeft)
		{
			standardlizeX(minBorderXLeft);
		}
		if(transform.position.x > minBorderXRight)
		{
			standardlizeX(minBorderXRight);
		}
		if(transform.position.y < minBorderYDown)
		{
			standardlizeY(minBorderYDown);
		}
		if(transform.position.y > minBorderYUp)
		{
			standardlizeY(minBorderYUp);
		}
	}

	private void standardlizeX(float borderX)
	{
		tempPos = transform.position;
		tempPos.x = borderX;
		transform.position = tempPos;
	}

	private void standardlizeY(float borderY)
	{
		tempPos = transform.position;
		tempPos.y = borderY;
		transform.position = tempPos;
	}


	void getOrient()
	{
		if(joytick.JoystickAxis.x > 0) orientJoytickRight = true;
		else orientJoytickRight = false;
		if(joytick.JoystickAxis.y > 0) orientJoytickUp = true;
		else orientJoytickUp = false;
	}
	//dung khi can chuyen huong di chuyen
	private void setOrient()
	{
		if(orientJoytickRight != Sa_info.isRight) //khac huong moi chuyen
		{
			chuyenHuong_doiScale();
			Sa_info.info_changeIsRight();
		}
	}

	//ho tro cho ham changeOrient()
	private void chuyenHuong_doiScale()
	{
		Vector3 tempScale = transform.localScale;
		tempScale.x *= -1;
		transform.localScale = tempScale;
	}

	private void setAniRun()
	{
		if(!Sa_info.isRun)
		{
			Sa_info.isRun = true;
			aniTor.SetInteger("chuyen", 1);

		}
		if(Sa_info.isDeath && !Sa_info.isDeathRun)
			if(Sa_info.go_death != null)
			{
				Sa_info.isDeathRun = true;
				Sa_info.go_death.GetComponent<Death_Actions>().Run();
			}
	}

	private void setAniIdle()
	{
		if(Sa_info.isDeath && Sa_info.isDeathRun)
			if(Sa_info.go_death != null)
			{
				Sa_info.isDeathRun = false;
				Sa_info.go_death.GetComponent<Death_Actions>().StopRun();
			}
		if(Sa_info.isRun)
		{
			Sa_info.isRun = false;
			Sa_info.isDeathRun = false;
			aniTor.SetInteger("chuyen", 0);
		}

	}
}
