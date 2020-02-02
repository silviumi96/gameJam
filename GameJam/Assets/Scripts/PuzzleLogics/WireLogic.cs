using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WireLogic : Logic
{
	private List<string> correctOrder = new List<string>();
	private UIManager uIManager;

	private void Start()
	{
		correctOrder.Add("RedWire");
		correctOrder.Add("YellowGrid");
		correctOrder.Add("GreenWire");
		correctOrder.Add("BlueWire");
		uIManager = GameObject.Find("GameUI").GetComponent<UIManager>();
	}

	public override void action(Transform wire)
	{
		if (correctOrder.Count > 0)
		{
			if (wire.name == correctOrder[0])
			{
				correctOrder.Remove(wire.name);
				//cut wire animation
			}
			else
			{
				uIManager.EndScreenPanel.SetGameOverLabel("You doomed us all!");
				uIManager.EndScreenPanel.Open();
			}

			uIManager.EndScreenPanel.SetGameOverLabel("You saved the world!");
			uIManager.EndScreenPanel.Open();
		}
	}
}
