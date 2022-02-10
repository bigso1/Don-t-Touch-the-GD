using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
   #region Singletone

   public static GameManager Instance;

   private void Awake()
   {
      Instance = this;
   }

   #endregion

   #region Variable

   public enum GameState
   {
      menu, inGame, dead
   }

   public GameState currentGameState;

   private void Start()
   {
      currentGameState = GameState.menu;
   }

   
   #endregion


}
