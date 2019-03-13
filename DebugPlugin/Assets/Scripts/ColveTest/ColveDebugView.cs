using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ColveDebugView : MonoBehaviour
{
	private static ColveDebugView instance;

	public static ColveDebugView Create()
	{
		GameObject obj = Resources.Load<GameObject>("ColveTest/ColveDebugView");
		return Instantiate(obj).GetComponent<ColveDebugView>();
	}

	private void Awake()
	{
		ColveDebugView.instance = this;
	}

	public GameObject renderObj;
	public Transform listTran;
	public Transform panel;
	
	public void CreateRender(string content, string title = "")
	{
		GameObject obj = Instantiate(renderObj, listTran);
		obj.GetComponent<ColveDebugRender>().Init(content, title, Time.realtimeSinceStartup);
	}

	public static void Log(string content, string title = "")
	{
		if (ColveDebugView.instance == null)
		{
			ColveDebugView.Create().CreateRender(content, title);
			return;
		}
		ColveDebugView.instance.CreateRender(content, title);
	}

	private Vector3 disVec3;
	
	public void OnPanelBeginDrag(BaseEventData data)
	{
		disVec3 = Input.mousePosition - panel.position;
	}

	public void OnPanelDrag(BaseEventData data)
	{
		panel.position = Input.mousePosition - disVec3;
	}

	public void OnDesBtnClick()
	{
		instance = null;
		Destroy(gameObject);
	}
}