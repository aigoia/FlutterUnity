using System;
using FlutterUnityIntegration;
using UnityEngine;
using UnityEngine.EventSystems;
using System.Globalization;

public class Rotate : MonoBehaviour, IEventSystemHandler
{
    Vector3 _rotateAmount;
    UnityMessageManager UnityMassageManagerNode => GetComponent<UnityMessageManager>();

    // Start is called before the first frame update
    void Start()
    {
        _rotateAmount = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(_rotateAmount * (Time.deltaTime * 120));
    }

    // This method is called from Flutter
    public void SetRotationSpeed(string message)
    {
        float value = float.Parse(message , CultureInfo.InvariantCulture.NumberFormat);
        _rotateAmount = new Vector3(value, value, value);
        
        UnityMassageManagerNode.SendMessageToFlutter(value.ToString(CultureInfo.InvariantCulture.NumberFormat));
    }
}
