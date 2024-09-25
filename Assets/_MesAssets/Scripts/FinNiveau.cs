using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinNiveau : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player")); //Quand le joeur est touche
        {
        GameManager.Instance.FinPartie();
        Destroy(collision.gameObject);
        }
    }
}
