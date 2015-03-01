using UnityEngine;
using System.Collections;
using System.Collections.Generic;

///<summary>
///@Author : Anne-Claire
///</summary>
public class Ecole : MonoBehaviour {

	//Attributs
    private string _nom;
    private string _description;
    private List<Magasin> _magasins;


	/// <summary>
	/// Initializes a new instance of the <see cref="Ecole"/> class.
	/// </summary>
	/// <param name="nom">Nom de l'Ecole.</param>
	/// <param name="description">Description de l'Ecole.</param>
	/// <param name="magasin">Liste des magasins disponibles dans l'école.</param> 
	public Ecole (string nom, string description, List<Magasin> magasin){
		this._nom = nom;
		this._description = description;
		this._magasins = magasin;
	}



	//Getters et setters

	public string Nom { get { return this._nom; } }
	public string Description { get { return this._description; } }
	public List<Magasin> Magasins { get { return this._magasins; } set { this._magasins.Add(value); } }



	//Notion d'appartenance à l'école ? -> permettrait de différencier alliés d'ennemis -> peut etre pas dans cette classe par contre

}
