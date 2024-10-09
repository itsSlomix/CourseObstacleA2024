using UnityEngine;

public class GestionCollision : MonoBehaviour
{
    [SerializeField] private Material _materiel = default;
    private bool _estTouche = false;

    private void OnCollisionEnter(Collision collision)
    {
        if(!_estTouche)
        {
            GetComponent<MeshRenderer>().material = _materiel;
            GameManager.Instance.AugmenterPointage();
            _estTouche = true;
        }
    }
}
