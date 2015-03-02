using UnityEngine;
using System.Collections;

public class DecorInteractif : Decor {

    private Consommable consommable;

	/// <summary>
	/// Initializes a new instance of the <see cref="DecorInteractif"/> class.
	/// </summary>
	/// <remarks>Appel du constructeur par défaut de Decor</remarks>
	/// <param name="consoT">Conso t.</param>
	public DecorInteractif(Consommable consoT)
		: base()
	{
		this.consommable = consoT;
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="DecorInteractif"/> class.
	/// </summary>
	/// <param name="nomT">Nom t.</param>
	/// <param name="descriptionT">Description t.</param>
	/// <param name="estFranchissableT">If set to <c>true</c> est franchissable t.</param>
	/// <param name="consoT">Conso t.</param>
	public DecorInteractif(string nomT, string descriptionT,
	                       bool estFranchissableT, Consommable consoT)
		: base(nomT, descriptionT, estFranchissableT)
	{
		this.consommable = consoT;
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="DecorInteractif"/> class.
	/// </summary>
	/// <remarks>Appel du constructeur a 1 paramètre de Decor</remarks>
	/// <param name="estFranchissableT">If set to <c>true</c> est franchissable t.</param>
	/// <param name="consoT">Conso t.</param>
	public DecorInteractif(bool estFranchissableT, Consommable consoT)
		: base(estFranchissableT)
	{
		this.consommable = consoT;

	}

	#region DecorInteractif Getters

	private Consommable Consommable {
		get {
			return consommable;
		}
	}


	#endregion

	#region DecorInteractif Methods

	/// <summary>
	/// Gets the consommable.
	/// </summary>
	/// <returns>The consommable.</returns>
	public override Consommable getConsommable ()
	{
		return this.Consommable;
	}

//	public void interagir(Personnage personnage)
//	{
//		
//	}

	#endregion
}
