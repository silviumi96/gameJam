using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInteract : MonoBehaviour
{
	public GameObject RaycastedObject { get; private set; }
	public Image crosshair;
	private Vector3 playerForward;
	private LayerMask layerMask;
	private RaycastHit hit;

	private float interactionDistance = 5f;

	private void Awake()
	{
		layerMask = LayerMask.GetMask("Interactable");
		crosshair.color = Color.white;
	}

	private void Update()
	{
		playerForward = transform.TransformDirection(Vector3.forward);

		if (Physics.Raycast(transform.position, playerForward, out hit, interactionDistance, layerMask))
		{
			crosshair.color = Color.red;
			if (Input.GetMouseButtonDown(0))
			{
				Debug.Log("Interacted with " + hit.transform.name);
                hit.transform.GetComponent<Logic>()?.action();
				Debug.DrawRay(transform.position, playerForward, Color.red, 9999999);
			}
		}
		else
		{
			crosshair.color = Color.white;
		}
	}
}
