﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using Statut_NS;

/// <summary>
/// @Author Kévin & Baptiste
/// Personnage.
/// </summary>
public class Personnage : MonoBehaviour {

	/// <summary>
	/// The _nom.
	/// </summary>
    private string _nom;
	/// <summary>
	/// The _race.
	/// </summary>
    private Race _race;
	/// <summary>
	/// The _element.
	/// </summary>
    private Element _element;
	/// <summary>
	/// The _caracteristiques.
	/// </summary>
    private Caracteristiques _caracteristiques;
	/// <summary>
	/// The _equipement.
	/// </summary>
    private List<Equipement> _equipement;
	/// <summary>
	/// The _arme.
	/// </summary>
    private Arme _arme;
	/// <summary>
	/// The _attaques.
	/// </summary>
    private List<Attaque> _attaques;
	/// <summary>
	/// The _statut.
	/// </summary>
    private Statut _statut;
	/// <summary>
	/// The _buffs.
	/// </summary>
    private List<Buff> _buffs;
	/// <summary>
	/// The _ecole.
	/// </summary>
    private Ecole _ecole;

	/// <summary>
	/// The equipe.
	/// </summary>
	private Team _team;

	/// <summary>
	/// This _is my turn.
	/// </summary>
	private bool _isMyTurn;
	
	//-----------
	//constructeur

	/// <summary>
	/// 
	/// </summary>
	/// <param name="nom">Nom.</param>
	/// <param name="race">Race.</param>
	/// <param name="element">Element.</param>
	/// <param name="carac">Carac.</param>
	/// <param name="equipements">Equipements.</param>
	/// <param name="arme">Arme.</param>
	/// <param name="attaques">Attaques.</param>
	/// <param name="statut">Statut.</param>
	/// <param name="buffs">Buffs.</param>
	/// <param name="ecole">Ecole.</param>
	/// <param name="team">Team.</param>
	public Personnage(string nom, Race race, Element element, Caracteristiques carac,
	                  List<Equipement> equipements,Arme arme, List<Attaque> attaques, Statut statut, 
	                  List<Buff> buffs, Ecole ecole, Team team)
	{
				this._nom = nom;
				this._race = race;
				this._element = element;
				this._caracteristiques = carac;
				this._equipement = equipements;
				this._arme = arme;
				this._attaques = attaques;
				this._statut = statut;
				this._buffs = buffs;
				this._ecole = ecole;
				this._team=team;
				this._isMyTurn=false;
	}

	//_______________
	//methodes

	/// <summary>
	/// Gets the nom.
	/// </summary>
	/// <value>The nom.</value>
	public string Nom {
		get {
			return this._nom;
		}
	}

	/// <summary>
	/// Gets the race.
	/// </summary>
	/// <value>The race.</value>
	public Race Race{
		get {
			return this._race;
		}
	}

	/// <summary>
	/// Gets the element.
	/// </summary>
	/// <value>The element.</value>
	public Element Element{
		get {
			return this._element;
		}
	}

	/// <summary>
	/// Gets the caracteristiques.
	/// </summary>
	/// <value>The caracteristiques.</value>
	public Caracteristiques Caracteristiques{
		get {
			return this._caracteristiques;
		}
	}

	/// <summary>
	/// Gets the equipement.
	/// </summary>
	/// <value>The equipement.</value>
	public List<Equipement> Equipement{
		get {
			return this._equipement;
		}
	}		

	/// <summary>
	/// Gets or sets the arme.
	/// </summary>
	/// <value>The arme.</value>
	public Arme Arme{
		get {
			return this._arme;
		}
		set {
			this._arme = value;
		}
	}

	/// <summary>
	/// Gets the attaques.
	/// </summary>
	/// <value>The attaques.</value>
	public List<Attaque> Attaques{
		get {
			return this._attaques;
		}
	}



	/// <summary>
	/// Gets or sets the statut.
	/// </summary>
	/// <value>The statut.</value>
	public Statut Statut{
		get {
			return this._statut;
		}
		set {
			this._statut = value;
		}
	}

	/// <summary>
	/// Gets the buffs.
	/// </summary>
	/// <value>The buffs.</value>
	public List<Buff> Buffs{
		get {
			return this._buffs;
		}
	}

	/// <summary>
	/// Gets the ecole.
	/// </summary>
	/// <value>The ecole.</value>
	public Ecole Ecole{
		get {
			return this._ecole;
		}
	}

	/// <summary>
	/// Gets the team.
	/// </summary>
	/// <value>The team.</value>
	public Team Team{
		get{
			return this._team;
		}
	}


	/// <summary>
	/// Ajouts the attaque.
	/// </summary>
	/// <param name="attack">Attack.</param>
	public void ajoutAttaque (Attaque attack){
		this._attaques.Add (attack);
	}


	/// <summary>
	/// Choice of the attaque.
	/// </summary>
	/// <returns>The attaque.</returns>
	/// <param name="i">The index.</param>
	public Attaque choixAttaque(int i){
		return this.Attaques[i];
	}

	/// <summary>
	/// Gets or sets a value indicating whether this instance is my turn.
	/// </summary>
	/// <value><c>true</c> if this instance is my turn; otherwise, <c>false</c>.</value>
	public bool IsMyTurn{
		get{
			return this._isMyTurn;
		}
		set{
			this._isMyTurn = value;
		}
	}


	public void DecrementerBuff(){
		//TODO void DECREMENTER BUFF 
		//Steven & Billel

	}

	/// <summary>
	/// Dead this instance.
	/// </summary>
	public bool  Dead(){
	return  Caracteristiques.Vitalite <= 0 ; 
	}





}