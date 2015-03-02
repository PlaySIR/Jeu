using UnityEngine;
using System.Collections;

/// <summary>
/// Decor.
/// @author aquettier/Tha1n
/// </summary>
public class Decor : MonoBehaviour {

	/// <summary>
	/// The nom.
	/// </summary>
    private string 				nom;
	/// <summary>
	/// The description.
	/// </summary>
    private string 				description;
	/// <summary>
	/// The est franch.
	/// </summary>
	private readonly bool		estFranch;

	/// <summary>
	/// Initializes a new instance of the <see cref="Decor"/> class.
	/// </summary>
	/// <param name="nomT">Nom t.</param>
	/// <param name="descriptionT">Description t.</param>
	/// <param name="estFranchissableT">If set to <c>true</c> est franchissable t.</param>
	public Decor (string nomT, string descriptionT, bool estFranchissableT)
		: base()
	{
		this.nom = nomT;
		this.description = descriptionT;
		this.estFranch = estFranchissableT;
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="Decor"/> class.
	/// </summary>
	/// <param name="estFranchissableT">If set to <c>true</c> est franchissable t.</param>
	public Decor (bool estFranchissableT)
		: base()
	{
		this("NoName", "NoDescription", estFranchissableT);
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="Decor"/> class.
	/// estFranch is set to false by default
	/// </summary>
	public Decor ()
		: base()
	{
		this("NoName", "NoDescription", false);
	}

	#region Decor Getters

	/// <summary>
	/// Gets the nom.
	/// </summary>
	/// <value>The nom.</value>
	public string Nom {
		get {
			return nom;
		}
	}

	/// <summary>
	/// Gets the description.
	/// </summary>
	/// <value>The description.</value>
	public string Description {
		get {
			return description;
		}
	}

	/// <summary>
	/// Gets a value indicating whether this <see cref="Decor"/> est franch.
	/// </summary>
	/// <value><c>true</c> if est franch; otherwise, <c>false</c>.</value>
	private bool EstFranch {
		get {
			return estFranch;
		}
	}

	#endregion

	#region Decor Methods

	/// <summary>
	/// Ests the franchissable.
	/// </summary>
	/// <returns><c>true</c>, if franchissable was ested, <c>false</c> otherwise.</returns>
	public bool estFranchissable ()
	{
		return this.EstFranch;
	}

	/// <summary>
	/// Determines whether the specified <see cref="Cellule"/> is equal to the current <see cref="Decor"/>.
	/// </summary>
	/// <param name="obj">The <see cref="Cellule"/> to compare with the current <see cref="Decor"/>.</param>
	/// <returns><c>true</c> if the specified <see cref="Cellule"/> is equal to the current <see cref="Decor"/>; otherwise, <c>false</c>.</returns>
	public bool Equals(Decor obj)
	{
		if (this.Nom.Equals(obj.Nom) &&
		    this.Description.Equals(obj.Description) &&
		    this.estFranchissable().Equals(obj.estFranchissable()))
			return true;
		return false;
	}

	/// <summary>
	/// Gets the consommable.
	/// </summary>
	/// <returns>The consommable.
	/// <c>null</c> if the specified <see cref="Consommable"/> doesn't exist; otherwise, the object is returns.</returns>
	public abstract Consommable getConsommable()
	{
		return null;
	}

	#endregion
}



