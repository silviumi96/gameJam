using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInteract : MonoBehaviour
{
	public GameObject RaycastedObject { get; private set; }
	private Transform cameraTransform;
	private Image crosshair;
	private Vector3 cameraForward;
	private LayerMask layerMask;
	private RaycastHit hit;

	private UIManager uiManager;

	private float interactionDistance = 5f;

	private void Awake()
	{
		cameraTransform = GetComponentInChildren<Camera>().transform;
		uiManager = GameObject.Find("UIManager").GetComponent<UIManager>();
		crosshair = uiManager.CrosshairImage;

		crosshair.color = Color.white;
		layerMask = LayerMask.GetMask("Interactable");
	}

	private void Update()
	{
		cameraForward = cameraTransform.forward;

		if (Physics.Raycast(cameraTransform.position, cameraForward, out hit, interactionDistance, layerMask))
		{
			crosshair.color = Color.red;
			if (Input.GetMouseButtonDown(0))
			{
				Debug.Log("Interacted with " + hit.transform.name);
				Debug.DrawRay(transform.position, cameraForward, Color.red, 9999999);
			}
		}
		else
		{
			crosshair.color = Color.white;
		}
	}
}
