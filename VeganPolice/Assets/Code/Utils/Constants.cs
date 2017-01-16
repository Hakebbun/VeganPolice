using UnityEngine;
using System.Collections;

public static class Constants {

	// Input codes
	public static string INPUT_EXECUTE_DECK = "ExecuteDeck";
	public static string INPUT_ADD_UP = "AddUp";
	public static string INPUT_ADD_DOWN = "AddDown";
	public static string INPUT_ADD_RIGHT = "AddRight";
	public static string INPUT_ADD_LEFT = "AddLeft";
	public static int LEFT_CLICK_CODE = 0;

	// TILE Setup info
	public static int MAX_NUM_TILES = 15;
	public static int MAX_NUM_TILE_COL = 5;
	public static int MAX_NUM_TILE_ROW = 3;
	public static int TILE_X_DIST = 2;
	public static int TILE_Y_DIST = -2;

	// Player setup info
	public static int PLAYER_ONE_START_X = 0;
	public static int PLAYER_ONE_START_Y = -2;
	public static int PLAYER_ONE_START_Z = -1;
	public static int PLAYER_ONE_CODE = 0;
	public static int PLAYER_ONE_START_ROW = 1;
	public static int PLAYER_ONE_START_COL = 0;

	public static int PLAYER_TWO_START_X = 8;
	public static int PLAYER_TWO_START_Y = -2;
	public static int PLAYER_TWO_START_Z = -1;
	public static int PLAYER_TWO_CODE = 1;
	public static int PLAYER_TWO_START_ROW = 1;
	public static int PLAYER_TWO_START_COL = 3;

	public static int MAX_NUM_PLAYERS = 2;
	public static int DECK_SIZE = 4;

	// Prefab Names
	public static string PREFAB_NAME_TILE = "Tile";
	public static string PREFAB_NAME_PLAYER = "Player";
	public static string PREFAB_NAME_CARD = "Card";

	// Card Types
	public static int CARD_TYPE_MOVEMENT = 0;
	public static int CARD_TYPE_ATTACK = 1;
	public static int CARD_TYPE_BLOCK = 2;


}
