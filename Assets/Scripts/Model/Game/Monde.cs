﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;


/// <summary>
/// @Author : Anne-Claire
/// </summary>
public class Monde : MonoBehaviour {

	//Attributs
    private string _nom;
    private string _histoire;
	private bool _estDisponible;
	private bool _estFini;
    private List<Mission> _missions;
	private int _encours;		//numéro de la mission en cours
	private Ecole _ecole;

   // private List<Personnage> personnagesDisponibles; //Alliés ou PNJ ?
    private List<Objet> objetsDisponibles; //dépend de la difficulté ou du prix
    

	//Création d'une map constante (classe à part) contenant TOUS les objets qui existent (BDD ?) ainsi qu'un niveau de difficulté
	//L'idée serait qu'un monde soit associé a un niveau de difficulté : donne accès aux objets uniquement du meme niveau
	//Concept que l'on pourrait généraliser partout si le joueur possède dans ses stats non visibles ce niveau : permettrait d'adapter les magasins, etc


	/// <summary>
	/// Initializes a new instance of the <see cref="Monde"/> class.
	/// </summary>
	/// <param name="nom">Nom du monde.</param>
	/// <param name="histoire">Histoire du monde.</param>
	/// <param name="missions">Missions à effectuer sur le monde.</param>
	/// <param name="fini">Vaut <c>true<c/> si toutes les missions ont été effectuées</param>
	/// <param name="disponible"> Vaut <c>true</c> si les informations sont visibles</param>
	/// <remarks>1er constructeur : pas d'école sur le monde</remarks>
	public Monde (string nom, string histoire, List<Mission> missions, bool fini, bool disponible){
		this._nom = nom;
		this._histoire = histoire;
		this._missions = missions;
		this._estFini = fini;
		this._ecole = null;
		
		//On initialise à la 1ère mission
		this._encours = 0;

		//Si le monde n'est pas disponible rien ne sera visible
		this._estDisponible = disponible;

	}


	/// <summary>
	/// Initializes a new instance of the <see cref="Monde"/> class.
	/// </summary>
	/// <param name="nom">Nom du monde.</param>
	/// <param name="histoire">Histoire du monde.</param>
	/// <param name="missions">Missions à effectuer sur le monde.</param>
	/// <param name="fini">Vaut <c>true<c/> si toutes les missions ont été effectuées</param>
	/// <param name="disponible"> Vaut <c>true</c> si les informations sont visibles</param>
	/// <param name="ecole">Ecole présente sur le monde</param> 
	public Monde (string nom, string histoire, List<Mission> missions, bool fini, bool disponible, Ecole ecole){
		this._nom = nom;
		this._histoire = histoire;
		this._missions = missions;
		this._estFini = fini;
		this._ecole = ecole;

		//Si le monde n'est pas disponible rien ne sera visible
		this._estDisponible = disponible;

		//On initialise à la 1ère mission
		this._encours = 0;
	} 


	//-------------------------Getters


	/// <summary>
	/// Gets the name.
	/// </summary>
	/// <value>The name.</value>
	public string Nom { get { return this._nom;} }

	/// <summary>
	/// Gets the history.
	/// </summary>
	/// <value>The history.</value>
	public string Histoire { get { return this._histoire; } }

	/// <summary>
	/// Gets the missions.
	/// </summary>
	/// <value>The missions.</value>
	public List<Mission> Missions { get { return this._missions; } }

	/// <summary>
	/// Gets a value indicating whether this <see cref="Monde"/> is disponible.
	/// </summary>
	/// <value><c>true</c> if disponible; otherwise, <c>false</c>.</value>
	public bool Disponible { get { return this._estDisponible; } }

	/// <summary>
	/// Gets a value indicating whether this <see cref="Monde"/> is fini.
	/// </summary>
	/// <value><c>true</c> if fini; otherwise, <c>false</c>.</value>
	public bool Fini { get { return this._estFini; } }

	/// <summary>
	/// Gets the number of the mission "en cours".
	/// </summary>
	/// <value>The number.</value>
	public int EnCours{ get { return this._encours; } }

	/// <summary>
	/// Gets the school.
	/// </summary>
	/// <value>The school.</value>
	public Ecole Ecole{ get{ return this._ecole; } }





	/// <summary>
	/// To call when the mission is done.
	/// </summary>
	/// <returns>List of the loots.</returns>
	/// <param name="terminee">The mission.</param>
	public List<Objet> MissionFinie (Mission terminee){
		//On incrémente la mission en cours
		this._encours++;

		//On génère les récompenses
		List<Objet> butin = terminee.GenerateurRecompenses (3, 5, true);

		//On vérifie si toutes les missions sont réalisées
		bool fini = true;
		for (int i=0; i<this.Missions.Count; ++i) {
			if(i == this._encours){
				fini=false;
				break;
			}
		}

		//Si toutes les missions sont finies on le signale car le monde est terminé
		if (fini) {
			this._estFini = true;
		}

		return butin;
	}

	

}
