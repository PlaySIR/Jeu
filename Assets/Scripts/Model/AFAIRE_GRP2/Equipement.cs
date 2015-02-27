using UnityEngine;
using System.Collections;

public class Equipement : Objet {
	//hérite de Objet



	//attributs
	/// <summary>
	/// The _caracteristiques.
	/// </summary>
	private Caracteristiques _caracteristiques;


	//constructeur
	/// <summary>
	/// Initializes a new instance of the <see cref="Equipement"/> class.
	/// </summary>
	/// <param name="caracteristiques">Caracteristiques.</param>
	/// <param name="nom">Nom.</param>
	/// <param name="description">Description.</param>
	public Equipement(Caracteristiques caracteristiques, string nom, string description): base(nom, description){
		this._caracteristiques = caracteristiques;
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

}