using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// @Author : Anne-Claire
/// </summary>
public class Univers : MonoBehaviour {

	//Attributs
	private List<Monde> _mondes_deblockes;
	private List<Monde> _mondes_blockes;
	private Monde _encours;

	// + Niveau de difficulté ?


	/// <summary>
	/// Initializes a new instance of the <see cref="Statistiques"/> class.
	/// </summary>
	/// <param name="deblockes">Deblockes.</param>
	/// <param name="blockes">Blockes.</param>
	/// <param name="encours">Encours.</param>
	public Univers(List<Monde> deblockes, List<Monde> blockes, Monde encours){
		this._mondes_deblockes=deblockes;
		this._mondes_blockes=blockes;
		this._encours=encours;
	}


	/// <summary>
	/// Initializes a new instance of the <see cref="Statistiques"/> class.
	/// </summary>
	/// <param name="mondes">Liste de tous les mondes.</param>
	/// <param name="actuel">Monde actuel du joueur = là où il est rendu dans le jeu.</param>
	public Univers (List<Monde> mondes, Monde actuel){

		this._encours = actuel;
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

	//Getters
	public List<Monde> MondesDeblockes { get { return this._mondes_deblockes; } }
	public List<Monde> MondesBlockes { get { return this._mondes_blockes; } }


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

	/// <summary>
	/// Deblocke un monde pour le joueur.
	/// </summary>
	/// <param name="deblocke">Monde qui vient d'etre déblocké.</param>
	public void Deblocke (Monde monde){
		this._mondes_deblockes.Add (monde);
		this._mondes_blockes.Remove (monde);
	}


	public void MondeTermine (Monde fini){
		this._encours = this._mondes_blockes[0]; //récupère le premier élément de la liste blockés
		this.Deblocke (this._encours);	//appel de la fonction déblocke
	}



}
