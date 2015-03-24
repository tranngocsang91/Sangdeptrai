using UnityEngine;
using System.Collections;

public class ani_events : MonoBehaviour {

	public GameObject prefab_Lua_Thuong;
	public GameObject prefab_Lua_Rong;
	// Use this for initialization
	void Start () {
		createPrefabStartgame();
	}

	public void createPrefabStartgame()
	{
		Instantiate(prefab_Lua_Thuong, transform.position+ new Vector3(0f, 3f, 30f), Quaternion.identity);
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

	public void aniTaoPhunLua()
	{
		if(Sa_info.curSelectedFire <= 1)
		{
			ani_chuanHoaScaleObj(prefab_Lua_Thuong);
			Instantiate(prefab_Lua_Thuong, transform.position + new Vector3(Sa_info.isRight?0.2f:-0.2f, 0f, 0f), Quaternion.identity);
		}
		else
		{
			ani_chuanHoaScaleObj(prefab_Lua_Rong);
			Instantiate(prefab_Lua_Rong, transform.position + new Vector3(Sa_info.isRight?0.5f:-0.5f, 0f, 0f), Quaternion.identity);
		}

	}

	public void ani_event_DoiKiem()
	{
		if(Sa_info.curKiem == 0 || Sa_info.curKiem == 1)
			Sa_info.curKiem++;
		else
			Sa_info.curKiem = 0;
		
		Sa_doiKiem.instance.setKiem();
	}

	public void ani_event_disable_btn_Fire()
	{
		Sa_UIcontrol.instance.turnOnDisableButtonFire();
	}
	public void ani_event_disable_btn_Eye()
	{
		Sa_UIcontrol.instance.turnOnDisableButtonEye();
	}
	//public void ani_event_disable_btn_Death() de o ham Sa_skill

}
