public class BaseMission : BaseScriptableObject // TypeDefIndex: 11875
{
	public string shortname; 
	public Translate.Phrase missionName; 
	public Translate.Phrase missionDesc; 
	public BaseMission.MissionObjectiveEntry[] objectives; 
	public GameObjectRef acceptEffect; 
	public GameObjectRef failedEffect; 
	public GameObjectRef victoryEffect; 
	public int repeatDelaySecondsSuccess; 
	public int repeatDelaySecondsFailed; 
	public float timeLimitSeconds; 
	public Sprite icon; 
	public Sprite providerIcon; 
	public BaseMission.MissionDependancy[] acceptDependancies; 
	public BaseMission.MissionDependancy[] completionDependancies; 
	public BaseMission.MissionEntityEntry[] missionEntities; 
	public BaseMission.PositionGenerator[] positionGenerators; 
	public ItemAmount[] baseRewards; 

	public uint id { get; }
	public bool isRepeatable { get; }


	public uint get_id() { }

	public bool get_isRepeatable() { }

	public virtual Sprite GetIcon(BaseMission.MissionInstance instance) { }

	public bool IsEligableForMission(BasePlayer player, IMissionProvider provider) { }

	public void .ctor() { }

}

public class BaseMission.MissionDependancy // TypeDefIndex: 11876
{
	public string targetMissionShortname; 
	public BaseMission.MissionStatus targetMissionDesiredStatus; 
	public bool everAttempted; 

	public uint targetMissionID { get; }


	public uint get_targetMissionID() { }

	public void .ctor() { }

}

public enum BaseMission.MissionStatus // TypeDefIndex: 11877
{
	public int value__; 
	public const BaseMission.MissionStatus Default = 0;
	public const BaseMission.MissionStatus Active = 1;
	public const BaseMission.MissionStatus Accomplished = 2;
	public const BaseMission.MissionStatus Failed = 3;
	public const BaseMission.MissionStatus Completed = 4;

}

public enum BaseMission.MissionEventType // TypeDefIndex: 11878
{
	public int value__; 
	public const BaseMission.MissionEventType CUSTOM = 0;
	public const BaseMission.MissionEventType HARVEST = 1;
	public const BaseMission.MissionEventType CONVERSATION = 2;
	public const BaseMission.MissionEventType KILL_ENTITY = 3;
	public const BaseMission.MissionEventType ACQUIRE_ITEM = 4;
	public const BaseMission.MissionEventType FREE_CRATE = 5;

}

public class BaseMission.MissionObjectiveEntry // TypeDefIndex: 11879
{
	public Translate.Phrase description; 
	public int[] startAfterCompletedObjectives; 
	public int[] autoCompleteOtherObjectives; 
	public bool onlyProgressIfStarted; 
	public MissionObjective objective; 


	public MissionObjective Get() { }

	public void .ctor() { }

}

public class BaseMission.MissionInstance : Pool.IPooled // TypeDefIndex: 11880
{
	private BaseEntity _cachedProviderEntity; 
	private BaseMission _cachedMission; 
	public uint providerID; 
	public uint missionID; 
	public BaseMission.MissionStatus status; 
	public float completionScale; 
	public float startTime; 
	public float endTime; 
	public Vector3 missionLocation; 
	public float timePassed; 
	public Dictionary<string, Vector3> missionPoints; 
	public BaseMission.MissionInstance.ObjectiveStatus[] objectiveStatuses; 
	public List<MissionEntity> createdEntities; 
	public ItemAmount[] rewards; 


	public BaseMission GetMission() { }

	public bool ShouldShowOnMap() { }

	public bool ShouldShowOnCompass() { }

	public void EnterPool() { }

	public void LeavePool() { }

	public void .ctor() { }

}

public class BaseMission.MissionInstance.ObjectiveStatus // TypeDefIndex: 11881
{
	public bool started; 
	public bool completed; 
	public bool failed; 
	public int genericInt1; 
	public float genericFloat1; 


	public void .ctor() { }

}

public enum BaseMission.MissionInstance.ObjectiveType // TypeDefIndex: 11882
{
	public int value__; 
	public const BaseMission.MissionInstance.ObjectiveType MOVE = 0;
	public const BaseMission.MissionInstance.ObjectiveType KILL = 1;

}

public class BaseMission.PositionGenerator // TypeDefIndex: 11883
{
	public string identifier; 
	public float minDistForMovePoint; 
	public float maxDistForMovePoint; 
	public bool centerOnProvider; 
	public bool centerOnPlayer; 
	public BaseMission.PositionGenerator.PositionType positionType; 
	[HeaderAttribute] 
	[InspectorFlagsAttribute] 
	public MissionPoint.MissionPointEnum Flags; 
	[InspectorFlagsAttribute] 
	public MissionPoint.MissionPointEnum ExclusionFlags; 
	[HeaderAttribute] 
	public WorldPositionGenerator worldPositionGenerator; 


	public string GetIdentifier() { }

	public void .ctor() { }

}

public enum BaseMission.PositionGenerator.PositionType // TypeDefIndex: 11884
{
	public int value__; 
	public const BaseMission.PositionGenerator.PositionType MissionPoint = 0;
	public const BaseMission.PositionGenerator.PositionType WorldPositionGenerator = 1;

}

public class BaseMission.MissionEntityEntry // TypeDefIndex: 11885
{
	public GameObjectRef entityRef; 
	public string spawnPositionToUse; 
	public bool cleanupOnMissionFailed; 
	public bool cleanupOnMissionSuccess; 


	public void .ctor() { }

}

