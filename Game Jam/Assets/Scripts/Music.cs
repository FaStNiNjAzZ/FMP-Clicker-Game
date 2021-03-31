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

    float timer;
    int randomMusicPicker;
    int musicListInt = 0;
    int randMusicListInt = 0;

    void Start()
    {
        DeactivateMusic();
    }

    void Update()
    {

        timer += Time.deltaTime;

        Debug.Log(timer);

        Debug.Log(randMusicListInt);

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
                
                timer = 0;
                RandomMusicFunction();

                break;
        }
    }


    public void MusicButtonRight()
    {
        DeactivateMusic();
        musicListInt += +1;
    }

    public void MusicButtonLeft()
    {
        DeactivateMusic();
        musicListInt += -1;
    }

    void RandomMusicFunction()
    {
        switch (randMusicListInt)
        {
            case 0:
                if (timer < 240)
                {
                    CreoSphere.SetActive(true);
                    CreoSphereText.SetActive(true);
                }
                
                else if (timer >= 240)
                {
                    DeactivateMusic();
                    RandomMusicFunction();
                    randMusicListInt = Random.Range(0, 6);
                    timer = 0;
                }
                break;

            case 1:
                if (timer < 271)
                {
                    CreoCarnivores.SetActive(true);
                    CreoCarnivoresText.SetActive(true);
                }

                else if (timer >= 271)
                {
                    DeactivateMusic();
                    RandomMusicFunction();
                    randMusicListInt = Random.Range(0, 6);
                    timer = 0;
                }
                break;

            case 2:
                if (timer < 303)
                {
                    CreoOutlaw.SetActive(true);
                    CreoOutlawText.SetActive(true);
                }

                else if (timer >= 303)
                {
                    DeactivateMusic();
                    RandomMusicFunction();
                    randMusicListInt = Random.Range(0, 6);
                    timer = 0;
                }
                break;

            case 3:
                if (timer < 237)
                {
                    CreoIdolize.SetActive(true);
                    CreoIdolizeText.SetActive(true);
                }

                else if (timer >= 237)
                {
                    DeactivateMusic();
                    RandomMusicFunction();
                    randMusicListInt = Random.Range(0, 6);
                    timer = 0;
                }
                break;

            case 4:
                if (timer < 233)
                {
                    CreoNeverMakeIt.SetActive(true);
                    CreoNeverMakeItText.SetActive(true);
                }

                else if (timer >= 233)
                {
                    DeactivateMusic();
                    RandomMusicFunction();
                    randMusicListInt = Random.Range(0, 6);
                    timer = 0;
                }
                break;

            case 5:
                if (timer < 150)
                {
                    SamifyingNoraLastDance.SetActive(true);
                    SamifyingNoraLastDanceText.SetActive(true);
                }

                else if (timer >= 150)
                {
                    DeactivateMusic();
                    RandomMusicFunction();
                    randMusicListInt = Random.Range(0, 6);
                    timer = 0;
                }
                break;
        }
    }
    void DeactivateMusic()
    {
        CreoSphere.SetActive(false);
        CreoSphereText.SetActive(false);
        CreoCarnivores.SetActive(false);
        CreoCarnivoresText.SetActive(false);
        CreoOutlaw.SetActive(false);
        CreoOutlawText.SetActive(false);
        CreoIdolize.SetActive(false);
        CreoIdolizeText.SetActive(false);
        CreoNeverMakeIt.SetActive(false);
        CreoNeverMakeItText.SetActive(false);
        SamifyingNoraLastDance.SetActive(false);
        SamifyingNoraLastDanceText.SetActive(false);
        RandomMusicText.SetActive(false);
    }
}
