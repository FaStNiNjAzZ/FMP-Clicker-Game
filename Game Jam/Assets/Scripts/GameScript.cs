using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScript : MonoBehaviour
{
    //---------------------------
    // Game Objects and Cheat Variables
    //---------------------------

    public Text counterText;
    public Text upgradeText;
    public Text increaseCountText;
    public Text nextLevelXPText;
    public Text levelText;
    public Text totalXPText;
    public Button multiplierButton;
    public Slider xpBar;
    public Slider cheatAutoSlider;

    public Text autoUpgradeButton1Text;
    public Text autoUpgrade1CostText;
    public Button autoUpgrade1Button;

    public Text autoUpgradeButton2Text;
    public Text autoUpgrade2CostText;
    public Button autoUpgrade2Button;

    public Text autoUpgradeButton3Text;
    public Text autoUpgrade3CostText;
    public Button autoUpgrade3Button;

    public Text autoUpgradeButton4Text;
    public Text autoUpgrade4CostText;
    public Button autoUpgrade4Button;

    public Text autoUpgradeButton5Text;
    public Text autoUpgrade5CostText;
    public Button autoUpgrade5Button;

    public Text autoUpgradeButton6Text;
    public Text autoUpgrade6CostText;
    public Button autoUpgrade6Button;

    public Text autoUpgradeButton7Text;
    public Text autoUpgrade7CostText;
    public Button autoUpgrade7Button;

    public Text autoUpgradeButton8Text;
    public Text autoUpgrade8CostText;
    public Button autoUpgrade8Button;

    public GameObject cheatCanvas;
    public GameObject upgradeCanvas;

    public InputField cheatInputField;
    public ulong cheatInputNumber = 1;

    //---------------------------
    // Varaibles for Other Stuff
    //---------------------------

    public ulong counter;
    public ulong increaseCount = 1;
    public ulong upgradeCost = 50;
    public ulong xpValue = 1;
    public ulong xpLevel = 100;
    public ulong levelValue = 1;
    public float xpBarValue;
    public ulong xpStaticValue;

    ulong max64IntValue = 18446744073709551615;

    //---------------------------
    // Variables for Auto Upgrades ONLY
    //---------------------------

    ulong autoUpgrade1Counter = 0;
    float autoUpgrade1CounterFloat;
    float auto1Value = 0.125f;
    ulong autoUpgrade1Cost = 125;

    ulong autoUpgrade2Counter = 0;
    float autoUpgrade2CounterFloat;
    float auto2Value = 0.25f;
    ulong autoUpgrade2Cost = 2500;

    ulong autoUpgrade3Counter = 0;
    float autoUpgrade3CounterFloat;
    float auto3Value = 0.375f;
    ulong autoUpgrade3Cost = 37500;

    ulong autoUpgrade4Counter = 0;
    float autoUpgrade4CounterFloat;
    float auto4Value = 0.5f;
    ulong autoUpgrade4Cost = 500000;

    ulong autoUpgrade5Counter = 0;
    float autoUpgrade5CounterFloat;
    float auto5Value = 0.625f;
    ulong autoUpgrade5Cost = 6250000;

    ulong autoUpgrade6Counter = 0;
    float autoUpgrade6CounterFloat;
    float auto6Value = 0.75f;
     ulong autoUpgrade6Cost = 75000000;

    ulong autoUpgrade7Counter = 0;
    float autoUpgrade7CounterFloat;
    float auto7Value = 0.875f;
    ulong autoUpgrade7Cost = 875000000;

    ulong autoUpgrade8Counter = 0;
    float autoUpgrade8CounterFloat;
    float auto8Value = 1f;
    ulong autoUpgrade8Cost = 10000000000;

    //---------------------------
    // Variables for Settings
    //---------------------------

    public GameObject scanLine;
    bool lDMButtonCheck = false;
    public Button buttonObject;
    public GameObject buttonOnLDM;
    public GameObject buttonOffLDM;

    public GameObject musicSource;
    bool musicButtonCheck = true;
    public GameObject buttonOnMusic;
    public GameObject buttonOffMusic;

    public GameObject settingsPanel;
    bool settingsCanvasExit = false;
    bool settingsCanvasEnter = false;



    // Start is called before the first frame update
    void Start()
    {
        settingsPanel.transform.position = new Vector4((1920 / 2), 1620, 0);
    }

    // Update is called once per frame
    void Update()
    {
        

        //---------------------------
        // Max Ulong Checker
        //---------------------------

        if (counter < 0)
        {
            counter = max64IntValue;
        }

        else if (counter > max64IntValue)
        {
            counter = max64IntValue;
        }

        //---------------------------
        // Text Updates for UI
        //---------------------------

        counterText.text = Convert.ToString(counter);
        upgradeText.text = Convert.ToString(upgradeCost);
        increaseCountText.text = Convert.ToString(increaseCount);
        nextLevelXPText.text = ("XP needed for next Level: " + Convert.ToString(xpLevel - xpValue));
        levelText.text = ("Level: " + Convert.ToString(levelValue));
        totalXPText.text = ("XP: " + Convert.ToString(xpValue));

        autoUpgradeButton1Text.text = Convert.ToString(autoUpgrade1Counter + " per second");
        autoUpgrade1CostText.text = Convert.ToString("Cost: " + autoUpgrade1Cost);

        autoUpgradeButton2Text.text = Convert.ToString(autoUpgrade2Counter + " per second");
        autoUpgrade2CostText.text = Convert.ToString("Cost: " + autoUpgrade2Cost);

        autoUpgradeButton3Text.text = Convert.ToString(autoUpgrade3Counter + " per second");
        autoUpgrade3CostText.text = Convert.ToString("Cost: " + autoUpgrade3Cost);

        autoUpgradeButton4Text.text = Convert.ToString(autoUpgrade4Counter + " per second");
        autoUpgrade4CostText.text = Convert.ToString("Cost: " + autoUpgrade4Cost);

        autoUpgradeButton5Text.text = Convert.ToString(autoUpgrade5Counter + " per second");
        autoUpgrade5CostText.text = Convert.ToString("Cost: " + autoUpgrade5Cost);

        autoUpgradeButton6Text.text = Convert.ToString(autoUpgrade6Counter + " per second");
        autoUpgrade6CostText.text = Convert.ToString("Cost: " + autoUpgrade6Cost);

        autoUpgradeButton7Text.text = Convert.ToString(autoUpgrade7Counter + " per second");
        autoUpgrade7CostText.text = Convert.ToString("Cost: " + autoUpgrade7Cost);

        autoUpgradeButton8Text.text = Convert.ToString(autoUpgrade8Counter + " per second");
        autoUpgrade8CostText.text = Convert.ToString("Cost: " + autoUpgrade8Cost);

        //---------------------------
        //Enable or Disable Upgrade Buttons
        //---------------------------

        if (counter < upgradeCost)
        {
            multiplierButton.interactable = false;
        }

        else if (counter >= upgradeCost)
        {
            multiplierButton.interactable = true;
        }

        //---------------------------

        if (counter < autoUpgrade1Cost)
        {
            autoUpgrade1Button.interactable = false;
        }

        else if (counter >= autoUpgrade1Cost)
        {
            autoUpgrade1Button.interactable = true;
        }

        //---------------------------

        if (counter < autoUpgrade2Cost)
        {
            autoUpgrade2Button.interactable = false;
        }

        else if (counter >= autoUpgrade2Cost)
        {
            autoUpgrade2Button.interactable = true;
        }

        //---------------------------

        if (counter < autoUpgrade3Cost)
        {
            autoUpgrade3Button.interactable = false;
        }

        else if (counter >= autoUpgrade3Cost)
        {
            autoUpgrade3Button.interactable = true;
        }

        //---------------------------

        if (counter < autoUpgrade4Cost)
        {
            autoUpgrade4Button.interactable = false;
        }

        else if (counter >= autoUpgrade4Cost)
        {
            autoUpgrade4Button.interactable = true;
        }

        //---------------------------

        if (counter < autoUpgrade5Cost)
        {
            autoUpgrade5Button.interactable = false;
        }

        else if (counter >= autoUpgrade5Cost)
        {
            autoUpgrade5Button.interactable = true;
        }

        //---------------------------

        if (counter < autoUpgrade6Cost)
        {
            autoUpgrade6Button.interactable = false;
        }

        else if (counter >= autoUpgrade6Cost)
        {
            autoUpgrade6Button.interactable = true;
        }

        //---------------------------

        if (counter < autoUpgrade7Cost)
        {
            autoUpgrade7Button.interactable = false;
        }

        else if (counter >= autoUpgrade7Cost)
        {
            autoUpgrade7Button.interactable = true;
        }

        //---------------------------

        if (counter < autoUpgrade8Cost)
        {
            autoUpgrade8Button.interactable = false;
        }

        else if (counter >= autoUpgrade8Cost)
        {
            autoUpgrade8Button.interactable = true;
        }

        //---------------------------
        // XP Bar Stuff
        //---------------------------

        xpBarValue = (Convert.ToSingle(xpValue - xpStaticValue) / Convert.ToSingle(xpLevel - xpStaticValue));
        xpBar.value = xpBarValue;

        if (xpValue >= xpLevel)
        {
            //xpBar.maxValue = ;
            xpStaticValue = xpValue;
            levelValue += 1;
            xpLevel *= 4;
        }

        //---------------------------
        // Auto Upgrade Stuff
        //---------------------------

        autoUpgrade1CounterFloat += Time.deltaTime;
        autoUpgrade2CounterFloat += Time.deltaTime;
        autoUpgrade3CounterFloat += Time.deltaTime;
        autoUpgrade4CounterFloat += Time.deltaTime;
        autoUpgrade5CounterFloat += Time.deltaTime;
        autoUpgrade6CounterFloat += Time.deltaTime;
        autoUpgrade7CounterFloat += Time.deltaTime;
        autoUpgrade8CounterFloat += Time.deltaTime;

        //auto1Value = cheatAutoSlider.value;

        if (autoUpgrade1CounterFloat >= auto1Value)
        {
            autoUpgrade1CounterFloat = 0;
            counter += autoUpgrade1Counter;
        }

        if (autoUpgrade2CounterFloat >= auto2Value)
        {
            autoUpgrade2CounterFloat = 0;
            counter += autoUpgrade2Counter;
        }

        if (autoUpgrade3CounterFloat >= auto3Value)
        {
            autoUpgrade3CounterFloat = 0;
            counter += autoUpgrade3Counter;
        }

        if (autoUpgrade4CounterFloat >= auto4Value)
        {
            autoUpgrade4CounterFloat = 0;
            counter += autoUpgrade4Counter;
        }

        if (autoUpgrade5CounterFloat >= auto5Value)
        {
            autoUpgrade5CounterFloat = 0;
            counter += autoUpgrade5Counter;
        }

        if (autoUpgrade6CounterFloat >= auto6Value)
        {
            autoUpgrade6CounterFloat = 0;
            counter += autoUpgrade6Counter;
        }

        if (autoUpgrade7CounterFloat >= auto7Value)
        {
            autoUpgrade7CounterFloat = 0;
            counter += autoUpgrade7Counter;
        }

        if (autoUpgrade8CounterFloat >= auto8Value)
        {
            autoUpgrade8CounterFloat = 0;
            counter += autoUpgrade8Counter;
        }




        if (settingsCanvasExit == true)
        {
            //settingsPanel.transform.position = new Vector4((1920 / 2), 1280, 0);
            if (settingsPanel.transform.position.y < 1620)
            {
                settingsPanel.transform.Translate(Vector3.up * Time.deltaTime * 2000);

            }

            else if (settingsPanel.transform.position.y >= 1620)
            {
                settingsCanvasExit = false;
                settingsPanel.transform.position = new Vector4((1920 / 2), 1620, 0);

            }

        }
        if (settingsCanvasEnter == true)
        {            
            //settingsPanel.transform.position = new Vector4((1920 / 2), 1280, 0);
            if (settingsPanel.transform.position.y > 540)
            {
                settingsPanel.transform.Translate(Vector3.down * Time.deltaTime * 2000);
            }

            else if (settingsPanel.transform.position.y <= 540)
            {
               settingsCanvasEnter = false;
               settingsPanel.transform.position = new Vector4((1920 / 2), 540, 0);
            }
        }
    }

    //---------------------------
    // Button Functions for Main Canvas
    //---------------------------

    public void ButtonClick()
    {
        if (counter < 0)
        {
            counter = max64IntValue;
        }

        else if (counter > max64IntValue)
        {
            counter = max64IntValue;
        }

        counter += increaseCount;
        xpValue += increaseCount;
    }

    public void UpgradeButton()
    {
        increaseCount = increaseCount * 2;
        counter = counter - upgradeCost;
        upgradeCost = upgradeCost * 3;
    }

    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
    }

    public void LoadGame()
    {
        PlayerData data = SaveSystem.LoadPlayer();

        counter = data.counter;
        upgradeCost = data.upgradeCost;
        increaseCount = data.increaseCount;
        xpValue = data.xpValue;
        xpLevel = data.xpLevel;
        levelValue = data.levelValue;
        xpBarValue = data.xpBarValue;
        xpStaticValue = data.xpStaticValue;
    }

    //---------------------------
    // Buttons for Auto Uprades Canvas
    //---------------------------

    public void PurchaseAutoUpgrade1()
    {
        if (autoUpgrade1Counter == 0)
        {
            autoUpgrade1Counter = 1;
        }

        else if (autoUpgrade1Counter != 0)
        {
            autoUpgrade1Counter *= 2;
        }

        autoUpgrade1Cost *= 3;
    }

    public void PurchaseAutoUpgrade2()
    {
        if (autoUpgrade2Counter == 0)
        {
            autoUpgrade2Counter = 1;
        }

        else if (autoUpgrade2Counter != 0)
        {
            autoUpgrade2Counter *= 4;
        }

        autoUpgrade2Cost *= 6;
    }

    public void PurchaseAutoUpgrade3()
    {
        if (autoUpgrade3Counter == 0)
        {
            autoUpgrade3Counter = 1;
        }

        else if (autoUpgrade3Counter != 0)
        {
            autoUpgrade3Counter *= 8;
        }

        autoUpgrade3Cost *= 12;
    }

    public void PurchaseAutoUpgrade4()
    {
        if (autoUpgrade4Counter == 0)
        {
            autoUpgrade4Counter = 1;
        }

        else if (autoUpgrade4Counter != 0)
        {
            autoUpgrade4Counter *= 16;
        }

        autoUpgrade4Cost *= 24;
    }

    public void PurchaseAutoUpgrade5()
    {
        if (autoUpgrade5Counter == 0)
        {
            autoUpgrade5Counter = 1;
        }

        else if (autoUpgrade5Counter != 0)
        {
            autoUpgrade5Counter *= 32;
        }

        autoUpgrade5Cost *= 48;
    }

    public void PurchaseAutoUpgrade6()
    {
        if (autoUpgrade6Counter == 0)
        {
            autoUpgrade6Counter = 1;
        }

        else if (autoUpgrade6Counter != 0)
        {
            autoUpgrade6Counter *= 64;
        }

        autoUpgrade6Cost *= 96;
    }

    public void PurchaseAutoUpgrade7()
    {
        if (autoUpgrade7Counter == 0)
        {
            autoUpgrade7Counter = 1;
        }

        else if (autoUpgrade7Counter != 0)
        {
            autoUpgrade7Counter *= 128;
        }

        autoUpgrade7Cost *= 172;
    }

    public void PurchaseAutoUpgrade8()
    {
        if (autoUpgrade8Counter == 0)
        {
            autoUpgrade8Counter = 1;
        }

        else if (autoUpgrade8Counter != 0)
        {
            autoUpgrade8Counter *= 256;
        }

        autoUpgrade8Cost *= 344;
    }

    //---------------------------
    // Buttons for Changing Canvases
    //---------------------------

    public void ExitCheatCanvas()
    {
        cheatCanvas.SetActive(false);
    }

    public void EnterCheatCanvas()
    {
        cheatCanvas.SetActive(true);
    }

    public void ExitUpgradeCanvas()
    {
        upgradeCanvas.SetActive(false);
    }

    public void EnterUpgradeCanvas()
    {
        upgradeCanvas.SetActive(true);
    }

    //---------------------------
    // Cheat Buttons
    //---------------------------

    public void CheatInputButton()
    {
        cheatInputNumber = ulong.Parse(cheatInputField.text);
        counter = cheatInputNumber;
    }

    //---------------------------
    // Other Buttons
    //---------------------------

    public void LDMButton()
    {
        if (lDMButtonCheck == false)
        {
            scanLine.SetActive(false);
            buttonOffLDM.SetActive(false);
            buttonOnLDM.SetActive(true);
            lDMButtonCheck = true;
        }

        else if (lDMButtonCheck == true)
        {
            scanLine.SetActive(true);
            buttonOnLDM.SetActive(false);
            buttonOffLDM.SetActive(true);
            lDMButtonCheck = false;
        }
    }

    public void MusicButton()
    {
        if (musicButtonCheck == false)
        {
            musicSource.SetActive(false);
            buttonOffMusic.SetActive(false);
            buttonOnMusic.SetActive(true);
            musicButtonCheck = true;
        }

        else if (musicButtonCheck == true)
        {
            musicSource.SetActive(true);
            buttonOnMusic.SetActive(false);
            buttonOffMusic.SetActive(true);
            musicButtonCheck = false;
        }
    }

    public void ExitSettings()
    {
        settingsCanvasExit = true;
        //settingsPanel.transform.position = new Vector4((1920 / 2), 1280, 0);
    }

    public void EnterSettings()
    {
        settingsCanvasEnter = true;
    }

    //---------------------------
    // Ease Functions
    //---------------------------

   
}
