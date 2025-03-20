using BNG;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;
using UnityEngine.Events;
using VRExplorer;
public class ButtonVR : MonoBehaviour, ITriggerableEntity
{
    [ExcludeFromCodeCoverage] public float TriggeringTime => 1.5f;
    [ExcludeFromCodeCoverage] public string Name => Str.Triggerable;

    [ExcludeFromCodeCoverage]
    public void Triggerring()
    {
        onPress?.Invoke();
    }

    [ExcludeFromCodeCoverage]
    public void Triggerred()
    {
        onRelease?.Invoke();
    }

    public GameObject button;
    public UnityEvent onPress;
    public UnityEvent onRelease;
    GameObject presser;
    bool isPressed;

    void Start()
    {
        isPressed = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(!isPressed)
        {
            button.transform.localPosition = new Vector3(-0.52f, 0.279f, -0.133f);
            presser = other.gameObject;
            onPress.Invoke();
            isPressed = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject == presser)
        {
            button.transform.localPosition = new Vector3(-0.544f, 0.279f, -0.133f);
            onRelease.Invoke();
            isPressed = false;
        }
    }

    public void SpawnSphere()
    {
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
        sphere.transform.localPosition = new Vector3(-0.98f, -0.18f, 0.4f);
        sphere.AddComponent<Rigidbody>();
    }
}