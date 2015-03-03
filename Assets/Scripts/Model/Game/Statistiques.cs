﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// @Author : Anne-Claire
/// </summary>
public class Statistiques : MonoBehaviour {

	//Attributs
	private List<Monde> _mondes_deblockes;
	private List<Monde> _mondes_blockes;
	private Monde _encours;

	// + Niveau de difficulté ?

	/// <summary>
	/// Initializes a new instance of the <see cref="Statistiques"/> class.
	/// </summary>
	/// <param name="mondes">Liste de tous les mondes.</param>
	/// <param name="actuel">Monde actuel du joueur = là où il est rendu dans le jeu.</param>
	public Statistiques (List<Monde> mondes, Monde actuel){

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
		this._encours = this._mondes_blockes[this._mondes_blockes.Count-1]; //récupère le 1er élement ? j'espère...  
		// Billel à rajouter [this._mondes_blockes.Count-1] pusique qu'on veut récupéré le dernier éléments de la liste
		this.Deblocke (this._encours);
	}




}
