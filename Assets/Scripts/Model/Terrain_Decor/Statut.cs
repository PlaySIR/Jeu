using UnityEngine;
using System.Collections;

namespace Statut_NS
{

	static public class StatutConstants
	{
		/// <summary>
		/// The value of OFFENSIVE tile.
		/// </summary>
		public const uint OFFENSIF 	= 2;
		/// <summary>
		/// The value of DEFENSIVE tile.
		/// </summary>
		public const uint DEFENSIF 	= 1;
		/// <summary>
		/// The value of NEUTRAL tile.
		/// </summary>
		public const uint NEUTRE 	= 0;
	}

	public class Statut : MonoBehaviour {

		/// <summary>
		/// The statut.
		/// </summary>
	    private uint stat;
	    
		/// <summary>
		/// Initializes a new instance of the <see cref="Statut.Statut"/> class.
		/// </summary>
		/// <param name="statutT">Temporary Statut, set to neutral by default.</param>
		public Statut(uint statutT = StatutConstants.NEUTRE)
			: base()
		{
			this.statut = statutT;
		}

		/// <summary>
		/// Gets the statut.
		/// </summary>
		/// <value>The statut.</value>
		public uint Stat {
			get {
				return stat;
			}
		}
	}

}