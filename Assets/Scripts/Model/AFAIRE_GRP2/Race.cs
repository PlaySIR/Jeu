using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Race : MonoBehaviour {

	//attributs

	/// <summary>
	/// The nom.
	/// </summary>
    private string 			_nom;
	/// <summary>
	/// The history.
	/// </summary>
    private string 			_history;
	/// <summary>
	/// The attaques.
	/// </summary>
    private List<Attaque> 	_attaques;
	/// <summary>
	/// The caracteristiques.
	/// </summary>
    private Caracteristiques _caracteristiques;


	//-----------------


	//constructeur
	/// <summary>
	/// Initializes a new instance of the <see cref="Race"/> class.
	/// </summary>
	/// <param name="nom">Nom.</param>
	/// <param name="history">History.</param>
	/// <param name="attacks">Attacks.</param>
	/// <param name="carac">Carac.</param>
	public Race (string nom, string history, List<Attaque> attacks, Caracteristiques carac){
		this._nom = nom; this._history = history;
		this._attaques = attacks; this._caracteristiques = carac;

	}

	//-----------------


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
	/// Gets the histoire.
	/// </summary>
	/// <value>The histoire.</value>
	public string Histoire {
		get {
			return this._history;
		}
	}

	/// <summary>
	/// Gets the attaques.
	/// </summary>
	/// <value>The attaques.</value>
	public List<Attaque> Attaques {
		get {
			return this._attaques;
		}
	}

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
