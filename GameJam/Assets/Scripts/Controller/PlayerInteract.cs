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

	private void Start()
	{
		cameraTransform = GetComponentInChildren<Camera>().transform;
		uiManager = GameObject.Find(Constants.UI_MANAGER_OBJECT_NAME).GetComponent<UIManager>();
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
				if (hit.transform.gameObject.tag == "Wire")
				{
					hit.transform.GetComponent<Logic>()?.action(hit.transform);
				}

				Debug.Log("Interacted with " + hit.transform.name);
				hit.transform.GetComponent<Logic>()?.action();
			}
		}
		else
		{
			crosshair.color = Color.white;
		}
	}
}
