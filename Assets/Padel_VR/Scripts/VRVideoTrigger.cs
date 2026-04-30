using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class VRVideoTrigger : MonoBehaviour
{
    public GameObject uiPanel;
    public GameObject videoPanel;
    public HologramPlayer hologramPlayer;

    private List<InputDevice> devices = new List<InputDevice>();
    private InputDevice leftController;
    private bool isTriggered = false;

    void Start()
    {
        uiPanel.SetActive(false);
        videoPanel.SetActive(false);

        GetLeftController();
    }

    void GetLeftController()
    {
        devices.Clear();
        InputDevices.GetDevicesWithCharacteristics(
            InputDeviceCharacteristics.Left | InputDeviceCharacteristics.Controller,
            devices
        );

        if (devices.Count > 0)
        {
            leftController = devices[0];
            Debug.Log("Left Controller Found");
        }
        else
        {
            Debug.Log("No Left Controller Found");
        }
    }

    void Update()
    {
        if (!leftController.isValid)
        {
            GetLeftController();
            return;
        }

        bool triggerPressed;

        if (leftController.TryGetFeatureValue(CommonUsages.triggerButton, out triggerPressed))
        {
            if (triggerPressed && !isTriggered)
            {
                isTriggered = true;
                Show();
            }

            if (!triggerPressed)
            {
                isTriggered = false;
            }
        }
    }

    void Show()
    {
        uiPanel.SetActive(true);
        videoPanel.SetActive(true);

        hologramPlayer.PlayVideo();
    }
}