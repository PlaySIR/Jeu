using UnityEngine;
using System.Collections;
using System.Collections.Generic;


/// <summary>
/// @Author : Anne-Claire
/// </summary>
public class Monde : MonoBehaviour {

	//Attributs
    private string _nom;
    private string _histoire;
	private bool _estDisponible; //monde blockés ou visibles ?
	private bool _estFini;		//monde fini ?
    private Mission[] _missions;
	private int _encours;		//numéro de la mission en cours, nécessaire ?
	private Ecole _ecole;

   // private List<Personnage> personnagesDisponibles; //Alliés ou PNJ ?
    private List<Objet> objetsDisponibles; //dépend de la difficulté ou du prix
    

	//Création d'une map constante (classe à part) contenant TOUS les objets qui existent (BDD ?) ainsi qu'un niveau de difficulté
	//L'idée serait qu'un monde soit associé a un niveau de difficulté : donne accès aux objets uniquement du meme niveau
	//Concept que l'on pourrait généraliser partout si le joueur possède dans ses stats non visibles ce niveau : permettrait d'adapter les magasins, etc


	/// <summary>
	/// Initializes a new instance of the <see cref="Monde"/> class.
	/// </summary>
	/// <param name="nom">Nom du monde.</param>
	/// <param name="histoire">Histoire du monde.</param>
	/// <param name="missions">Missions à effectuer sur le monde.</param>
	/// <param name="fini">Vaut <c>true<c/> si toutes les missions ont été effectuées</param>
	/// <remarks>1er constructeur : pas d'école sur le monde</remarks>
	public Monde (string nom, string histoire, Mission[] missions, bool fini){
		this._nom = nom;
		this._histoire = histoire;
		this._missions = missions;
		this._estFini = fini;
		this._ecole = null;

		//Opération pour savoir si le monde est disponible ou non
		this._estDisponible = Statistiques.MondeDisponible(this);

		//On initialise à la 1ère mission
		this._encours = 0;
	}


	/// <summary>
	/// Initializes a new instance of the <see cref="Monde"/> class.
	/// </summary>
	/// <param name="nom">Nom du monde.</param>
	/// <param name="histoire">Histoire du monde.</param>
	/// <param name="missions">Missions à effectuer sur le monde.</param>
	/// <param name="fini">Vaut <c>true<c/> si toutes les missions ont été effectuées</param>
	/// <param name="ecole">Ecole présente sur le monde</param> 
	public Monde (string nom, string histoire, Mission[] missions, bool fini, Ecole ecole){
		this._nom = nom;
		this._histoire = histoire;
		this._missions = missions;
		this._estFini = fini;
		this._ecole = ecole;
		
		//Opération pour savoir si le monde est disponible ou non
		this._estDisponible = Statistiques.MondeDisponible(this);
		
		//On initialise à la 1ère mission
		this._encours = 0;
	} 


	//Getters
	public string Nom { get { return this._nom;} }
	public string Histoire { get { return this._histoire; } }
	public Mission[] Missions { get { return this._missions; } }
	public bool Disponible { get { return this._estDisponible; } }
	public bool Fini { get { return this._estFini; } }
	public bool EnCours{ get { return this._encours; } }


	public List<Objet> MissionFinie (Mission terminee){
		//On incrémente la mission en cours
		this._encours++;

		//On génère les récompenses
		List<Objet> butin = Mission.GenerateurRecompenses (3, 5, true);

		//On vérifie si toutes les missions sont réalisées
		bool fini = true;
		for (int i=0; i<this.Missions.Length; ++i) {
			if(i == this._encours){
				fini=false;
				break;
			}
		}

		//Si toutes les missions sont finies on appelle la fonction "monde terminé" de stats
		if (fini) {
			this._estFini = true;
			Statistiques.MondeTermine(this);
		}

		return butin;
	}

	

}
