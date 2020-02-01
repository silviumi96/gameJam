using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndScreenPanel : MonoBehaviour
{
	public bool IsOpen { get; private set; }
	private TextMeshProUGUI gameOverLabel;

	private void Awake()
	{
		Init();
		SetGameOverLabel();
	}

	private void Init()
	{
		gameOverLabel = GetComponentInChildren<TextMeshProUGUI>();
	}

	private void SetGameOverLabel(string text = "GameOver")
	{
		gameOverLabel.text = text;
	}

	public void Open()
	{
		IsOpen = true;
		transform.gameObject.SetActive(true);
	}

	public void Close()
	{
		IsOpen = false;
		transform.gameObject.SetActive(false);
	}
}
