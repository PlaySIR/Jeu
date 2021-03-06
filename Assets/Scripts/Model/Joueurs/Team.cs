﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Comparateur d'initiative pour des Personnage.
/// Comparaison effectué par ordre décroissant
/// @author aquettier/Tha1n
/// </summary>
public class ComparateurInitiative : Comparer<Personnage>
{
	public override int Compare(Personnage x, Personnage y)
	{
		//Mis à 0 de base: les deux initiatives sont égales
		int result = 0;

		if (x.Caracteristiques.Initiative < y.Caracteristiques.Initiative)
			result = 1;
		else if (x.Caracteristiques.Initiative > y.Caracteristiques.Initiative)
			result = -1;

		return result;
	}

}

/// <summary>
/// Team.
/// @author aquettier/Tha1n
/// </summary>
public class Team : MonoBehaviour {

	/// <summary>
	/// The personnages.
	/// </summary>
    private List<Personnage> 	_personnages;
	/// <summary>
	/// The ecole.
	/// </summary>
	private Ecole							_ecole;

	/// <summary>
	/// Initializes a new instance of the <see cref="Team"/> class.
	/// </summary>
	/// <param name="ecoleT">Object of type <c>Ecole</c>.</param>
	public Team(Ecole ecoleT)
		: base()
	{
		this._personnages 			= new List<Personnage>();
		this._ecole 				= ecoleT;
	}

#region Team Methods
	/// <summary>
	/// Ajouts the an object of type <c>Personnage</c>.
	/// </summary>
	/// <param name="p">P, the object of class <c>Personnage</c>.</param>
	public void ajoutPersonnage(Personnage p)
	{
		//Ajout seulement si le personnage est de la meme école/camp que nous
		if (p.Ecole == this._ecole)
			this._personnages.Add(p);

		this._personnages.Sort(new ComparateurInitiative());
	}

	/// <summary>
	/// Supps the personnage.
	/// </summary>
	/// <returns><c>true</c>, if personnage was supped, <c>false</c> otherwise.</returns>
	/// <param name="p">P, the <c>Personnage</c> that must be delete.</param>
	public bool suppPersonnage(Personnage p)
	{
		//True si la clé existe, false sinon
		//Suppression sécurisé
		return this._personnages.Remove(p); 
	}

	/// <summary>
	/// Clear this instance.
	/// </summary>
	public void clear()
	{
		this._personnages.Clear();
	}

	/// <summary>
	/// Determines whether the specified <see cref="Team"/> is equal to the current <see cref="Team"/>.
	/// </summary>
	/// <param name="obj">The <see cref="Team"/> to compare with the current <see cref="Team"/>.</param>
	/// <returns><c>true</c> if the specified <see cref="Team"/> is equal to the current <see cref="Team"/>; otherwise, <c>false</c>.</returns>
	public bool Equals(Team obj)
	{
		if (this.Personnages.Equals(obj._personnages) &&
		    this.Ecole.Equals(obj.Ecole))
			return true;
		return false;
	}

	/// <summary>
	/// Force to sort the team by initiative.
	/// </summary>
	public void sortTeamByInitiative()
	{
		this._personnages.Sort(new ComparateurInitiative());
	}

#endregion
#region Team Getters

	/// <summary>
	/// Gets the enumerateur.
	/// </summary>
	/// <returns>The enumerateur.</returns>
	public List<Personnage>.Enumerator getEnumerateur()
	{
		return this._personnages.GetEnumerator();
	}

	/// <summary>
	/// Gets the ecole.
	/// </summary>
	/// <value>The ecole.</value>
	public Ecole Ecole {
		get {
			return _ecole;
		}
	}

	private List<Personnage> Personnages {
		get {
			return _personnages;
		}
	}
#endregion
}
