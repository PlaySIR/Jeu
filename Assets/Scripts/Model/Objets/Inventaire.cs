using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// @Author: Steven Pescheteau
/// </summary>
public class Inventaire : MonoBehaviour {

	#region Attributs
	static public class InventaireConstants
	{
		public const int INFINI = -1;
	}

	private IDictionary<string, Stock> _objets;
	private int _capaciteMax;
	#endregion

	/// <summary>
	/// Inventaire contenant des objets de diverses quantités, de capacité limitée.
	/// </summary>
	/// <param name="capaciteMax">Capacité max.</param>
	public Inventaire(int capaciteMax)
	{
		_capaciteMax = capaciteMax;
		_objets = new Dictionary<string, Stock> (_capaciteMax);
	}

	/// <summary>
	/// Inventaire contenant des objets de diverses quantités, de capacité infini.
	/// </summary>
	public Inventaire()
	{
		_capaciteMax = InventaireConstants.INFINI;
		_objets = new Dictionary<string, Stock> ();
	}

	/// <summary>
	/// Ajouter the specified objet and quantite.
	/// </summary>
	/// <param name="objet">Objet.</param>
	/// <param name="quantite">Quantite. 1 par défaut.</param>
	public bool ajouter(Objet objet, int quantite)
	{
		if (_capaciteMax == _objets.Count )
			return false;

		Stock stock;
		if (_objets.TryGetValue(objet.Nom, out stock))	//TODO RAJOUT MOTS CLEF OUT DEMANDER PAR COMPILATEUR : BILLEL
			stock.ajouterQuantite(quantite);
		else 
			_objets.Add(objet.Nom, new Stock(objet, quantite));

		return true;

	}

	/// <summary>
	/// Retirer the specified objet and quantite.
	/// </summary>
	/// <param name="objet">Objet.</param>
	/// <param name="quantite">Quantite. 1 par défaut.</param>
	public bool retirer(Objet objet, int quantite)
	{
		Stock stock;
		if (! _objets.TryGetValue(objet.Nom, out stock)) //TODO RAJOUT MOTS CLEF OUT DEMANDER PAR COMPILATEUR : BILLEL
		    return false;

		if (stock.Quantite - quantite < 0)
			return false;

		if (stock.Quantite - quantite == 0)
			_objets.Remove (objet.Nom);
		else
			stock.retirerQuantite (quantite);

		return true;
	}

	#region Classe interne Stock
	private class Stock
	{
		private Objet _objet;
		public Objet Objet { get { return _objet;} }
		
		private int _quantite;
		public int Quantite { get { return _quantite; } set { _quantite = value; } }

		/// <summary>
		/// Stock composé d'un Objet et d'une quantité, utilisé par l'inventaire
		/// </summary>
		/// <param name="objet">Objet.</param>
		/// <param name="quantite">Quantite. 1 par défaut.</param>
		public Stock(Objet objet, int quantite)
		{
			this._objet = objet;
			this._quantite = quantite;
		}

		/// <summary>
		/// Ajoute la quantité du stock à celle actuelle
		/// </summary>
		/// <param name="quantite">Quantite. 1 par défaut.</param>
		public void ajouterQuantite(int quantite)
		{
			_quantite += quantite;
		}

		/// <summary>
		/// Retire la quantité du stock à celle actuelle
		/// </summary>
		/// <returns><c>true</c>, if quantite was retirered, <c>false</c> otherwise.</returns>
		/// <param name="quantite">Quantite. 1 par défaut.</param>
		public bool retirerQuantite(int quantite)
		{
			if (_quantite - quantite < 0)
				return false;
			_quantite -= quantite;
			return true;
		}
	}
	#endregion
}
