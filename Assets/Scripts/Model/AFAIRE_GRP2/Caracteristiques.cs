using UnityEngine;
using System.Collections;

public class Caracteristiques : MonoBehaviour {

	private uint vitalite;
    private uint force;
    private uint defense;
    private uint initiative;
    private uint pointMouvement;

		/// <summary>
	/// Initializes a new instance of the <see cref="Caracteristiques"/> class.
	/// </summary>
	/// <param name="vitalite">Vitalite.</param>
	/// <param name="force">Force.</param>
	/// <param name="defense">Defense.</param>
	/// <param name="initiative">Initiative.</param>
	/// <param name="pointMouvement">Point mouvement.</param>
	public Caracteristiques(uint vitalite, uint force, uint defense, uint initiative, uint pointMouvement){
		this.vitalite=vitalite;
		this.force=force;
		this.defense=defense;
		this.initiative=initiative;
		this.pointMouvement=force;
		}

	/// <summary>
	/// Gets the vitalite.
	/// </summary>
	/// <returns>The vitalite.</returns>
	uint getVitalite(){
		return this.vitalite;
	}

	/// <summary>
	/// Gets the force.
	/// </summary>
	/// <returns>The force.</returns>
	uint getForce(){
		return this.force;
	}

	/// <summary>
	/// Gets the defense.
	/// </summary>
	/// <returns>The defense.</returns>
	uint getDefense(){
		return this.defense;
	}

	/// <summary>
	/// Gets the initiative.
	/// </summary>
	/// <returns>The initiative.</returns>
	uint getInitiative(){
		return this.initiative;
	}

	/// <summary>
	/// Gets the point mouvement.
	/// </summary>
	/// <returns>The point mouvement.</returns>
	uint getPointMouvement(){
		return this.pointMouvement;
	}

	/// <summary>
	/// Adds the vitalite.
	/// </summary>
	/// <param name="rajout">Rajout.</param>
	void addVitalite(uint rajout){
		this.vitalite+=rajout;
	}

	/// <summary>
	/// Adds the force.
	/// </summary>
	/// <param name="rajout">Rajout.</param>
	void addForce(uint rajout){
		this.force+=rajout;
	}

	/// <summary>
	/// Adds the defense.
	/// </summary>
	/// <param name="rajout">Rajout.</param>
	void addDefense(uint rajout){
		this.defense+=rajout;
	}

	/// <summary>
	/// Adds the initiative.
	/// </summary>
	/// <param name="rajout">Rajout.</param>
	void addInitiative(uint rajout){
		this.initiative+=rajout;
	}

}