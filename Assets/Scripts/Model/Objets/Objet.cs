﻿using UnityEngine;
using System.Collections;

public abstract class Objet : MonoBehaviour {

	private string _nom;
	public string Nom {
		get { return _nom; }
	}

    private string _description;
	public string Description {
		get {
			return _description;
		}
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="Objet"/> class.
	/// </summary>
	/// <param name="nom">Nom.</param>
	/// <param name="description">Description.</param>
	public Objet (string nom, string description){
		this._nom = nom;
		this._description = description;
	}
}
