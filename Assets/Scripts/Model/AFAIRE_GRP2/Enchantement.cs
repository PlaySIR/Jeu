using UnityEngine;
using System.Collections;

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
	



	public Enchantement(uint max, uint min, uint latence, uint duree, bool estTemporaire):base(max, min){
		this._latence=latence;
		this._duree=duree;
		this._estTemporaire=estTemporaire;
	}
    
   public Buff getBuff(){
   return null;
   }





	// TODO
}
