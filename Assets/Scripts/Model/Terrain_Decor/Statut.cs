using UnityEngine;
using System.Collections;

/// <summary>
/// Statut Namespace
/// @author aquettier/Tha1n
/// </summary>
namespace Statut_NS
{
	/// <summary>
	/// Statut constants.
	/// </summary>
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

	/// <summary>
	/// Statut.
	/// </summary>
	public class Statut : MonoBehaviour {

		/// <summary>
		/// The statut.
		/// </summary>
	    private uint stat;
	    
		/// <summary>
		/// Initializes a new instance of the <see cref="Statut.Statut"/> class.
		/// </summary>
		/// <param name="statutT">Temporary Statut, set to neutral by default.</param>
		public Statut(uint statutT)
			: base()
		{
			this.stat = statutT;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="Statut_NS.Statut"/> class.
		/// </summary>
		public Statut()
			: base()
		{
			this(StatutConstants.NEUTRE);
		}

		#region Statut Getters
		/// <summary>
		/// Gets the statut.
		/// </summary>
		/// <value>The statut.</value>
		public uint Stat {
			get {
				return stat;
			}
		}

		#endregion

		#region Statut Methods

		/// <summary>
		/// Determines whether the specified <see cref="Statut_NS.Statut"/> is equal to the current <see cref="Statut_NS.Statut"/>.
		/// </summary>
		/// <param name="obj">The <see cref="Statut_NS.Statut"/> to compare with the current <see cref="Statut_NS.Statut"/>.</param>
		/// <returns><c>true</c> if the specified <see cref="Statut_NS.Statut"/> is equal to the current
		/// <see cref="Statut_NS.Statut"/>; otherwise, <c>false</c>.</returns>
		public override bool Equals(Statut obj)
		{
			if (this.Stat.Equals(obj.Stat))
				return true;
			return false;
		}

		#endregion
	}

}