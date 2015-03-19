using UnityEngine;
using System.Collections;
using System.Collections.Generic;

//@Author : Billel


/// <summary>
/// Attaque.
/// </summary>
public class Attaque : MonoBehaviour {

	/// <summary>
	/// The _nom.
	/// </summary>
    private string 				_nom;
	/// <summary>
	/// The description.
	/// </summary>
    private string			 	_description;

	/// <summary>
	/// The effets.
	/// </summary>
    private List<Effets> 		_effets;

	/// <summary>
	/// The effets critiques.
	/// </summary>
    private List<Effets> 		_effetsCritiques;

	/// <summary>
	/// the cooldown.
	/// cooldown is the number of rounds before relaunching 
	/// the attack (by dfaut = 0)
	/// </summary>
	///<description>The necessery time to re-use the attack</description> 
    private int			 		_cooldown;
		
	/// <summary>
	/// The _element.
	/// </summary>
    private Element				 _element;

	/// <summary>
	/// The _portee.
	/// </summary>
	private uint 				_portee;


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
	               List<Effets> effetsCritiques, int cooldown, Element element, uint portee){

		this._nom=nom;
		this._description=description;
		this._effets=effets;
		this._effetsCritiques=effetsCritiques;
		this._cooldown=cooldown;
		this._element=element;
		this._portee=portee;
	}




	/// <summary>
	/// Gets the nom.
	/// </summary>
	/// <returns>The nom.</returns>
	public string Nom{
		get{
			return this._nom;
		}
	}

	/// <summary>
	/// Gets the description.
	/// </summary>
	/// <returns>The description.</returns>
	public string Description{
		get{
			return this._description;
		}
	}

	/// <summary>
	/// Gets the element.
	/// </summary>
	/// <returns>The element.</returns>
	public Element Element{
		get{
			return this._element;
		}
	}

	/// <summary>
	/// Gets the cooldown.
	/// </summary>
	/// <returns>The cooldown.</returns>
	public int Cooldown{
		get{
			return this._cooldown;
		}
	}

	/// <summary>
	/// Gets the effets.
	/// </summary>
	/// <value>The effets.</value>
	public List<Effets> Effets{
		get{
			return this._effets;
		}
	}

	/// <summary>
	/// Gets the effets critiques.
	/// </summary>
	/// <value>The effets critiques.</value>
	public List<Effets> EffetsCritiques{
		get{
			return this._effetsCritiques;
		}
	}

	/// <summary>
	/// Gets the portee of the Attack.
	/// </summary>
	/// <value>The portee.</value>
	public uint Portee{
		get{
			return this._portee;
		}
	}

	/// <summary>
	/// Sommes of the effets in the list.
	/// </summary>
	/// <returns>The effets.</returns>
	private uint SommeEffets(){
		uint somme=0;
		int nbelem=Effets.Count;

		for(int i=0; i<nbelem;i++){
			somme+=(uint)Random.Range(this.Effets[i].EffetMin, this.Effets[i].EffetMax);
		}
		return somme;
	}



	/// <summary>
	/// Value of the attack through the effect.
	/// </summary>
	/// <returns>The attaque.</returns>
	public uint AttaqueEffets(){
		return SommeEffets();
	}



}