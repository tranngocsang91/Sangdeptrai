using UnityEngine;
using System.Collections;

public class Sa_UIcontrol : MonoBehaviour {

	public static Sa_UIcontrol instance;


	public GameObject panel_Normal_Buttons;
	public GameObject panel_Death_Buttons;

	public GameObject btn_disable_fire;
	public GameObject btn_disable_eye;
	public GameObject btn_disable_death;


	// Use this for initialization
	void Start () {
		instance = this;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void turnOnDeathMode()
	{
		panel_Normal_Buttons.SetActive(false);
		panel_Death_Buttons.SetActive(true);
	}

	public void turnOffDeathMode()
	{
		panel_Death_Buttons.SetActive(false);
		panel_Normal_Buttons.SetActive(true);
	}

	public void turnOnDisableButtonFire()
	{
		btn_disable_fire.SetActive(true);
	}
	public void turnOnDisableButtonEye()
	{
		btn_disable_eye.SetActive(true);
	}
	public void turnOnDisableButtonDeath()
	{
		btn_disable_death.SetActive(true);
	}
}
