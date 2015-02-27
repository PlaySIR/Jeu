using UnityEngine;
using System.Collections;

using Statut_NS;

public class Cellule : MonoBehaviour {
	/// <summary>
	/// The statut.
	/// </summary>
	private Statut 			statut;
	/// <summary>
	/// The coordonnee.
	/// </summary>
    private Coordonnee		coordonnee;
	/// <summary>
	/// The decor.
	/// </summary>
    private Decor			decor;
	/// <summary>
	/// The equipe appartenance.
	/// </summary>
    private Team			equipeAppartenance;

	/// <summary>
	/// Initializes a new instance of the <see cref="Cellule"/> class.
	/// </summary>
	/// <param name="statT">Temporary Statut.</param>
	/// <param name="coordT">Temporary Coordinate.</param>
	/// <param name="decT">Temporary Decor.</param>
	/// <param name="teamT">Temporary Team.</param>
	public Cellule(Statut statT, Coordonnee coordT, Decor decT, Team teamT)
		: base()
	{
		this.statut 				= statT;
		this.coordonnee 			= coordT;
		this.decor 					= decT;
		this.equipeAppartenance		= teamT;
	}

	/// <summary>
	/// Gets the statut.
	/// </summary>
	/// <value>The statut.</value>
	public Statut Statut {
		get {
			return statut;
		}
	}

#region Cellule Getters
	/// <summary>
	/// Gets the coordonnee.
	/// </summary>
	/// <value>The coordonnee.</value>
	public Coordonnee Coordonnee {
		get {
			return coordonnee;
		}
	}

	/// <summary>
	/// Gets the decor.
	/// </summary>
	/// <value>The decor.</value>
	public Decor Decor {
		get {
			return decor;
		}
	}

	/// <summary>
	/// Gets the equipe appartenance.
	/// </summary>
	/// <value>The equipe appartenance.</value>
	public Team EquipeAppartenance {
		get {
			return equipeAppartenance;
		}
	}

#endregion
#region Cellule Methods
	/// <summary>
	/// Determine if the <c>Cellule</c> is passable.
	/// </summary>
	/// <returns><c>true</c>, if franchissable was real, <c>false</c> otherwise.</returns>
    public bool estFranchissable()
    {
        return this.decor.estFranchissable();
    }

#endregion
}
