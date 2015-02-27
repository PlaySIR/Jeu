using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Mission : MonoBehaviour {

    private List<Combat> combats;
    private List<Objet> recompenses;

	public Mission(List<Combat> combats, List<Objet> recompenses){
		this.combats = combats;
		this.recompenses = recompenses;
	}


}
