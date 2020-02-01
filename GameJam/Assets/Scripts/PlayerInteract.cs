using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInteract : MonoBehaviour
{
	public GameObject RaycastedObject { get; private set; }
	public Transform CameraTransform;
	public Image Crosshair;
	private Vector3 cameraForward;
	private LayerMask layerMask;
	private RaycastHit hit;

	private float interactionDistance = 5f;

	private void Awake()
	{
		if (CameraTransform == null)
		{
			CameraTransform = GetComponentInChildren<Camera>().transform;
		}

		Crosshair.color = Color.white;
		layerMask = LayerMask.GetMask("Interactable");
	}

	private void Update()
	{
		cameraForward = CameraTransform.forward;

		if (Physics.Raycast(CameraTransform.position, cameraForward, out hit, interactionDistance, layerMask))
		{
			Crosshair.color = Color.red;
			if (Input.GetMouseButtonDown(0))
			{
				Debug.Log("Interacted with " + hit.transform.name);
                hit.transform.GetComponent<Logic>()?.action();
				Debug.DrawRay(transform.position, playerForward, Color.red, 9999999);
			}
		}
		else
		{
			Crosshair.color = Color.white;
		}
	}
}
