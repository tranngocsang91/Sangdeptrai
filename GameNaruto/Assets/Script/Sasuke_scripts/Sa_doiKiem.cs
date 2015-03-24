using UnityEngine;
using System.Collections;

public class Sa_doiKiem : MonoBehaviour {

	public static Sa_doiKiem instance;

	public Sprite[] sp_bongKiemThuong;
	public Sprite[] sp_bongKiemDien;
	public Sprite[] sp_bongKiemLua;
	public Sprite sp_KiemThuong;
	public Sprite sp_KiemDien;
	public Sprite sp_KiemLua;
	public SpriteRenderer[] bongKiem;
	public RuntimeAnimatorController animator_kiemLua;
	public RuntimeAnimatorController animator_kiemDien;

	public GameObject kiemT;
	public GameObject kiemP;
	// Use this for initialization
	void Start () {
		instance = this;
		setKiem();
	}
	
	// Update is called once per frame
	void Update () {
		
	}



	public void setKiem()
	{
		Debug.Log("setkiem");
		switch (Sa_info.curKiem)
		{
		case 0:
		{
			setKiemThuong();
			break;
		}
		case 1:
		{
			setKiemLua();
			break;
		}
		case 2:
		{
			setKiemDien();
			break;
		}
		}
	}
	private void setKiemThuong()
	{
		kiemP.GetComponent<SpriteRenderer>().sprite = sp_KiemThuong;
		kiemP.GetComponent<Animator>().enabled = false;
		kiemT.GetComponent<SpriteRenderer>().sprite = sp_KiemThuong;
		kiemT.GetComponent<Animator>().enabled = false;
		int n = bongKiem.Length;
		for(int i = 0; i < n; i++)
		{
			bongKiem[i].sprite = sp_bongKiemThuong[i];
		}
	}

	private void setKiemDien()
	{
		kiemP.GetComponent<SpriteRenderer>().sprite = sp_KiemDien;
		kiemP.GetComponent<Animator>().enabled = true;
		kiemP.GetComponent<Animator>().runtimeAnimatorController = animator_kiemDien;
		kiemT.GetComponent<SpriteRenderer>().sprite = sp_KiemDien;
		kiemT.GetComponent<Animator>().enabled = true;
		kiemT.GetComponent<Animator>().runtimeAnimatorController = animator_kiemDien;
		int n = bongKiem.Length;
		for(int i = 0; i < n; i++)
		{
			bongKiem[i].sprite = sp_bongKiemDien[i];
		}
	}

	private void setKiemLua()
	{
		kiemP.GetComponent<SpriteRenderer>().sprite = sp_KiemLua;
		kiemP.GetComponent<Animator>().enabled = true;
		kiemP.GetComponent<Animator>().runtimeAnimatorController = animator_kiemLua;
		kiemT.GetComponent<SpriteRenderer>().sprite = sp_KiemLua;
		kiemT.GetComponent<Animator>().enabled = true;
		kiemT.GetComponent<Animator>().runtimeAnimatorController = animator_kiemLua;
		int n = bongKiem.Length;
		for(int i = 0; i < n; i++)
		{
			bongKiem[i].sprite = sp_bongKiemLua[i];
		}
	}
}
