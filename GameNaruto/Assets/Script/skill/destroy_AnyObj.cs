using UnityEngine;
using System.Collections;

public class destroy_AnyObj : MonoBehaviour {

	void Start()
	{
		Destroy(gameObject, 3f);
	}


	public void destroy()
	{
		Destroy(gameObject);
	}
}
