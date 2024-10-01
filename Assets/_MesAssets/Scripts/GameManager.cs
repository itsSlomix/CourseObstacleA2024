using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Déclaration singleton
    //-------------------------------------------------
    public static GameManager Instance;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(this);
        }
    }
    //-------------------------------------------------

    private int _pointage;
    private int _accrochageNiveau1;
    private float _tempsNiveau1;

    void Start()
    {
        _pointage = 0;
    }

    public void FinNiveau1()
    {
        _accrochageNiveau1 = _pointage;
        _tempsNiveau1 = Time.time;
    }
    public void AugmenterPointage()
    {
        _pointage++;
        Debug.Log("Nombre d'accrochages : " + _pointage);
    }

    public void FinPartie()
    {

        Debug.Log("Le nombre total de collision au niveau 1 est : " + _accrochageNiveau1);
        Debug.Log("Le temps total pour le niveau 1 est de :  " + _tempsNiveau1.ToString("f2")); //Time.time le temps depuis le debut du jeu
        Debug.Log("*******************************************************"); //Time.time le temps depuis le debut du jeu
        Debug.Log("Le nombre total de collision au niveau 2 est : " + _accrochageNiveau1);
        Debug.Log("Le temps total pour le niveau 2 est de :  " + (Time.time -_tempsNiveau1).ToString("f2")); //Time.time le temps depuis le debut du jeu
        Debug.Log("*******************************************************"); //Time.time le temps depuis le debut du jeu
        Debug.Log("Le nombre total de collision est : " + _pointage);
        Debug.Log("Le temps total pour les niveaux est de :  " + Time.time.ToString("f2")); //Time.time le temps depuis le debut du jeu
        Debug.Log("Pointage final est :  " + (Time.time + _pointage).ToString("f2")); //Time.time le temps depuis le debut du jeu
    }
}
