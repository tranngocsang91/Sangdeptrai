using UnityEngine;
using System.Collections;

public class chuyenAni : MonoBehaviour {

	Animator ani;

	// Use this for initialization
	void Start () {
		ani = GetComponent<Animator> ();

	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void chuyen12()
	{
		ani.SetInteger ("chuyen", 1);
		Debug.Log ("chuyen 1");
	}
	public void chuyen21()
	{
		ani.SetInteger ("chuyen", 2);
		Debug.Log ("chuyen 2");
	}
}
