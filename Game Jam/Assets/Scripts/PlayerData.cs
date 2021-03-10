using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[System.Serializable]
public class PlayerData
{
    public ulong counter;
    public ulong upgradeCost;
    public ulong increaseCount;
    public ulong xpValue;
    public ulong xpLevel;
    public ulong levelValue;
    public float xpBarValue;
    public ulong xpStaticValue;


    public PlayerData(GameScript gameScript)
    {
        counter = gameScript.counter;
        upgradeCost = gameScript.upgradeCost;
        increaseCount = gameScript.increaseCount;
        xpValue = gameScript.xpValue;
        xpLevel = gameScript.xpLevel;
        levelValue = gameScript.levelValue;
        xpBarValue = gameScript.xpBarValue;
        xpStaticValue = gameScript.xpStaticValue;
    }
}