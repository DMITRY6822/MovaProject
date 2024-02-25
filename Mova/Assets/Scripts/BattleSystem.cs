using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class BattleSystem : MonoBehaviour
{
    private enum BattleState
    {
        START,
        PLAYERTURN,
        ENEMYTURN,
        WON,
        LOST,
    }
    public TextMeshPro _dialogText;

    public BattleHUD _playerHUD;
    public BattleHUD _enemyHUD;

    [SerializeField] private GameObject _playerPrefab;
    [SerializeField] private GameObject _enemyPrefab;

    [SerializeField] private Transform _playerTransform;
    [SerializeField] private Transform _enemyTransform;

    private Unit _playerUnit;
    private Unit _enemyUnit;

    private GameObject _player;
    private GameObject _enemy;

    [SerializeField] private BattleState state;
    private void Start()
    {
        state = BattleState.START; 
    }

    private void SetUpBattle()
    {
        _player =  Instantiate(_playerPrefab, _playerTransform);
        _playerUnit = _player.GetComponent<Unit>();

        _enemy = Instantiate(_enemyPrefab, _enemyTransform);
        _enemyUnit = _player.GetComponent<Unit>();

        _dialogText.text = "Big dick" + _enemyUnit.unitName;

        _playerHUD.SetHUD(_playerUnit);
        _enemyHUD.SetHUD(_enemyUnit);
    }


}
