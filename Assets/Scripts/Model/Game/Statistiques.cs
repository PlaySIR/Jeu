using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// @Author : Anne-Claire
/// </summary>
public class Statistiques : MonoBehaviour {

	//Attributs
	private List<Monde> _mondes_deblockes;
	private List<Monde> _mondes_blockes;

	// + Niveau de difficulté ?

	/// <summary>
	/// Initializes a new instance of the <see cref="Statistiques"/> class.
	/// </summary>
	/// <param name="mondes">Liste de tous les mondes.</param>
	/// <param name="actuel">Monde actuel du joueur = là où il ets rendu dans le jeu.</param>
	public Statistiques (List<Monde> mondes, Monde actuel){

		bool blockes = false;

		foreach (Monde courant in mondes){ 
			//Les mondes sont accessibles jusqu'au monde actuel

			if (blockes){ this._mondes_blockes.Add(courant); }
			else { this._mondes_deblockes.Add(courant); }

			if (courant == actuel){
				//Lorsqu'on dépasse actuel, les mondes deviennent blockés
				blockes = true;
			}

		}
	}

	/// <summary>
	/// Est-ce que tel monde apparait comme disponible ?
	/// </summary>
	/// <returns><c>vrai</c>, si monde dispo, <c>faux</c> sinon.</returns>
	/// <param name="monde">Monde à comparer.</param>
	public bool MondeDisponible (Monde monde){
		foreach (Monde courant in _mondes_deblockes) {
			if (courant == monde){return true;}
		}
		return false;
	}




}
