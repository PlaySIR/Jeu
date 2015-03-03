using UnityEngine;
using System.Collections;


/// <summary>
/// @Autohor : Anne-Claire
/// </summary>
public class Consommable : Objet {

	//Attribut supplémentaire de l'héritage
    private Attaque _attaque;
	public Attaque Attaque { get { return this._attaque; } }


	/// <summary>
	/// Initializes a new instance of the <see cref="Consommable"/> class.
	/// </summary>
	/// <param name="attaque">Attaque.</param>
	/// <param name="nom">Nom.</param>
	/// <param name="description">Description.</param>
	/// <param name="prix">Prix.</param>
	public Consommable (Attaque attaque, string nom, string description, string prix, float drop){
		this._attaque = attaque;
		this._nom = nom;
		this._description = description;
		this._prix = prix;
		this._tauxDrop = drop;
	}



}
