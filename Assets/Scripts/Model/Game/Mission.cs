using UnityEngine;
using System.Collections;
using System.Collections.Generic;


///<summary>
///@Author : Anne-Claire
///</summary>
public class Mission : MonoBehaviour {

	//Attributs
    private List<Combat> _combats;
    private List<Objet> _recompenses;

	//Création d'une liste de combat "validé" ? Pour pouvoir les refaire sans influencer l'histoire


	/// <summary>
	/// Initializes a new instance of the <see cref="Mission"/> class.
	/// </summary>
	/// <param name="combats">Liste des combats qu'il reste à effectuer.</param>
	/// <param name="recompenses">Liste des récompenses disponibles.</param>
	public Mission (List<Combat> combats, List<Objet> recompenses){
		this._combats = combats;
		this._recompenses = recompenses;
	}

	///<summary>
	/// Récupération de la liste de combat pour remplir la mission.
	/// </summary>
	public List<Combat> getCombat { get { return this._combats; } }

	///<summary>
	/// Récupération du nom de l'école
	/// </summary>
	public List<Objet> getRecompenses { get { return this._recompenses; } }


	//Générer les récompenses à la fin d'un combat -> dans la classe combat ?


}
