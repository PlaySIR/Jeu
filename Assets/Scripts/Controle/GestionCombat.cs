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
	private uint _indexTour;

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

		//TODO trie listInitiative par ordre d'initiative : Fusion des deux Team
	}

	public void FinTour(){
		_persoCourant.DecrementerBuff() ;
		_persoCourant.IsMyTurn = false;
		_indexTour = (_indexTour+1) % _listInitiatiative.Count;

	}



}
