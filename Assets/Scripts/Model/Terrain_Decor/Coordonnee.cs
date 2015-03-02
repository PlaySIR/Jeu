using UnityEngine;
using System.Collections;

/// <summary>
/// Coordonnee.
/// @author aquettier/Tha1n
/// </summary>
public class Coordonnee : MonoBehaviour {

	/// <summary>
	/// The coordinate of x minimum.
	/// </summary>
    private int xMin;
	/// <summary>
	/// The coordinate of y minimum.
	/// </summary>
    private int yMin;
	/// <summary>
	/// The padding.
	/// </summary>
	private int padding;

	/// <summary>
	/// Initializes a new instance of the <see cref="Coordonnee"/> class.
	/// </summary>
	/// <param name="xT">Low X temporary.</param>
	/// <param name="yT">Low Y temporary.</param>
	/// <param name="paddingT">Padding temporary.</param>
	public Coordonnee(int xT, int yT, int paddingT)
		: base()
	{
		this.xMin = xT;
		this.yMin = yT;

		this.padding = paddingT;
	}

#region Coordonnee Getters
	/// <summary>
	/// Gets the X minimum.
	/// </summary>
	/// <value>The X minimum.</value>
	public int XMin {
		get {
			return xMin;
		}
	}
	
	/// <summary>
	/// Gets the X max.
	/// </summary>
	/// <value>The X max.</value>
	public int XMax	{
		get {
			return this.xMin + this.padding;
		}
	}

	/// <summary>
	/// Gets the Y minimum.
	/// </summary>
	/// <value>The Y minimum.</value>
	public int YMin {
		get {
			return yMin;
		}
	}

	/// <summary>
	/// Gets the Y max.
	/// </summary>
	/// <value>The Y max.</value>
	public int YMax	{
		get {
			return this.yMin + this.padding;
		}
	}

	/// <summary>
	/// Gets the padding.
	/// </summary>
	/// <value>The padding.</value>
	public int Padding {
		get {
			return padding;
		}
	}
#endregion

#region Coordonnee Methods

	/// <summary>
	/// Determines whether the specified <see cref="Coordonnee"/> is equal to the current <see cref="Coordonnee"/>.
	/// </summary>
	/// <param name="obj">The <see cref="Coordonnee"/> to compare with the current <see cref="Coordonnee"/>.</param>
	/// <returns><c>true</c> if the specified <see cref="Coordonnee"/> is equal to the current <see cref="Coordonnee"/>; otherwise, <c>false</c>.</returns>
	public override bool Equals(Coordonnee obj)
	{
		if (this.XMin.Equals(obj.XMin) &&
		    this.YMin.Equals(obj.YMin) &&
		    this.Padding.Equals(obj.Padding))
			return true;
		return false;
	}



#endregion
}
