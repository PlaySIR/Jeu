using UnityEngine;
using System.Collections;

public class Equipement : Objet {
	//hérite de Objet



	//attributs
	/// <summary>
	/// The _caracteristiques.
	/// </summary>
	private Caracteristiques _caracteristiques;
	/// <summary>
	/// The nom.
	/// </summary>
	protected string _nom;
	/// <summary>
	/// The description.
	/// </summary>
	protected string _description;


	//constructeur
	/// <summary>
	/// Initializes a new instance of the <see cref="Equipement"/> class.
	/// </summary>
	/// <param name="caracteristiques">Caracteristiques.</param>
	/// <param name="nom">Nom.</param>
	/// <param name="description">Description.</param>
	public Equipement(Caracteristiques caracteristiques, string nom, string description){


		//attention equipement herite de objet donc il faudra supprimer les attributs nom et description 
		//de cette classe et mettre dans le constructeur : public Equipement(Caracteristiques caracteristiques, string nom, string description) : base(nom,description){...}


		this._caracteristiques = caracteristiques;
		this._nom = nom;
		this._description = description;
	}

	//méthodes


	/// <summary>
	/// Gets the caracteristiques.
	/// </summary>
	/// <value>The caracteristiques.</value>
	public Caracteristiques Caracteristiques {
		get {
			return this._caracteristiques;
		}
	}

	/// <summary>
	/// Gets the name of equipment.
	/// </summary>
	/// <value>The name</value>
	public string Nom {
		get {
			return this._nom;
		}
	}

	/// <summary>
	/// Gets the description.
	/// </summary>
	/// <value>The description.</value>
	public string Description {
		get {
			return this._description;
		}
	}
}
