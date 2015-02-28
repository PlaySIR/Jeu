using UnityEngine;
using System.Collections;

/// <summary>
/// Combat.
/// @author aquettier/Tha1n
/// </summary>
public class Combat : MonoBehaviour {

	/// <summary>
	/// The attaquant.
	/// </summary>
    private Personnage attaquant;
	/// <summary>
	/// The defenseur.
	/// </summary>
    private Personnage defenseur;
	/// <summary>
	/// The zone combat.
	/// </summary>
    private Cellule zoneCombat;

	/// <summary>
	/// Initializes a new instance of the <see cref="Combat"/> class.
	/// </summary>
	/// <param name="attaquantT">Attaquant t.</param>
	/// <param name="defenseurT">Defenseur t.</param>
	/// <param name="zoneCombatT">Zone combat t.</param>
	public Combat(Personnage attaquantT, Personnage defenseurT, Cellule zoneCombatT)
		: base()
	{
		this.attaquant = attaquantT;
		this.defenseur = defenseurT;
		this.zoneCombat = zoneCombatT;
	}


	#region Statut Getters

	/// <summary>
	/// Gets the attaquant.
	/// </summary>
	/// <value>The attaquant.</value>
	public Personnage Attaquant {
		get {
			return attaquant;
		}
	}

	/// <summary>
	/// Gets the defenseur.
	/// </summary>
	/// <value>The defenseur.</value>
	public Personnage Defenseur {
		get {
			return defenseur;
		}
	}

	/// <summary>
	/// Gets the zone combat.
	/// </summary>
	/// <value>The zone combat.</value>
	public Cellule ZoneCombat {
		get {
			return zoneCombat;
		}
	}
	#endregion
	
	#region Statut Methods

	void effectuerCombat()
	{

	}

	#endregion
}
