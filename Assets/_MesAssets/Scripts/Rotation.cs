using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] private float _angleRotation = 0.5f;
    [SerializeField] private float _vitesseRotation = 5f;

    void Update()
    {
        transform.Rotate(0f, _angleRotation * Time.deltaTime * _vitesseRotation, 0f);
    }
}
