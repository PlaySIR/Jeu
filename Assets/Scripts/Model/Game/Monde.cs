using UnityEngine;
using System.Collections;
using System.Collections.Generic;


/// <summary>
/// @Author : Anne-Claire
/// </summary>
public class Monde : MonoBehaviour {

	//Attributs
    private string _nom;
    private string _history;
    private List<Mission> _missions;

    private List<Personnage> personnagesDisponibles; //Alliés ou PNJ ?
    private List<Objet> objetsDisponibles;
    private bool estDisponible;
    private List<Ecole> ecoles;

	//Liste d'écoles ? Ou une seule école ?

	//Création d'une map constante (classe à part) contenant TOUS les objets qui existent (BDD ?) ainsi qu'un niveau de difficulté
	//L'idée serait qu'un monde soit associé a un niveau de difficulté : donne accès aux objets uniquement du meme niveau
	//Concept que l'on pourrait généraliser partout si le joueur possède dans ses stats non visibles ce niveau : permettrait d'adapter les magasins, etc


	/// <summary>
	/// Initializes a new instance of the <see cref="Monde"/> class.
	/// </summary>
	/// <param name="nom">Nom du monde.</param>
	/// <param name="histoire">Histoire du monde.</param>
	/// <param name="missions">Missions à effectuer sur le monde.</param>
	public Monde (string nom, string histoire, List<Mission> missions){
		this._nom = nom;
		this._history = histoire;
		this._missions = missions;

		//Opérations pour savoir si le monde est disponible ou non
		estDisponible = Statistiques.MondeDisponible(this);
	}



}
