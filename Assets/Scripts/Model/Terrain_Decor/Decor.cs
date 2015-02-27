using UnityEngine;
using System.Collections;

public class Decor : MonoBehaviour {

    private string 		nom;
    private string 		description;
	private bool		estFranch;


	public bool estFranchissable ()
	{
		return this.estFranch;
	}
}



