using UnityEngine;
using System.Collections;

public class DeathAniEvents : MonoBehaviour {

	public GameObject prefab_bongKiem_Death2;
	public GameObject prefab_bongKiem_Death3;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	private void ani_chuanHoaScaleObj(GameObject obj)
	{
		Vector3 tempScale = obj.transform.localScale;
		if(Sa_info.isRight)
		{
			tempScale.x = Mathf.Abs(tempScale.x);
		}
		else
		{
			tempScale.x = -Mathf.Abs(tempScale.x);
		}
		obj.transform.localScale = tempScale;
	}
	
	public void ani_Death2CreateBongKiem()
	{
		ani_chuanHoaScaleObj(prefab_bongKiem_Death2);
		Instantiate(prefab_bongKiem_Death2, transform.position + new Vector3(Sa_info.isRight?0.8f:-0.8f, -0.2f, 0f), Quaternion.identity);
	}

	public void ani_Death3CreateBongKiem()
	{
		ani_chuanHoaScaleObj(prefab_bongKiem_Death3);
		Instantiate(prefab_bongKiem_Death3, transform.position + new Vector3(Sa_info.isRight?0.8f:-0.8f, -0.2f, 0f), Quaternion.identity);
	}
}
