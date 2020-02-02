using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WireLogic : Logic
{
	private List<string> correctOrder = new List<string>();
	private UIManager uIManager;

	private void Start()
	{
		correctOrder.Add("Wire_A");
		correctOrder.Add("Wire_B");
		correctOrder.Add("Wire_C");
		correctOrder.Add("Wire_D");
		uIManager = GameObject.Find("GameUI").GetComponent<UIManager>();
	}

	public override void action(Transform wire)
	{
		if (correctOrder.Count > 0)
		{
            Debug.Log(wire.name);
            Debug.Log(correctOrder[0]);
			if (wire.name == correctOrder[0])
			{
                correctOrder.RemoveAt(0);
				//correctOrder.Remove(wire.name);
				//cut wire animation
			}
			else
			{
				uIManager.EndScreenPanel.SetGameOverLabel("You doomed us all!");
				uIManager.EndScreenPanel.Open();
			}

            if (correctOrder.Count == 0)
            {

                uIManager.EndScreenPanel.SetGameOverLabel("You saved the world!");
                uIManager.EndScreenPanel.Open();
            }
		}
	}
}
