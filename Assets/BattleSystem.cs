using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public enum BattleState { START, PLAYERTURN, ENEMYTURN, WON, LOST }

public class BattleSystem : MonoBehaviour
{
    public GameObject playerPrefab;
    public GameObject enemyPrefab;

    public Transform PlayerPosition;
    public Transform EnemyPosition;

    Unit playerUnit;
    Unit enemyUnit;

    public BattleState state;
    void Start()
    {
        state = BattleState.START;
        SetupBattle();
    }

    void SetupBattle()
    {
       GameObject playerGO = Instantiate(playerPrefab, PlayerPosition);
       playerUnit = playerGO.GetComponent<Unit>();

        GameObject enemyGO = Instantiate(enemyPrefab, EnemyPosition);
        enemyUnit = enemyGO.GetComponent<Unit>();

        //enemyUnit.unitName
    }
}
