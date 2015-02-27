using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Attaque : MonoBehaviour {

    private string nom;
    private string description;
    private List<Effets> effets;
    private List<Effets> effetsCritiques;
    //duree avant que le sort soit réutilisable
    private int cooldown;
    private Element element;


	/// <summary>
	/// Gets the nom.
	/// </summary>
	/// <returns>The nom.</returns>
	string getNom(){
		return this.nom;
	}

	/// <summary>
	/// Gets the description.
	/// </summary>
	/// <returns>The description.</returns>
	string getDescription(){
		return this.description;
	}

	/// <summary>
	/// Gets the element.
	/// </summary>
	/// <returns>The element.</returns>
	Element getElement(){
		return this.element;
	}

	/// <summary>
	/// Gets the cooldown.
	/// </summary>
	/// <returns>The cooldown.</returns>
	int getCooldown(){
		return this.cooldown;
	}











}