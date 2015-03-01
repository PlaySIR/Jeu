using UnityEngine;
using System.Collections;
using System.Collections.Generic;


///<summary>
///@Author : Anne-Claire
///</summary>
public class Mission : MonoBehaviour {

	//Attributs
    private Combat[] _combats;
	private int _actuel;
    private List<Objet> _recompenses;
	private bool _dejaFait;


	/// <summary>
	/// Initializes a new instance of the <see cref="Mission"/> class.
	/// </summary>
	/// <param name="combats">Tableau de tous les combats de la mission.</param>
	/// <param name="recompenses">Liste des récompenses disponibles.</param>
	/// <param name="fait">Si <c>vrai</c> la mission est déjà faite : pas d'objets rares.</param>
	public Mission (Combat[] combat, List<Objet> recompenses, bool fait){
		this._recompenses = recompenses;
		this._combats = combat;
		this._actuel = 0;
		this._dejaFait = fait;
	}


	//Getters et setters
	public Combat[] Combats { get { return this._combats; } }
	public List<Objet> Recompenses { get { return this._recompenses; } }
	public int Actuel { get { return this._actuel; } }


	/// <summary>
	/// A appeler quand le combat se termine.
	/// </summary>
	/// <param name="actuel">Combat actuel.</param>
	/// <returns>Les récompenses du combat.</returns>
	public List<Objet> CombatFini (Combat actuel){

		//On génère la récompense du combat
		List<Objet> butin = GenerateurRecompenses(1,3, !_dejaFait);

		//On regarde s'il reste des combats à effectuer
		++this._actuel;
		bool fini = true;
		for (int i=0; i<this.Combats.Length; ++i) {
			if(i == this._actuel){
				fini=false;
				break;
			}
		}

		//Si tous les combats sont finis on appelle la fonction "mission finie" de monde
		if (fini) {
			this._dejaFait = true;
			Monde.MissionFinie(this);
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
		//Nb d'objets gagnés
		int nb = Random (min, max);

		List<Objet> result;
		//On ajoute de manière aléatoire les récompenses
		for (int i; i<nb; i++) {
			result.Add(Random(this._recompenses));
		}

		//On ajoute l'objet rare si nécessaire
		if (rare) {
			result.Add(Random(this._recompenses.rare));
		}
	}


}
