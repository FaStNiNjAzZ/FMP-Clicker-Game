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

    public ulong autoUpgrade1Counter;
    public ulong autoUpgrade1Cost;
    public ulong autoUpgrade2Counter;
    public ulong autoUpgrade2Cost;
    public ulong autoUpgrade3Counter;
    public ulong autoUpgrade3Cost;
    public ulong autoUpgrade4Counter;
    public ulong autoUpgrade4Cost;
    public ulong autoUpgrade5Counter;
    public ulong autoUpgrade5Cost;
    public ulong autoUpgrade6Counter;
    public ulong autoUpgrade6Cost;
    public ulong autoUpgrade7Counter;
    public ulong autoUpgrade7Cost;
    public ulong autoUpgrade8Counter;
    public ulong autoUpgrade8Cost;



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

        autoUpgrade1Counter = gameScript.autoUpgrade1Counter;
        autoUpgrade1Cost = gameScript.autoUpgrade1Cost;

        autoUpgrade2Counter = gameScript.autoUpgrade2Counter;
        autoUpgrade2Cost = gameScript.autoUpgrade2Cost;

        autoUpgrade3Counter = gameScript.autoUpgrade3Counter;
        autoUpgrade3Cost = gameScript.autoUpgrade3Cost;

        autoUpgrade4Counter = gameScript.autoUpgrade4Counter;
        autoUpgrade4Cost = gameScript.autoUpgrade4Cost;

        autoUpgrade5Counter = gameScript.autoUpgrade5Counter;
        autoUpgrade5Cost = gameScript.autoUpgrade5Cost;

        autoUpgrade6Counter = gameScript.autoUpgrade6Counter;
        autoUpgrade6Cost = gameScript.autoUpgrade6Cost;

        autoUpgrade7Counter = gameScript.autoUpgrade7Counter;
        autoUpgrade7Cost = gameScript.autoUpgrade7Cost;

        autoUpgrade8Counter = gameScript.autoUpgrade8Counter;
        autoUpgrade8Cost = gameScript.autoUpgrade8Cost;
    }
}