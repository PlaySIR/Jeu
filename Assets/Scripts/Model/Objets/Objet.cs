﻿using UnityEngine;
using System.Collections;

/// <summary>
/// @Author: Steven Pescheteau
/// </summary>
public abstract class Objet : MonoBehaviour {
	
	#region Attributs
	private string _nom;
	public string Nom { get { return _nom; } }
	
	private string _description;
	public string Description { get { return _description; } }
	
	private int _prix;
	public int Prix { get { return _prix; } }
	#endregion
	
	/// <summary>
	/// Initializes a new instance of the <see cref="Objet"/> class.
	/// </summary>
	/// <param name="nom">Nom.</param>
	/// <param name="description">Description.</param>
	/// <param name="prix">Prix.</param>
	public Objet (string nom, string description, int prix){
		this._nom = nom;
		this._description = description;
		this._prix = prix;
	}
}