using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Magasin : MonoBehaviour {

    private string _nom;
	public string Nom {
		get { return _nom;}
	}

    private Inventaire _inventaire;
	public Inventaire Inventaire{
		get { return _inventaire; }
	}

	private double _tarifApplique;
	public double TarifApplique{
		get { return _tarifApplique; }
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="Magasin"/> class.
	/// </summary>
	/// <param name="nom">Nom.</param>
	/// <param name="objets">Objets.</param>
	public Magasin(string nom, Inventaire inventaire, double tarifApplique){
		this._nom = nom;
		this._inventaire = inventaire;
		this._tarifApplique = tarifApplique;
	}

    public Objet vendre() {
		//TODO
    }

	}
}
