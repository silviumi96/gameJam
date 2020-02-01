using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
	public EndScreenPanel EndScreenPanel { get; private set; }

	private void Awake()
	{
		Init();
		EndScreenPanel.Close();
	}

	private void Init()
	{
		EndScreenPanel = GetComponentInChildren<EndScreenPanel>();
	}
}
