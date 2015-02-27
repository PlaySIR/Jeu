using UnityEngine;
using System.Collections;

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
	/// <returns>The statut.</returns>
	public Statut getStatut()
	{
		return this.statut;
	}

	/// <summary>
	/// Gets the coordonnee.
	/// </summary>
	/// <returns>The coordonnee.</returns>
	public Coordonnee getCoordonnee()
	{
		return this.coordonnee;
	}
	/// <summary>
	/// Gets the decor.
	/// </summary>
	/// <returns>The decor.</returns>
	public Decor getDecor()
	{
		return this.decor;
	}
	/// <summary>
	/// Gets the team.
	/// </summary>
	/// <returns>The team.</returns>
	public Team getTeam()
	{
		return this.equipeAppartenance;
	}

	/// <summary>
	/// Determine if the <c>Cellule</c> is passable.
	/// </summary>
	/// <returns><c>true</c>, if franchissable was real, <c>false</c> otherwise.</returns>
    public bool estFranchissable()
    {
        return this.decor.estFranchissable();
    }
}
