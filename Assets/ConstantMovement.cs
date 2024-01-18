using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantMovement : MonoBehaviour
{
    [SerializeField] float speed = 0.01f;

    void Update()
    {
        this.transform.Translate(Vector3.forward * speed);
    }
}
