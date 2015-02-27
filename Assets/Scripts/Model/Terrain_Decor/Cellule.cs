using UnityEngine;
using System.Collections;

public class Cellule : MonoBehaviour {

    private Statut 			statut;
    private Coordonnee		coordonnee;
    private Decor			decor;
    private Team			appartenance;


    public bool estFranchissable()
    {
        return false;
    }
}
