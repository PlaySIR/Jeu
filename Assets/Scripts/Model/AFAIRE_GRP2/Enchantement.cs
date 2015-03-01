using UnityEngine;
using System.Collections;


//Author : Billel

/// <summary>
/// Enchantement.
/// </summary>
public class Enchantement : Effets {

	/// <summary>
	/// The _latence.
	/// </summary>
	private uint 			_latence;
	/// <summary>
	/// The _duree.
	/// </summary>
    private uint 			_duree;
	/// <summary>
	/// The _est temporaire.
	/// </summary>
    private bool			_estTemporaire;
	


	/// <summary>
	/// Initializes a new instance of the <see cref="Enchantement"/> class.
	/// </summary>
	/// author : Billel
	/// <param name="max">Max.</param>
	/// <param name="min">Minimum.</param>
	/// <param name="latence">Latence.</param>
	/// <param name="duree">Duree.</param>
	/// <param name="estTemporaire">If set to <c>true</c> est temporaire.</param>
	public Enchantement(uint max, uint min, uint latence, uint duree, bool estTemporaire):base(max, min){
		this._latence=latence;
		this._duree=duree;
		this._estTemporaire=estTemporaire;
	}



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

	/// <summary>
	/// Gets a value indicating whether this <see cref="Enchantement"/> is temporary.
	/// </summary>
	/// <value><c>true</c> if is temporaire; otherwise, <c>false</c>.</value>
	public bool EstTemporaire{
		get{
			return this._estTemporaire;
		}
	}
    
	/// <summary>
	/// Gets a new the buff.
	/// </summary>
	/// <returns>A new buff.</returns>
	public Buff getBuff(){
		return new Buff(this,Latence,Duree);
   }


	

}
