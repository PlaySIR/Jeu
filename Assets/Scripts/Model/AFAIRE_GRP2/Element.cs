using UnityEngine;
using System.Collections;

public class Element : MonoBehaviour {

    private string nom;
    private Element resistance;
    private Element faiblesse;
    
    public static int TERRE, FEU, EAU, ELECTRIC, AIR;




	public Element(string nom, Element resistance, Element faiblesse){
		this.nom=nom;
		this.resistance=resistance;
		this.faiblesse=faiblesse;
	}




	/// <summary>
	/// Gets the nom.
	/// </summary>
	/// <returns>The nom.</returns>
	string getNom(){
		return this.nom;
	}

	/// <summary>
	/// Gets the element resistance.
	/// </summary>
	/// <returns>The resistance.</returns>
	Element getResistance(){
		return this.resistance;
	}

	/// <summary>
	/// Gets the element faiblesse.
	/// </summary>
	/// <returns>The faiblesse.</returns>
	Element getFaiblesse(){
		return this.faiblesse;
	}







}