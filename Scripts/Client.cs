using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Client : MonoBehaviour
{
    public GameObject Encounter;
    public TextMeshProUGUI EncounterHeader;

    public string encounterType;
    public string encounterLevel;

    public void typeDropdown(int val)
    {
        if (val == 0)
        {
            encounterType = "Desert";
        }
        if (val == 1)
        {
            encounterType = "Forest";
        }
        if (val == 2)
        {
            encounterType = "Dungeon";
        }
        if (val == 3)
        {
            encounterType = "Urban";
        }
    }

    public void levelDropDown(int val)
    {
        
        if (val == 0)
        {
            encounterLevel = "Low Level";
        }
        if (val == 1)
        {
            encounterLevel = "Mid Level";
        }
        if (val == 2)
        {
            encounterLevel = "High level";
        }
    }

    public void GenerateEncounter()
    {
        if (Encounter != null)
        {
            Encounter.SetActive(true);
        }

        EncounterHeader.text = encounterLevel + " " + encounterType + " " + "Encounter";

        EncounterRequirements requirements = new EncounterRequirements();
        requirements.encounterType = encounterType;
        requirements.encounterLevel = encounterLevel;

        IEncounter E = GetEncounter(requirements);
        Debug.Log(E);

        //if(E == LowLevelDesert)
        //{
        //EncounterText.text = "You come across 2 desert bandits riding camels, they are hostile!";
        //}
    }

    private static IEncounter GetEncounter(EncounterRequirements requirements)
    {
        EncounterFactory factory = new EncounterFactory(requirements);
        return factory.Create();
    }
}
