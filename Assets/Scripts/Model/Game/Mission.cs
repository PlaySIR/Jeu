using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Combat_NS;



///<summary>
///@Author : Anne-Claire
///</summary>
public class Mission : MonoBehaviour {

	//Attributs
    private List<GestionCombat> _combats;
	private int _actuel;
    private List<Objet> _recompenses;
	private bool _fini;
	private Monde _monde;


	/// <summary>
	/// Initializes a new instance of the <see cref="Mission"/> class.
	/// </summary>
	/// <param name="monde">Monde dans lequel se trouve la mission</param>
	/// <param name="combats">Liste de tous les combats de la mission.</param>
	/// <param name="recompenses">Liste des récompenses disponibles.</param>
	/// <param name="fait">Si <c>vrai</c> la mission est déjà faite : pas d'objets rares.</param>
	public Mission (Monde monde, List<GestionCombat> combat, List<Objet> recompenses, bool fait){
		this._recompenses = recompenses;
		this._combats = combat;
		this._actuel = 0;
		this._fini = fait;
		this._monde = monde;
	}


	//Getters
	public List<GestionCombat> Combats { get { return this._combats; } }
	public List<Objet> Recompenses { get { return this._recompenses; } }
	public int Actuel { get { return this._actuel; } }
	public Monde Monde { get { return this._monde; } }
	public bool DejaFait { get { return this._fini; } }


	/// <summary>
	/// A appeler quand le combat se termine.
	/// </summary>
	/// <param name="actuel">Combat actuel.</param>
	/// <returns>Les récompenses du combat.</returns>
	public List<Objet> CombatFini (GestionCombat actuel){

		//On génère la récompense du combat
		List<Objet> butin = GenerateurRecompenses(1,3, !_fini);

		//On regarde s'il reste des combats à effectuer
		++this._actuel;
		bool fini = true;
		for (int i=0; i<this._combats.Count; ++i) {
			if(this._actuel.Equals(i)){
				fini=false;
				break;
			}
		}

		//Si tous les combats sont finis on le signale
		if (fini) {
			this._fini = true;	
		}

		return butin;
	}


	/// <summary>
	/// Generateur de récompenses.
	/// </summary>
	/// <returns>Le butin.</returns>
	/// <param name="min">Minimum d'objets gagnés.</param>
	/// <param name="max">Maximum d'objets gagnés.</param>
	/// <param name="rare">Si <c>vrai</c> donne un objet rare en plus.</param>
	public List<Objet> GenerateurRecompenses (int min, int max, bool rare){
		List<Objet> objets = new List<Objet>();
		List<Objet> objRare = new List<Objet>();
		List<Objet> result = new List<Objet>();

		//On parcourt la liste pour savoir quels sont les objets lootés
		foreach (Objet courant in this._recompenses) {
			//On ajoute un objet de manière aléatoire
			if (Random.Range(0,1) <= courant.TauxDrop){
				objets.Add(courant);
			}
			//On ajoute un objet rare (taux de drop à 10% ou moins) dans une liste à part
			if (rare && courant.TauxDrop <= 0.1){
				objRare.Add(courant);
			}
		}

		//On ajoute un nombre de récompenses compris entre min et max
		int nb = Random.Range (min, max);
		for (int i=0; i<nb; i++) {
			//On cherche un objet aléatoire dans la liste objets pour l'ajouter au résultat
			int temp = Random.Range(0, objets.Count);
			result.Add(FindLoot(temp));
		}

		//On ajoute l'objet rare à la liste résultat
		if (rare) {
			result.Add(FindLoot(Random.Range(0, objRare.Count)));
		}

		return result;
	}


	/// <summary>
	/// Permet de chercher un objet à un indice i.
	/// </summary>
	/// <returns>The loot.</returns>
	/// <param name="indice">L'indice de l'objet à trouver.</param>
	/// <remarks>@prerequis : indice < list.count</remarks>
	private Objet FindLoot (int indice){
		int cpt = 0;
		foreach (Objet courant in this._recompenses) {
			//Si l'objet recherché correspond à l'objet courant
			if (indice.Equals(cpt)){
				return courant;
			}
			++cpt;
		}
		//Si le prérequis n'a pas été respecté
		return null;
	}


}
