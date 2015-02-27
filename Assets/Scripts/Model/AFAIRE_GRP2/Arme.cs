using UnityEngine;
using System.Collections;

public class Arme : Equipement {
	/// <summary>
	/// The _attaque.
	/// </summary>
	private Attaque _attaque;

	//constructeur
	/// <summary>
	/// Initializes a new instance of the <see cref="Arme"/> class.
	/// </summary>
	/// <param name="attack">Attack.</param>
	public Arme (Attaque attack, Caracteristiques caracteristiques, string nom, string description):base(caracteristiques, nom, description){

		this._attaque = attack;
	}




	/// <summary>
	/// Gets the attaque.
	/// </summary>
	/// <value>The attaque.</value>
	public Attaque Attaque{
		get{
			return this._attaque;
		}
	}
	
}