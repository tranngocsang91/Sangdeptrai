using UnityEngine;
using System.Collections;

public class btnControlStar5 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	private void loadlevel()
	{
		Application.LoadLevel ("Star3");
	}
	public void press_btnBack()
	{
		loadlevel ();
	}
}
