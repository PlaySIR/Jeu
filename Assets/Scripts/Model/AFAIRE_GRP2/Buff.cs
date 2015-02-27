using UnityEngine;
using System.Collections;

//Author :Billel
/// <summary>
/// Buff.
/// </summary>
public class Buff : MonoBehaviour {

	/// <summary>
	/// The enchantement.
	/// </summary>
    private Enchantement 		_enchantement;
	/// <summary>
	/// The latence.
	/// </summary>
    private uint 				_latence;
	/// <summary>
	/// The duree.
	/// </summary>
    private uint 				_duree;


	/// <summary>
	/// Initializes a new instance of the <see cref="Buff"/> class.
	/// </summary>
	/// <param name="enchantement">Enchantement.</param>
	/// <param name="latence">Latence.</param>
	/// <param name="duree">Duree.</param>
	public Buff(Enchantement enchantement, uint latence, uint duree){
		this._enchantement=enchantement;
		this._latence=latence;
		this._duree=duree;
	}



	/// <summary>
	/// Gets the enchantement.
	/// </summary>
	/// <value>The enchantement.</value>
	public Enchantement Enchantement{
		get{
			return this._enchantement;
		}
	}

	/// <summary>
	/// Gets the latence.
	/// </summary>
	/// <value>The latence.</value>
	public uint Latence{
		get{
			return this._latence;
		}
	}

	/// <summary>
	/// Gets the duree.
	/// </summary>
	/// <value>The duree.</value>
	public uint Duree{
		get{
			return this._duree;
		}
	}

}
