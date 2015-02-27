using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Magasin : MonoBehaviour {

    private string _nom;
	public string Nom {
		get { return _nom;}
	}

    private List<Objet> _objets;
	public List<Objet> Objets{
		get { return _objets; }
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="Magasin"/> class.
	/// </summary>
	/// <param name="nom">Nom.</param>
	/// <param name="objets">Objets.</param>
	public Magasin(string nom, List<Objet> objets){
		this._nom = nom;
		this._objets = objets;
	}

    public Objet vendre() {
		//TODO
    }

	}
}
