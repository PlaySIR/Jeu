using UnityEngine;
using System.Collections;

//Author :Billel

/// <summary>
/// Caracteristiques.
/// </summary>
public class Caracteristiques : MonoBehaviour {

	/// <summary>
	/// The _vitalite.
	/// </summary>
	private uint 			_vitalite;
	/// <summary>
	/// The _force.
	/// </summary>
	private uint			 _force;
	/// <summary>
	/// The _defense.
	/// </summary>
	private uint 			_defense;
	/// <summary>
	/// The _initiative.
	/// </summary>
	private uint 			_initiative;
	/// <summary>
	/// The _point mouvement.
	/// </summary>
	private uint			 _pointMouvement;
	
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
	/// Gets or sets the _vitalite.
	/// </summary>
	/// <value>The _vitalite.</value>
	public uint Vitalite {
		get {
			return _vitalite;
		}
		set {
			_vitalite = value;
		}
	}
	
	/// <summary>
	/// Gets the force.
	/// </summary>
	/// <returns>The force.</returns>
	public uint Force{
		get{
			return this._force;
		}
	}
	
	/// <summary>
	/// Gets the defense.
	/// </summary>
	/// <returns>The defense.</returns>
	public uint Defense{
		get{
			return this._defense;
		}
	}
	
	/// <summary>
	/// Gets the initiative.
	/// </summary>
	/// <returns>The initiative.</returns>
	public uint Initiative{
		get{
			return this._initiative;
		}
	}
	
	/// <summary>
	/// Gets the point mouvement.
	/// </summary>
	/// <returns>The point mouvement.</returns>
	public uint PointMouvement{
		get{
			return this._pointMouvement;
		}
	}
	
	/// <summary>
	/// Adds points to the vitalite.
	/// </summary>
	/// <param name="points">Points.</param>
	public void addVitalite(uint points){
		this._vitalite+=points;
	}
	
	/// <summary>
	/// Adds points to the force.
	/// </summary>
	/// <param name="points">Points.</param>
	public void addForce(uint points){
		this._force+=points;
	}
	
	/// <summary>
	/// Adds points to the defense.
	/// </summary>
	/// <param name="points">Points.</param>
	public void addDefense(uint points){
		this._defense+=points;
	}
	
	/// <summary>
	/// Adds points to the initiative.
	/// </summary>
	/// <param name="points">Points.</param>
	public void addInitiative(uint points){
		this._initiative+=points;
	}
	
}