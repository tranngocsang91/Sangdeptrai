using UnityEngine;
using System.Collections;

public class Sa_skills : MonoBehaviour {

	Animator aniTor;

	//for Death Mode
	public GameObject createDeath_prefab;
	private GameObject go_createDeath;
	public GameObject go_createRongSamSet;
	// Use this for initialization
	void Start () {
		aniTor = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		int NotificationId = 
			UM_NotificationController.instance.ScheduleLocalNotification(
				"HelloLocacl", "Local NotificationExample", 5);

	}


	//khinhannutskilllua
	public void press_skillLua()
	{
		if(Sa_info.isSkill)return;
		if(Sa_info.isDie)return;
		aniTor.Play("Skill_PhunLua_Right");
	}

	public void press_skill_Chem()
	{
		if(Sa_info.isSkill) return;
		if(Sa_info.isDie) return;
		if(Random.value < 0.3f)
		{
			aniTor.Play("Skill_1_Chem_Right");
		}
		else
		{
			if(Random.value < 0.55f)
			{
				aniTor.Play("Skill_2_Chem_Right");
			}
			else
			{
				if(Random.value < 0.8f)
				{
					aniTor.Play("Skill_3_Chem_Right");
				}
				else
				{
					aniTor.Play("Skill_4_Chem_Right");
				}
			}
		}
		if(Sa_info.isRight)
		{
			iTween.MoveTo(gameObject, transform.position + new Vector3( 0.1f, 0f, 0f), 0.2f);
		}
		else
		{
			iTween.MoveTo(gameObject, transform.position + new Vector3( -0.2f, 0f, 0f), 0.3f);
		}
	}

	public void press_skill_DoiKiem()
	{
		if(Sa_info.isSkill) return;
		if(Sa_info.isDie) return;
		aniTor.Play("Sasuke_Doi_kiem_right");
	}

	public void press_skill_Death()
	{
		if(Sa_info.isSkill) return;
		if(Sa_info.isDie) return;
		Sa_info.isDeath = true;
		Sa_info.isDeathSkill = true;
		Sa_UIcontrol.instance.turnOnDeathMode();
		go_createDeath = Instantiate(createDeath_prefab, transform.position + new Vector3(0f, -0.34f, -0.5f), Quaternion.identity) as GameObject;
		go_createDeath.transform.parent = transform;

	}
	public void press_DeathChem()
	{
		if(Sa_info.isDie) return;
		if(Sa_info.go_death != null && !Sa_info.isDeathSkill) Sa_info.go_death.GetComponent<Death_Actions>().Chem();
	}
	public void press_Death_Off()
	{
		Sa_info.isDeath = false;
		Sa_UIcontrol.instance.turnOffDeathMode();
		if(go_createDeath != null) Destroy(go_createDeath);
		if(Sa_info.go_death != null) Destroy(Sa_info.go_death);
		Sa_UIcontrol.instance.turnOnDisableButtonDeath();
	}

	//bat dau cua idle state, thiet lap san sang cho skill moi
	public void setStateReadyForSkill()
	{
		Sa_info.isSkill = false;
	}
	//bat dau moi skill (ngoai tru skill chem), thiet lap la dang choi skill, ko cho skill khac choi
	public void setStateProducingSkill()
	{
		Sa_info.isSkill = true;
	}

	public void press_createRongSamSet()
	{
		if(Sa_info.isSkill) return;
		if(Sa_info.isDie) return;
		go_createRongSamSet.SetActive(true);
		aniTor.Play("Button_Power_Right");
	}
}
