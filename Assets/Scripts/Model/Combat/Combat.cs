using UnityEngine;
using System.Collections;
using System;

/// <summary>
/// Combat Namespace.
/// @author aquettier/Tha1n
/// </summary>
namespace Combat_NS
{
	/// <summary>
	/// Combat constants.
	/// @author aquettier/Tha1n
	/// </summary>
	static public class CombatConstants
	{
		/// <summary>
		/// The coef of an offensive tile.
		/// </summary>
		public const double COEF_OFF = 1.1;
		/// <summary>
		/// The coef of a deffensive tile.
		/// </summary>
		public const double COEF_DEFF = 1.1;
		/// <summary>
		/// The coef of a neutral tile.
		/// </summary>
		public const double COEF_NEUT = 1.0;
		/// <summary>
		/// The Nb Max TOUCHE COMMUNE.
		/// </summary>
		public const uint NB_MAX_TOUCHES_COMMUNES = 2;
	}

	/// <summary>
	/// Combat.
	/// @author aquettier/Tha1n
	/// </summary>
	public class Combat : MonoBehaviour {

		/// <summary>
		/// The attaquant.
		/// </summary>
	    private Personnage attaquant;
		/// <summary>
		/// The defenseur.
		/// </summary>
	    private Personnage defenseur;
		/// <summary>
		/// The zone combat.
		/// </summary>
	    private Cellule zoneCombat;
		/// <summary>
		/// The nb touches communes.
		/// </summary>
		private uint nbTouchesCommunes;

		/// <summary>
		/// Initializes a new instance of the <see cref="Combat"/> class.
		/// </summary>
		/// <param name="attaquantT">Attaquant t.</param>
		/// <param name="defenseurT">Defenseur t.</param>
		/// <param name="zoneCombatT">Zone combat t.</param>
		/// <param name="nbTouchesCommunes">Nb touches communes.</param>
		public Combat(Personnage attaquantT, Personnage defenseurT,
		              Cellule zoneCombatT, int nbTouchesCommunesT)
			: base()
		{
			this.attaquant = attaquantT;
			this.defenseur = defenseurT;
			this.zoneCombat = zoneCombatT;
			this.nbTouchesCommunes = nbTouchesCommunesT;
		}


		#region Combat Getters

		/// <summary>
		/// Gets the attaquant.
		/// </summary>
		/// <value>The attaquant.</value>
		public Personnage Attaquant {
			get {
				return attaquant;
			}
		}

		/// <summary>
		/// Gets the defenseur.
		/// </summary>
		/// <value>The defenseur.</value>
		public Personnage Defenseur {
			get {
				return defenseur;
			}
		}

		/// <summary>
		/// Gets the zone combat.
		/// </summary>
		/// <value>The zone combat.</value>
		public Cellule ZoneCombat {
			get {
				return zoneCombat;
			}
		}

		/// <summary>
		/// Gets the nb touches communes.
		/// </summary>
		/// <value>The nb touches communes.</value>
		public uint NbTouchesCommunes {
			get {
				return nbTouchesCommunes;
			}
		}


		#endregion
		
		#region Combat Methods
		
		/// <summary>
		/// Determines whether the specified <see cref="Combat_NS.Combat"/> is equal to the current <see cref="Combat_NS.Combat"/>.
		/// </summary>
		/// <param name="obj">The <see cref="Combat_NS.Combat"/> to compare with the current <see cref="Combat_NS.Combat"/>.</param>
		/// <returns><c>true</c> if the specified <see cref="Combat_NS.Combat"/> is equal to the current <see cref="Combat_NS.Combat"/>;
		/// otherwise, <c>false</c>.</returns>
		public bool Equals(Combat obj)
		{
			if (this.Attaquant.Equals(obj.Attaquant) &&
			    this.Defenseur.Equals(obj.Defenseur) &&
			    this.ZoneCombat.Equals(obj.ZoneCombat))
				return true;
			return false;
		}
		
		/// <summary>
		/// Do the combat.
		/// </summary>
		public void effectuerCombat()
		{
			//Init des coef multiplicateurs
			//(forcés à 1 par défaut)
			double coefAttaque = Statut_NS.StatutConstants.COEF_NEUT;
			double coefDefense = Statut_NS.StatutConstants.COEF_NEUT;
			
			double marqueurStressA = 1; //this.Attaquant.MarqueurStress;
			double marqueurConfA = 1; //this.Attaquant.MarqueurConf;
			
			double marqueurStressD = 1; //this.Defenseur.MarqueurStress;
			double marqueurConfD = 1; //this.Defenseur.MarqueurConf;

			//Si la case est une case de l'équipe de l'attaquant
			if (this.zoneCombat.EquipeAppartenance.Equals(this.Attaquant.Team))
			{
				//Si la case est une case offensive (la seule utile pour un attaquant)
				//On modifie le coefficient d'attaque
				Statut_NS.Statut tempStatut = Statut_NS.StatutConstants.OFFENSIF;
				if (this.ZoneCombat.Statut.Equals(tempStatut))
				{
					coefAttaque = CombatConstants.COEF_OFF;
				}
			}
			//Sinon si la case est une case de l'équipe du défenseur
			else if (this.zoneCombat.EquipeAppartenance.Equals(this.Defenseur.Team))
			{
					//Si la case est une case defensive (la seule utile pour un defenseur)
					//On modifie le coefficient de défense
					Statut_NS.Statut tempStatut = Statut_NS.StatutConstants.DEFENSIF;
					if (this.ZoneCombat.Statut.Equals(tempStatut))
					{
						coefDefense = CombatConstants.COEF_DEFF;
					}
			}

			//Calcul de la puissance d'attaque
			double attaque = (this.Attaquant.Force + sort.random(min,max)) 
				* coefAttaque * marqueurConfA * marqueurStressA;
			int coefAttCrit = this.NbTouchesCommunes - CombatConstants.NB_MAX_TOUCHES_COMMUNES;	//Compris entre 0 et -2
			coefAttCrit = Math.Abs(coefAttCrit);//Calcul de la valeur absolue
			double puissanceAttaque =  coefAttCrit * attaque;

			//Calcul de la défense
			double defense = (this.Defenseur.deff) * coefDefense * marqueurConfD * marqueurStressD;

			//Calcul des dégats effectifs
			double degats = puissanceAttaque - defense;
			if (degats < 0)
				degats = 0;

			//Diminution des PV du défenseur si il y a lieu
			this.Defenseur.PV -= degats;
		}
	#endregion
}
}
