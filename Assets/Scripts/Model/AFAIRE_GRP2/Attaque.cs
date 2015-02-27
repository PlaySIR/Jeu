using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Attaque : MonoBehaviour {

	/// <summary>
	/// The nom.
	/// </summary>
    private string 				_nom;
	/// <summary>
	/// The description.
	/// </summary>
    private string			 	_description;

	/// <summary>
	/// List of the effets.
	/// </summary>
    private List<Effets> 		_effets;

	/// <summary>
	/// List of the effets critiques.
	/// </summary>
    private List<Effets> 		_effetsCritiques;

	/// <summary>
	/// the cooldown.
	/// </summary>
	///<description>The necessery time to re-use the attack</description> 
    private int			 		_cooldown;
		
	/// <summary>
	/// The _element.
	/// </summary>
    private Element				 _element;



	/// <summary>
	/// Initializes a new instance of the <see cref="Attaque"/> class.
	/// </summary>
	/// <param name="nom">Nom.</param>
	/// <param name="description">Description.</param>
	/// <param name="effets">Effets.</param>
	/// <param name="effetsCritiques">Effets critiques.</param>
	/// <param name="cooldown">Cooldown.</param>
	/// <param name="element">Element.</param>
	public Attaque(string nom, string description, List<Effets> effets, 
	               List<Effets> effetsCritiques, int cooldown, Element element){

		this._nom=nom;
		this._description=description;
		this._effets=effets;
		this._effetsCritiques=effetsCritiques;
		this._cooldown=cooldown;
		this._element=element;
	}




	/// <summary>
	/// Gets the nom.
	/// </summary>
	/// <returns>The nom.</returns>
	string Nom{
		get{
			return this._nom;
		}
	}

	/// <summary>
	/// Gets the description.
	/// </summary>
	/// <returns>The description.</returns>
	string Description{
		get{
			return this._description;
		}
	}

	/// <summary>
	/// Gets the element.
	/// </summary>
	/// <returns>The element.</returns>
	Element Element{
		get{
			return this._element;
		}
	}

	/// <summary>
	/// Gets the cooldown.
	/// </summary>
	/// <returns>The cooldown.</returns>
	int Cooldown{
		get{
			return this._cooldown;
		}
	}











}