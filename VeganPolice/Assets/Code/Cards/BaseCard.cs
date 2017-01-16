using UnityEngine;
using System.Collections;

public abstract class BaseCard : Object {
	public enum CardTypes
	{
		Movement, Attack, Block	
	};
		
	public string cardName;
	public string cardText;
	public CardTypes type; 
	public abstract void action (BoardModel board, PlayerModel player, GameObject boardGO, GameObject playerGO);
}
