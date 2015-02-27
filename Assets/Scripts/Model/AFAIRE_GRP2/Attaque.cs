using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Attaque : MonoBehaviour {

    private string nom;
    private string description;
    private List<Effets> effets;
    private List<Effets> effetsCritiques;
    //duree avant que le sort soit réutilisable
    private int cooldown;
    private Element element;

}
