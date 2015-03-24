using UnityEngine;
using System.Collections;

public class skill_disable_button : MonoBehaviour {

	public UILabel lb_number;
	private int startNu = 4;
	// Use this for initialization
	void Start () {
		lb_number.text = startNu.ToString();
		//Invoke("changeNumber", 1f);
		callIE();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnEnable()
	{
		startNu = 4;
		lb_number.text = startNu.ToString();
		Invoke("changeNumber", 1f);
	}

	void changeNumber()
	{
		startNu--;
		lb_number.text = startNu.ToString();
		if(startNu == 0)
		{
			gameObject.SetActive(false);
		}
		else
		{
			Invoke("changeNumber", 1f);
		}
	}

	void callIE()
	{
		StartCoroutine(changeNumber2());
	}

	IEnumerator changeNumber2()
	{
		yield return new WaitForSeconds(1f);
		startNu--;
		lb_number.text = startNu.ToString();
		if(startNu == 0)
		{
			gameObject.SetActive(false);
		}
		else
		{
			callIE();
		}
	}
}
