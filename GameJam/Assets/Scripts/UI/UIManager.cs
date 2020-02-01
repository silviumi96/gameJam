using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
	public EndScreenPanel EndScreenPanel { get; private set; }
	public Image CrosshairImage { get; private set; }

	private void Awake()
	{
		Init();
		EndScreenPanel.Close();
	}

	private void Init()
	{
		EndScreenPanel = GetComponentInChildren<EndScreenPanel>();
		CrosshairImage = GameObject.Find("Crosshair").GetComponent<Image>();
	}
}
