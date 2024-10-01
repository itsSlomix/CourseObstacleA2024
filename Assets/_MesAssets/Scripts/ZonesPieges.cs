using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZonesPieges : MonoBehaviour
{
    [SerializeField] private List<GameObject> _listepieges = default;
    [SerializeField] private float _intensiteForce = 100000f;
    private List<Rigidbody> _listeRb = new List<Rigidbody>();

    private void Awake()
    {
        foreach(var piege in _listepieges)
        {
            _listeRb.Add(piege.GetComponent<Rigidbody>());
            piege.GetComponent<Rigidbody>().useGravity = false;
        }
    }
    private void Start()
    {
        //_rb = _piege.GetComponent<Rigidbody>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            foreach(var rb in _listeRb)
            {
                rb.useGravity = true;
                rb.AddForce(Vector3.down * _intensiteForce);
            }
        }
    }
}
