using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Team : MonoBehaviour {

	/// <summary>
	/// The personnages.
	/// </summary>
    private Dictionary<string, Personnage> 	personnages;
	/// <summary>
	/// The ecole.
	/// </summary>
	private Ecole							ecole;

	/// <summary>
	/// Initializes a new instance of the <see cref="Team"/> class.
	/// </summary>
	/// <param name="ecoleT">Object of type <c>Ecole</c>.</param>
	public Team(Ecole ecoleT)
		: base()
	{
		this.personnages 		= new Dictionary<string, Personnage>();
		this.ecole 				= ecoleT;
	}

#region Team Methods
	/// <summary>
	/// Ajouts the an object of type <c>Personnage</c>.
	/// </summary>
	/// <param name="p">P, the object of class <c>Personnage</c>.</param>
	public void ajoutPersonnage(Personnage p)
	{
		//Ajout seulement si le personnage est de la meme école/camp que nous
		if (p.getEcole () == this.ecole)
			this.personnages.Add(p.nom, p);
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
		return this.personnages.Remove(p.nom);
	}

	/// <summary>
	/// Clear this instance.
	/// </summary>
	public void clear()
	{
		this.personnages.Clear ();
	}

#endregion
#region Team Getters

	/// <summary>
	/// Gets the personnage by his name.
	/// </summary>
	/// <returns>The personnage by name.</returns>
	/// <param name="namePerso">Name perso.</param>
	public Personnage getPersonnageByName(string namePerso)
	{
		Personnage temp = null;

		this.personnages.TryGetValue (namePerso, out temp);

		return temp;
	}

	/// <summary>
	/// Gets the enumerateur.
	/// </summary>
	/// <returns>The enumerateur.</returns>
	public Dictionary<string, Personnage>.Enumerator getEnumerateur()
	{
		return this.personnages.GetEnumerator;
	}

	/// <summary>
	/// Gets the clés.
	/// </summary>
	/// <returns>The clés.</returns>
	public Dictionary<string, Personnage>.KeyCollection getClés()
	{
		return this.personnages.Keys;
	}

#endregion
}
