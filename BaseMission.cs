public class BaseMission : BaseScriptableObject // TypeDefIndex: 10200
{	// Fields
	public string shortname; // 0x20
	public Translate.Phrase missionName; // 0x28
	public Translate.Phrase missionDesc; // 0x30
	public BaseMission.MissionObjectiveEntry[] objectives; // 0x38
	public GameObjectRef acceptEffect; // 0x40
	public GameObjectRef failedEffect; // 0x48
	public GameObjectRef victoryEffect; // 0x50
	public int repeatDelaySecondsSuccess; // 0x58
	public int repeatDelaySecondsFailed; // 0x5C
	public float timeLimitSeconds; // 0x60
	public Sprite icon; // 0x68
	public Sprite providerIcon; // 0x70
	public BaseMission.MissionDependancy[] acceptDependancies; // 0x78
	public BaseMission.MissionDependancy[] completionDependancies; // 0x80
	public BaseMission.MissionEntityEntry[] missionEntities; // 0x88
	public BaseMission.PositionGenerator[] positionGenerators; // 0x90
	public ItemAmount[] baseRewards; // 0x98

	// Properties
	public uint id { get; }
	public bool isRepeatable { get; }

	// Methods

	// RVA: 0xA25910 Offset: 0xA24D10 VA: 0x180A25910
	public uint get_id() { }

	// RVA: 0xA25970 Offset: 0xA24D70 VA: 0x180A25970
	public bool get_isRepeatable() { }

	// RVA: 0x5334F0 Offset: 0x5328F0 VA: 0x1805334F0 Slot: 4
	public virtual Sprite GetIcon(BaseMission.MissionInstance instance) { }

	// RVA: 0xA257A0 Offset: 0xA24BA0 VA: 0x180A257A0
	public bool IsEligableForMission(BasePlayer player, IMissionProvider provider) { }

	// RVA: 0xA25900 Offset: 0xA24D00 VA: 0x180A25900
	public void .ctor() { }

}

public class BaseMission.MissionDependancy // TypeDefIndex: 10201
{	// Fields
	public string targetMissionShortname; // 0x10
	public BaseMission.MissionStatus targetMissionDesiredStatus; // 0x18
	public bool everAttempted; // 0x1C

	// Properties
	public uint targetMissionID { get; }

	// Methods

	// RVA: 0xA32EE0 Offset: 0xA322E0 VA: 0x180A32EE0
	public uint get_targetMissionID() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public enum BaseMission.MissionStatus // TypeDefIndex: 10202
{	// Fields
	public int value__; // 0x0
	public const BaseMission.MissionStatus Default = 0;
	public const BaseMission.MissionStatus Active = 1;
	public const BaseMission.MissionStatus Accomplished = 2;
	public const BaseMission.MissionStatus Failed = 3;
	public const BaseMission.MissionStatus Completed = 4;

}

public enum BaseMission.MissionEventType // TypeDefIndex: 10203
{	// Fields
	public int value__; // 0x0
	public const BaseMission.MissionEventType CUSTOM = 0;
	public const BaseMission.MissionEventType HARVEST = 1;
	public const BaseMission.MissionEventType CONVERSATION = 2;
	public const BaseMission.MissionEventType KILL_ENTITY = 3;
	public const BaseMission.MissionEventType ACQUIRE_ITEM = 4;
	public const BaseMission.MissionEventType FREE_CRATE = 5;

}

public class BaseMission.MissionObjectiveEntry // TypeDefIndex: 10204
{	// Fields
	public Translate.Phrase description; // 0x10
	public int[] startAfterCompletedObjectives; // 0x18
	public int[] autoCompleteOtherObjectives; // 0x20
	public bool onlyProgressIfStarted; // 0x28
	public MissionObjective objective; // 0x30

	// Methods

	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0
	public MissionObjective Get() { }

