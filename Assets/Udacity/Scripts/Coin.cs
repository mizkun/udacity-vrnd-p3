using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
	public GameObject CoinPoofPrefab;

    public void OnCoinClicked() {
		Debug.Log ("Coin Clicked");
		Instantiate (CoinPoofPrefab, transform.position, Quaternion.Euler(-90, 0, 0));
		Destroy (this.gameObject);
    }

}
