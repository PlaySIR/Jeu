using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GestionCombat : MonoBehaviour {

	//Attributs
	private List<Personnage> _personnages;
	private Team _allie;
	private Team _ennemi;
	private Cellule [][] _map;

	/// <summary>
	/// Initializes a new instance of the <see cref="GestionCombat"/> class.
	/// </summary>
	/// <param name="perso">Liste de tous les personnages qui s'affrontent.</param>
	/// <param name="allie">Equipe Allié.</param>
	/// <param name="ennemi">Equipe Ennemi.</param>
	/// <param name="map">Map à générer.</param>
	public GestionCombat (List<Personnage> perso, Team allie, Team ennemi, Cellule [][] map){
		this._allie = allie;
		this._ennemi = ennemi;
		this._personnages = perso;
		this._map = map;
	}

}
