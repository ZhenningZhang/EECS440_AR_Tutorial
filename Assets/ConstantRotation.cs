using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantRotation : MonoBehaviour
{
    [SerializeField] float speed = 0.2f;
    [SerializeField] RotateTo direction = RotateTo.Right;

    void Update()
    {
        if (direction == RotateTo.Right)
            this.transform.Rotate(Vector3.up * speed);
        else
            this.transform.Rotate(Vector3.left * speed);
    }
}

public enum RotateTo { Up, Right };