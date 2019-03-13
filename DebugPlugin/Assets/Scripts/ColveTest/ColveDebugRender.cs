using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColveDebugRender : MonoBehaviour
{
	public Text contentText;
	public Text messageText;

	public void Init(string content, string title, float time)
	{
		contentText.text = " " + content;
		messageText.text = " Title:" + title + "   " + "Time:" + time;
	}

	public void OnBtnClick()
	{
		messageText.gameObject.SetActive(!messageText.gameObject.activeSelf);
	}
}
