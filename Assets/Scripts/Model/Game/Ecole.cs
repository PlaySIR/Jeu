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


	///<summary>
	/// Récupération du nom de l'école
	/// </summary>
	public string getNom { get { return this._nom; } }

	///<summary>
	/// Récupération de la description de l'école
	/// </summary>
	public string getDescription { get { return this._description; } }

	///<summary>
	/// Récupération de la liste de magasins
	/// </summary>
	public List<Magasin> getMagasins { get { return this._magasins; } }

	///<summary>
	/// Ajout d'un magasin à la liste
	/// </summary>
	/// <param name="mag">Magasin à ajouter à l'Ecole.</param> 
	public void setMag (Magasin mag) { set { this._magasins.Add (mag); } }


	//Notion d'appartenance à l'école ? -> permettrait de différencier alliés d'ennemis -> peut etre pas dans cette classe par contre

}
