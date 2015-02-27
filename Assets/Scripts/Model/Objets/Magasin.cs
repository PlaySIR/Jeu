using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// @Author: Steven Pescheteau
/// </summary>
public class Magasin : MonoBehaviour {

	#region Attributs
    private string _nom;
	public string Nom { get { return _nom;} }

    private Inventaire _inventaire;
	public Inventaire Inventaire{ get { return _inventaire; } }

	private double _tarifApplique;
	public double TarifApplique{ get { return _tarifApplique; } }
	#endregion

	/// <summary>
	/// Magasin contenant une liste d'objet à des prix plus ou moins alléchants
	/// </summary>
	/// <param name="nom">Nom.</param>
	/// <param name="inventaire">Inventaire.</param>
	/// <param name="tarifApplique">Tarif applique.</param>
	public Magasin(string nom, Inventaire inventaire, double tarifApplique)
	{
		this._nom = nom;
		this._inventaire = inventaire;
		this._tarifApplique = tarifApplique;
	}

    public void vendre(Objet objet) 
	{
		//TODO Player doit etre codé.
    }

	public boolean acheter(Objet objet)
	{
		//TODO Player doit etre codé.
	}
}
