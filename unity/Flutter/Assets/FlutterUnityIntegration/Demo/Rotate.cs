using System;
using FlutterUnityIntegration;
using UnityEngine;
using UnityEngine.EventSystems;
using System.Globalization;

public class Rotate : MonoBehaviour, IEventSystemHandler
{
    Vector3 _rotateAmount;

    // Start is called before the first frame update
    void Start()
    {
        _rotateAmount = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(_rotateAmount * (Time.deltaTime * 120));

        for (int i = 0; i < Input.touchCount; ++i)
        {
            if (Input.GetTouch(i).phase.Equals(TouchPhase.Began))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(i).position);

                if (Physics.Raycast(ray, out _))
                {
                    // This method is used to send data to Flutter
                    UnityMessageManager.Instance.SendMessageToFlutter("The cube feels touched.");
                }
            }
        }
    }

    // This method is called from Flutter
    public void SetRotationSpeed(String message)
    {
        float value = float.Parse(message , CultureInfo.InvariantCulture.NumberFormat);
        _rotateAmount = new Vector3(value, value, value);
    }
}
