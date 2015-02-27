using UnityEngine;
using System.Collections;

public class Element : MonoBehaviour {

	/// <summary>
	/// The nom.
	/// </summary>
    private string					 _nom;

	/// <summary>
	/// The resistance.
	/// </summary>
    private Element 			_resistance;

	/// <summary>
	/// The faiblesse.
	/// </summary>
    private Element 			_faiblesse;
    
	/// <summary>
	/// AIR < this < FEU.
	/// <description>The TERRE =0</description>
	/// </summary>
	public const uint TERRE = 0 ; 
	/// <summary>
	/// TERRE < this < EAU.
	/// </summary>
	/// <description> The FEU =1/description>

	public const uint FEU = 1 ;
	/// <summary>
	/// FEU < this < ELECRIC.
	/// <description> The EAU =2 </description>
	/// </summary>
	public const uint EAU = 2 ; 
	/// <summary>
	/// FEU < this < ELECTRIC.
	/// <description> The ELECTRIC =3 </description>
	/// </summary>
	public const uint ELECTRIC =3 ; 
	/// <summary>
	/// ELECTRIC < this < TERRE.
	/// <description>The AIR =4</description>
	/// </summary>
	public const uint AIR = 4;



	/// <summary>
	/// Initializes a new instance of the <see cref="Element"/> class.
	/// </summary>
	/// <param name="nom">Nom.</param>
	/// <param name="resistance">Resistance.</param>
	/// <param name="faiblesse">Faiblesse.</param>
	public Element(string nom, Element resistance, Element faiblesse){
		this._nom=nom;
		this._resistance=resistance;
		this._faiblesse=faiblesse;
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
	/// Gets the element resistance.
	/// </summary>
	/// <returns>The resistance.</returns>
	Element Resistance{
		get{
			return this._resistance;
		}
	}

	/// <summary>
	/// Gets the element faiblesse.
	/// </summary>
	/// <returns>The faiblesse.</returns>
	Element Faiblesse{
		get{
			return this._faiblesse;
		}
	}







}