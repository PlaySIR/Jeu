using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

/// <summary>
/// Joueur.
/// @author aquettier/Tha1n
/// </summary>
public sealed class Joueur : MonoBehaviour {

	//Attribut relatifs au Singleton
	private static Joueur 				m_instance = null;
	private static readonly object 		m_lockJoueur = new object();

	//Attributs relatifs au Joueur
	private String m_nom;
	private List<Statistiques> m_stat;
	private List<Objet> m_inventaire;
	private int m_monnaie;
	
	/// <summary>
	/// Initializes a new instance of the <see cref="Joueur"/> class.
	/// </summary>
	/// <param name="nomT">Nom t.</param>
	/// <param name="statT">Stat t.</param>
	/// <param name="inventaireT">Inventaire t.</param>
	/// <param name="monnaieT">Monnaie t.</param>
	Joueur(String nomT, List<Statistiques> statT, 
	       List<Objet> inventaireT, int monnaieT)
		: base()
	{
		this.m_nom 			= nomT;
		this.m_stat 		= statT;
		this.m_inventaire 	= inventaireT;
		this.m_monnaie 		= monnaieT;
	}

	#region Joueur Singleton
	
	/// <summary>
	/// Create the instance of Joueur.
	/// If Joueur is already creates, it returns the instance store in memory.
	/// </summary>
	/// <param name="nomT">Nom t.</param>
	/// <param name="statT">Stat t.</param>
	/// <param name="inventaireT">Inventaire t.</param>
	/// <param name="monnaieT">Monnaie t.</param>
	public Joueur Create(String nomT, List<Statistiques> statT, 
	                     List<Objet> inventaireT, int monnaieT)
	{
		lock (m_lockJoueur)
		{
			if (m_instance == null)
			{
				m_instance = new Joueur(nomT, statT, inventaireT, monnaieT);
			}
		}
		return m_instance;
	}

	#endregion

	#region Joueur Getter
	
	/// <summary>
	/// Gets the instance.
	/// </summary>
	/// <value>The instance. Instance can be null</value>
	public Joueur Instance {
		get {				
			return m_instance;
		}
	}

	/// <summary>
	/// Gets a value indicating whether this <see cref="Joueur"/> is instanciated.
	/// </summary>
	/// <value><c>true</c> if instanciated; otherwise, <c>false</c>.</value>
	public bool Instanciated {
		get {
			if (m_instance == null)
				return false;
			return true;
		}
	}

	/// <summary>
	/// Gets the nom.
	/// </summary>
	/// <value>The nom.</value>
	public String Nom {
		get {
			return m_nom;
		}
	}

	/// <summary>
	/// Gets the stat.
	/// </summary>
	/// <value>The stat.</value>
	public List<Statistiques> Stat {
		get {
			return m_stat;
		}
	}

	/// <summary>
	/// Gets the inventaire.
	/// </summary>
	/// <value>The inventaire.</value>
	public List<Objet> Inventaire {
		get {
			return m_inventaire;
		}
	}

	/// <summary>
	/// Gets the monnaie.
	/// </summary>
	/// <value>The monnaie.</value>
	public int Monnaie {
		get {
			return m_monnaie;
		}
	}
#endregion

}
