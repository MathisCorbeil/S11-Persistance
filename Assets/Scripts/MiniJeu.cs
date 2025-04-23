using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniJeu : MonoBehaviour
{
    public float pointageTemps;
    public TextMeshProUGUI textScore;
    public TextMeshProUGUI textScorePanneau;
    public TMP_InputField inputNom;

    [SerializeField] GameObject panneauRecord;

    void Start()
    {
        //PlayerPrefs.DeleteAll();
        pointageTemps = 0;
    }

    private void Update()
    {
        textScore.text = pointageTemps.ToString("00.00");
    }

    public void TraiterDefaite()
    {
        Debug.Log("Bob");
        float recordActuel = PlayerPrefs.GetFloat("meilleurScore", 0f);
        if (pointageTemps>=recordActuel)
        {
            Invoke("MontrerPanneauNouveauRecord", 3f);

        }
       
    }

    void MontrerPanneauNouveauRecord()
    {
        panneauRecord.SetActive(true);
        textScorePanneau.text=textScore.text;
    }

    public void EnregistrerNomRecord()
    { 
        string nom = inputNom.text;
        PlayerPrefs.SetString("nom", nom);

        //redemarer la scean
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }




}
