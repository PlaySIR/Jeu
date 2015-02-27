using UnityEngine;
using System.Collections;

public class Caracteristiques : MonoBehaviour {
	
	private uint _vitalite;
	private uint _force;
	private uint _defense;
	private uint _initiative;
	private uint _pointMouvement;
	
	/// <summary>
	/// Initializes a new instance of the <see cref="Caracteristiques"/> class.
	/// </summary>
	/// <param name="vitalite">Vitalite.</param>
	/// <param name="force">Force.</param>
	/// <param name="defense">Defense.</param>
	/// <param name="initiative">Initiative.</param>
	/// <param name="pointMouvement">Point mouvement.</param>
	public Caracteristiques(uint vitalite, uint force, uint defense, uint initiative, uint pointMouvement){
		this._vitalite=vitalite;
		this._force=force;
		this._defense=defense;
		this._initiative=initiative;
		this._pointMouvement=force;
	}
	
	/// <summary>
	/// Gets the vitalite.
	/// </summary>
	/// <returns>The vitalite.</returns>
	uint Vitalite{
		get{
			return this._vitalite;
		}
	}
	
	/// <summary>
	/// Gets the force.
	/// </summary>
	/// <returns>The force.</returns>
	uint Force{
		get{
			return this._force;
		}
	}
	
	/// <summary>
	/// Gets the defense.
	/// </summary>
	/// <returns>The defense.</returns>
	uint Defense{
		get{
			return this._defense;
		}
	}
	
	/// <summary>
	/// Gets the initiative.
	/// </summary>
	/// <returns>The initiative.</returns>
	uint Initiative{
		get{
			return this._initiative;
		}
	}
	
	/// <summary>
	/// Gets the point mouvement.
	/// </summary>
	/// <returns>The point mouvement.</returns>
	uint PointMouvement{
		get{
			return this._pointMouvement;
		}
	}
	
	/// <summary>
	/// Adds the vitalite.
	/// </summary>
	/// <param name="rajout">Rajout.</param>
	void addVitalite(uint rajout){
		this._vitalite+=rajout;
	}
	
	/// <summary>
	/// Adds the force.
	/// </summary>
	/// <param name="rajout">Rajout.</param>
	void addForce(uint rajout){
		this._force+=rajout;
	}
	
	/// <summary>
	/// Adds the defense.
	/// </summary>
	/// <param name="rajout">Rajout.</param>
	void addDefense(uint rajout){
		this._defense+=rajout;
	}
	
	/// <summary>
	/// Adds the initiative.
	/// </summary>
	/// <param name="rajout">Rajout.</param>
	void addInitiative(uint rajout){
		this._initiative+=rajout;
	}
	
}