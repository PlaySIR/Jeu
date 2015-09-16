using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GestionCombat : MonoBehaviour {

	//Attributs
	private List<Personnage> _listInitiatiative;
	private Team _equipe;
	private Team _ennemies;
	private Cellule [][] _map;
	private Personnage _persoCourant;
	private int _indexTour;

	/// <summary>
	/// Initializes a new instance of the <see cref="GestionCombat"/> class.
	/// </summary>
	/// <param name="perso">Liste de tous les personnages qui s'affrontent.</param>
	/// <param name="allie">Equipe Allié.</param>
	/// <param name="ennemi">Equipe Ennemi.</param>
	/// <param name="map">Map à générer.</param>
	public GestionCombat ( Team allies, Team ennemis, Cellule [][] map){
		this._equipe = allies;
		this._ennemies = ennemis;
		this._map = map;
		this._indexTour = 0;
		this._listInitiatiative = new List<Personnage>();
		//TODO Fusion des deux Team, puis trier listInitiative par ordre d'initiative

		this._persoCourant = this._listInitiatiative[this._indexTour];
	}

	public void FinTour(){
		_persoCourant.DecrementerBuff() ;
		_persoCourant.IsMyTurn = false;
		_indexTour = (_indexTour + 1) % _listInitiatiative.Count;
		_persoCourant = _listInitiatiative[_indexTour];
	}



}
