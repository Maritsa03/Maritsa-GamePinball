using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZoomOut : MonoBehaviour
{
    public Collider bola;
    public cameraController cameraController;

    private void OnTriggerEnter(Collider other)
    {
        if (other == bola)
        {
            cameraController.GoBackToDefault();
        }
	}
}