	// RVA: 0xA33210 Offset: 0xA32610 VA: 0x180A33210
	public void .ctor() { }

}

public class BaseMission.MissionInstance : Pool.IPooled // TypeDefIndex: 10205
{	// Fields
	private BaseEntity _cachedProviderEntity; // 0x10
	private BaseMission _cachedMission; // 0x18
	public uint providerID; // 0x20
	public uint missionID; // 0x24
	public BaseMission.MissionStatus status; // 0x28
	public float completionScale; // 0x2C
	public float startTime; // 0x30
	public float endTime; // 0x34
	public Vector3 missionLocation; // 0x38
	public float timePassed; // 0x44
	public Dictionary<string, Vector3> missionPoints; // 0x48
	public BaseMission.MissionInstance.ObjectiveStatus[] objectiveStatuses; // 0x50
	public List<MissionEntity> createdEntities; // 0x58
	public ItemAmount[] rewards; // 0x60

	// Methods

	// RVA: 0xA33030 Offset: 0xA32430 VA: 0x180A33030
	public BaseMission GetMission() { }

	// RVA: 0xA330F0 Offset: 0xA324F0 VA: 0x180A330F0
	public bool ShouldShowOnMap() { }

	// RVA: 0xA330F0 Offset: 0xA324F0 VA: 0x180A330F0
	public bool ShouldShowOnCompass() { }

	// RVA: 0xA32F40 Offset: 0xA32340 VA: 0x180A32F40 Slot: 4
	public void EnterPool() { }

	// RVA: 0xA33080 Offset: 0xA32480 VA: 0x180A33080 Slot: 5
	public void LeavePool() { }

	// RVA: 0xA331A0 Offset: 0xA325A0 VA: 0x180A331A0
	public void .ctor() { }

}

public class BaseMission.MissionInstance.ObjectiveStatus // TypeDefIndex: 10206
{	// Fields
	public bool started; // 0x10
	public bool completed; // 0x11
	public bool failed; // 0x12
	public int genericInt1; // 0x14
	public float genericFloat1; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public enum BaseMission.MissionInstance.ObjectiveType // TypeDefIndex: 10207
{	// Fields
	public int value__; // 0x0
	public const BaseMission.MissionInstance.ObjectiveType MOVE = 0;
	public const BaseMission.MissionInstance.ObjectiveType KILL = 1;

}

public class BaseMission.PositionGenerator // TypeDefIndex: 10208
{	// Fields
	public string identifier; // 0x10
	public float minDistForMovePoint; // 0x18
	public float maxDistForMovePoint; // 0x1C
	public bool centerOnProvider; // 0x20
	public bool centerOnPlayer; // 0x21
	public BaseMission.PositionGenerator.PositionType positionType; // 0x24
	[HeaderAttribute] // RVA: 0xBE0E0 Offset: 0xBD4E0 VA: 0x1800BE0E0
	[InspectorFlagsAttribute] // RVA: 0xBE0E0 Offset: 0xBD4E0 VA: 0x1800BE0E0
	public MissionPoint.MissionPointEnum Flags; // 0x28
	[InspectorFlagsAttribute] // RVA: 0x70A20 Offset: 0x6FE20 VA: 0x180070A20
	public MissionPoint.MissionPointEnum ExclusionFlags; // 0x2C
	[HeaderAttribute] // RVA: 0xBE220 Offset: 0xBD620 VA: 0x1800BE220
	public WorldPositionGenerator worldPositionGenerator; // 0x30

	// Methods

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public string GetIdentifier() { }

	// RVA: 0xA33220 Offset: 0xA32620 VA: 0x180A33220
	public void .ctor() { }

}

public enum BaseMission.PositionGenerator.PositionType // TypeDefIndex: 10209
{	// Fields
	public int value__; // 0x0
	public const BaseMission.PositionGenerator.PositionType MissionPoint = 0;
	public const BaseMission.PositionGenerator.PositionType WorldPositionGenerator = 1;

}

public class BaseMission.MissionEntityEntry // TypeDefIndex: 10210
{	// Fields
	public GameObjectRef entityRef; // 0x10
	public string spawnPositionToUse; // 0x18
	public bool cleanupOnMissionFailed; // 0x20
	public bool cleanupOnMissionSuccess; // 0x21

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

