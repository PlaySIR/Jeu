using UnityEngine;
using System.Collections;

public class Inventaire : MonoBehaviour {

	static public class InventaireConstants
	{
		public readonly int INFINI = -1;
	}

	private List<Objet> _objets;
	private int _quantiteMax;

	public Inventaire(int quantiteMax = InventaireConstants.INFINI){
		_quantiteMax = quantiteMax;

		if (_quantiteMax == InventaireConstants.INFINI)
			_objets = new List<Objet> ();
		else
			_objets = new List<Objet> (quantiteMax);
	}

	public bool ajouter(Objet objet, int quantite){
		if (_quantiteMax == _objets.size ())
			return false;
		else {
			//TODO
			_objets.add(objet);
			return true;
		}
	}
}
