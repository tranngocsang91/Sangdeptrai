using UnityEngine;
using System.Collections;

public class btnControlStar3 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	private void loadlevel()
	{
		Application.LoadLevel ("Star2");
	}
	private void loadlevel1()
	{
		Application.LoadLevel ("Star4");
	}
	private void loadlevel2()
	{
		Application.LoadLevel ("Star5");
	}
	private void loadlevel3()
	{
		Application.LoadLevel ("Star6");
	}

	public void press_btnBack()
	{
		loadlevel ();
	}
	public void press_btnTT()
	{
		loadlevel1 ();
	}
	public void press_btnSkill()
	{
		loadlevel2 ();
	}
	public void press_btnKiem()
	{
		loadlevel3 ();
	}
}
