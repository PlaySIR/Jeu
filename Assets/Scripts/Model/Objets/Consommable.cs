﻿using UnityEngine;
using System.Collections;


/// <summary>
/// @Autohor : Anne-Claire
/// </summary>
public class Consommable : Objet {
<<<<<<< HEAD
	
	//Attribut supplémentaire de l'héritage
	private Attaque _attaque;
	public Attaque Attaque { get { return this._attaque; } }
	
	
=======

	//Attribut supplémentaire de l'héritage
    private Attaque _attaque;
	public Attaque Attaque { get { return this._attaque; } }


>>>>>>> 80e9539b6b76b5280ba4af06c499831bf96c0811
	/// <summary>
	/// Initializes a new instance of the <see cref="Consommable"/> class.
	/// </summary>
	/// <param name="attaque">Attaque.</param>
	/// <param name="nom">Nom.</param>
	/// <param name="description">Description.</param>
	/// <param name="prix">Prix.</param>
	public Consommable (Attaque attaque, string nom, string description, int prix, float drop)
		: base(nom, description, prix, drop)
	{
		this._attaque = attaque;
	}
}
