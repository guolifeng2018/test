using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRotate : MonoBehaviour
{
    public float RotateSpeed = 30f;

    void Update()
    {
        transform.Rotate( Vector3.up , RotateSpeed );
    }
}
