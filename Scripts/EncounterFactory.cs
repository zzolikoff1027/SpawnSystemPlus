using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEncounterFactory
{
    IEncounter Create(EncounterRequirements requirements);
}

public class DesertEncounter : IEncounterFactory
{
    public IEncounter Create(EncounterRequirements requirements)
    {
        if (requirements.encounterLevel == "Low Level")
        {
            return new LowLevelDesert();
        }
        else if (requirements.encounterLevel == "Mid Level")
        {
            return new MidLevelDesert();
        }
        else return new HighLevelDesert(); 
    }
}

public class ForestEncounter : IEncounterFactory
{
    public IEncounter Create(EncounterRequirements requirements)
    {
        if (requirements.encounterLevel == "Low Level")
        {
            return new LowLevelForest();
        }
        else if (requirements.encounterLevel == "Mid Level")
        {
            return new MidLevelForest();
        }
        else return new HighLevelForest();
    }
}

public class DungeonEncounter: IEncounterFactory
{
    public IEncounter Create(EncounterRequirements requirements)
    {
        if (requirements.encounterLevel == "Low Level")
        {
            return new LowLevelDungeon();
        }
        else if (requirements.encounterLevel == "Mid Level")
        {
            return new MidLevelDungeon();
        }
        else return new HighLevelDungeon();
    }
}

public class UrbanEncounter : IEncounterFactory
{
    public IEncounter Create(EncounterRequirements requirements)
    {
        if (requirements.encounterLevel == "Low Level")
        {
            return new LowLevelUrban();
        }
        else if (requirements.encounterLevel == "Mid Level")
        {
            return new MidLevelUrban();
        }
        else return new HighLevelUrban();
    }
}

public abstract class AbstractEncounterFactory
{
    public abstract IEncounter Create();
}

public class EncounterFactory : AbstractEncounterFactory
{
    private readonly IEncounterFactory _factory;
    private readonly  EncounterRequirements _requirements;

    public EncounterFactory(EncounterRequirements requirements)
    {
        //_factory = requirements.Engine ? (IEncounterFactory)new MotorVehicleFactory() : new CycleFactory();
        if (requirements.encounterType == "Desert")
        {
            _factory = new DesertEncounter();
        }
        if (requirements.encounterType == "Forest")
        {
            _factory = new ForestEncounter();
        }
        if (requirements.encounterType == "Dungeon")
        {
            _factory = new DungeonEncounter();
        }
        if (requirements.encounterType == "Urban")
        {
            _factory = new UrbanEncounter();
        }

        _requirements = requirements;
    }

    public override IEncounter Create()
    {
        return _factory.Create(_requirements);
    }
}
