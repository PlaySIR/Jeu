using UnityEngine;
using System.Collections;

public class Coordonnee : MonoBehaviour {

    private int xMin;
    private int yMin;
	private int padding;

	/// <summary>
	/// Initializes a new instance of the <see cref="Coordonnee"/> class.
	/// </summary>
	/// <param name="xT">Low X temporary.</param>
	/// <param name="yT">Low Y temporary.</param>
	/// <param name="paddingT">Padding temporary.</param>
	public Coordonnee(int xT, int yT, int paddingT)
	{
		this.xMin = xT;
		this.yMin = yT;

		this.padding = paddingT;
	}

	/// <summary>
	/// Gets the X minimum.
	/// </summary>
	/// <returns>The X minimum.</returns>
	public int getXMin()
	{
		return this.xMin;
	}

	/// <summary>
	/// Gets the X max.
	/// </summary>
	/// <returns>The X max.</returns>
	public int getXMax()
	{
		return this.xMin + this.padding;
	}

	/// <summary>
	/// Gets the Y minimum.
	/// </summary>
	/// <returns>The Y minimum.</returns>
	public int getYMin()
	{
		return this.yMin;
	}

	/// <summary>
	/// Gets the Y max.
	/// </summary>
	/// <returns>The Y max.</returns>
	public int getYMax()
	{
		return this.yMin + this.padding;
	}
}
