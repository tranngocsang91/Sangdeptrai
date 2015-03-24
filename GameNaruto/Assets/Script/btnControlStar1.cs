using UnityEngine;
using System.Collections;

public class btnControlStar1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	private void loadlevel()
	{
		Application.Quit();
	}
	private void LoadMap()
	{
		Application.LoadLevel ("Star3");
	}
	public void press_btnExit()
	{
		loadlevel ();
	}
	public void press_btn1()
	{
		LoadMap ();
	}
	public void press_btn2()
	{
		LoadMap ();
	}
}
