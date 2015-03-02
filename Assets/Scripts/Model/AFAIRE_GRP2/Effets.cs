using UnityEngine;
using System.Collections;

//@Author :Billel

/// <summary>
/// Effets.
/// </summary>
public class Effets : MonoBehaviour {

	/// <summary>
	/// The max.
	/// </summary>
    private uint 			_max;
		/// <summary>
	/// The minimum.
	/// </summary>
    private uint 			_min;


	/// <summary>
	/// Initializes a new instance of the <see cref="Effets"/> class.
	/// </summary>
	/// <param name="max">Max.</param>
	/// <param name="min">Minimum.</param>
	public Effets(uint max, uint min){
		this._max=max;
		this._min=min;
	}


	/// <summary>
	/// Gets the effet max.
	/// </summary>
	/// <value>The effet max.</value>
   public uint EffetMax{
		get{
			return this._max;
		}
	}

	/// <summary>
	/// Gets the effet minimum.
	/// </summary>
	/// <value>The effet minimum.</value>
	public uint EffetMin{
		get{
			return this._min;
		}
	}

	/// <summary>
	/// Value of the attack through the effect.
	/// </summary>
	/// <returns>The attaque.</returns>
	public int AttaqueEffets(){
		return (int)Random.Range(EffetMin,EffetMax);
	}

}
