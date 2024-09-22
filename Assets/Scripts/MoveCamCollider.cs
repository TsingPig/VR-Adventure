using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using UnityEngine;

public class MoveCamCollider : MonoBehaviour
{
    CapsuleCollider _collider;
    XROrigin _xrOrigin;
    void Start()
    {
        _collider = GetComponent<CapsuleCollider>();
        _xrOrigin = GetComponent<XROrigin>();
    }

    void FixedUpdate()
    {
        _collider.height = _xrOrigin.CameraInOriginSpaceHeight;
        _collider.center = new Vector3(
            _xrOrigin.CameraInOriginSpacePos.x,
            _collider.height / 2,
            _xrOrigin.CameraInOriginSpacePos.z);
    }
}
