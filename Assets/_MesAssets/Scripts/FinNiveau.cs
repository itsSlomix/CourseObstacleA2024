using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  //Utiliser pour manipuler le nbr de scenes


public class FinNiveau : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player")); //Quand le joeur est touche
        {

            if(SceneManager.GetActiveScene().buildIndex == SceneManager.sceneCountInBuildSettings - 1)  //Si je suis a la derniere scene de mon jeu
            {
                GameManager.Instance.FinPartie();
                Destroy(collision.gameObject);
            }
            else
            {
                GameManager.Instance.FinNiveau1();
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);   //Ou sinon change de scene
            }
        }
    }
}
