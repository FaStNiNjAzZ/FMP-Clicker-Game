using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    public GameObject CreoSphere;
    public GameObject CreoCarnivores;
    public GameObject CreoOutlaw;
    public GameObject CreoIdolize;
    public GameObject CreoNeverMakeIt;
    public GameObject SamifyingNoraLastDance;

    public GameObject CreoSphereText;
    public GameObject CreoCarnivoresText;
    public GameObject CreoOutlawText;
    public GameObject CreoIdolizeText;
    public GameObject CreoNeverMakeItText;
    public GameObject SamifyingNoraLastDanceText;
    public GameObject RandomMusicText;

    int randomMusicPicker;
    int musicListInt = 0;

    void Update()
    {
        if (musicListInt <= -1)
        {
            musicListInt = 6;
        }

        else if (musicListInt >= 7)
        {
            musicListInt = 0;
        }

        switch (musicListInt)
        {
            case 0:
                CreoSphere.SetActive(true);
                CreoSphereText.SetActive(true);
                break;

            case 1:
                CreoCarnivores.SetActive(true);
                CreoCarnivoresText.SetActive(true);
                break;

            case 2:
                CreoOutlaw.SetActive(true);
                CreoOutlawText.SetActive(true);
                break;

            case 3:
                CreoIdolize.SetActive(true);
                CreoIdolizeText.SetActive(true);
                break;

            case 4:
                CreoNeverMakeIt.SetActive(true);
                CreoNeverMakeItText.SetActive(true);
                break;

            case 5:
                SamifyingNoraLastDance.SetActive(true);
                SamifyingNoraLastDanceText.SetActive(true);
                break;

            case 6:
                RandomMusicText.SetActive(true);
                break;
        }
    }


    void MusicButtonRight()
    {
        musicListInt =+ 1;
    }

    void MusicButtonLeft()
    {
        musicListInt =- 1;
    }

    void RandomMusicFunction()
    {
        musicListInt = Random.Range(0, 6);
    }

}
