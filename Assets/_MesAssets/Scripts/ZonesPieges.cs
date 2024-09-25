using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZonesPieges : MonoBehaviour
{
    [SerializeField] private List<GameObject> _listepieges = default;
    [SerializeField] private float _intensiteForce = 100000f;
    private Rigidbody _rb;

    private void Start()
    {
        //_rb = _piege.GetComponent<Rigidbody>();
        _rb.useGravity = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            _rb.useGravity = true;
            _rb.AddForce(Vector3.down * _intensiteForce);
        }
    }
}
