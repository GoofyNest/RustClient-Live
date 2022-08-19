public class BaseNavigator : BaseMonoBehaviour // TypeDefIndex: 8945
{	// Fields
	[ServerVar] // RVA: 0xC5150 Offset: 0xC4550 VA: 0x1800C5150
	public static float maxStepUpDistance; // 0x0
	[ServerVar] // RVA: 0xC5290 Offset: 0xC4690 VA: 0x1800C5290
	public static int baseNavMovementFrameInterval; // 0x4
	[ServerVar] // RVA: 0xC53B0 Offset: 0xC47B0 VA: 0x1800C53B0
	public static float stuckTriggerDuration; // 0x8
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static float navTypeHeightOffset; // 0xC
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static float navTypeDistance; // 0x10
	[HeaderAttribute] // RVA: 0xC5520 Offset: 0xC4920 VA: 0x1800C5520
	public bool CanNavigateMounted; // 0x18
	public bool CanUseNavMesh; // 0x19
	public bool CanUseAStar; // 0x1A
	public bool CanUseBaseNav; // 0x1B
	public bool CanUseCustomNav; // 0x1C
	public float StoppingDistance; // 0x20
	public string DefaultArea; // 0x28
	[HeaderAttribute] // RVA: 0xC5700 Offset: 0xC4B00 VA: 0x1800C5700
	public bool TriggerStuckEvent; // 0x30
	public float StuckDistance; // 0x34
	[HeaderAttribute] // RVA: 0xC57A0 Offset: 0xC4BA0 VA: 0x1800C57A0
	public float Speed; // 0x38
	public float Acceleration; // 0x3C
	public float TurnSpeed; // 0x40
	[HeaderAttribute] // RVA: 0xC5950 Offset: 0xC4D50 VA: 0x1800C5950
	public float SlowestSpeedFraction; // 0x44
	public float SlowSpeedFraction; // 0x48
	public float NormalSpeedFraction; // 0x4C
	public float FastSpeedFraction; // 0x50
	public float LowHealthSpeedReductionTriggerFraction; // 0x54
	public float LowHealthMaxSpeedFraction; // 0x58
	public float SwimmingSpeedMultiplier; // 0x5C
	[HeaderAttribute] // RVA: 0xC59D0 Offset: 0xC4DD0 VA: 0x1800C59D0
	public float BestMovementPointMaxDistance; // 0x60
	public float BestCoverPointMaxDistance; // 0x64
	public float BestRoamPointMaxDistance; // 0x68
	public float MaxRoamDistanceFromHome; // 0x6C
	[HeaderAttribute] // RVA: 0x71D40 Offset: 0x71140 VA: 0x180071D40
	public float MaxWaterDepth; // 0x70
	public bool SpeedBasedAvoidancePriority; // 0x74
	private NavMeshPath path; // 0x78
	private NavMeshQueryFilter navMeshQueryFilter; // 0x80
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private AIMovePointPath <Path>k__BackingField; // 0x90
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private BasePath <AStarGraph>k__BackingField; // 0x98
	private int defaultAreaMask; // 0xA0
	[InspectorFlagsAttribute] // RVA: 0x70A20 Offset: 0x6FE20 VA: 0x180070A20
	public TerrainBiome.Enum biomePreference; // 0xA4
	public bool UseBiomePreference; // 0xA8
	[InspectorFlagsAttribute] // RVA: 0x70A20 Offset: 0x6FE20 VA: 0x180070A20
	public TerrainTopology.Enum topologyPreference; // 0xAC
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private NavMeshAgent <Agent>k__BackingField; // 0xB0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private BaseCombatEntity <BaseEntity>k__BackingField; // 0xB8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Vector3 <Destination>k__BackingField; // 0xC0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private BaseNavigator.NavigationType <CurrentNavigationType>k__BackingField; // 0xCC
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private BaseNavigator.NavigationType <LastUsedNavigationType>k__BackingField; // 0xD0

	// Properties
	public AIMovePointPath Path { get; set; }
	public BasePath AStarGraph { get; set; }
	public NavMeshAgent Agent { get; set; }
	public BaseCombatEntity BaseEntity { get; set; }
	public Vector3 Destination { get; set; }
	public virtual bool IsOnNavMeshLink { get; }
	public bool Moving { get; }
	public BaseNavigator.NavigationType CurrentNavigationType { get; set; }
	public BaseNavigator.NavigationType LastUsedNavigationType { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4E09F0 Offset: 0x4DFDF0 VA: 0x1804E09F0
	public AIMovePointPath get_Path() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4E0A00 Offset: 0x4DFE00 VA: 0x1804E0A00
	public void set_Path(AIMovePointPath value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x58DBE0 Offset: 0x58CFE0 VA: 0x18058DBE0
	public BasePath get_AStarGraph() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x58DC70 Offset: 0x58D070 VA: 0x18058DC70
	public void set_AStarGraph(BasePath value) { }

	// RVA: 0xA2BC00 Offset: 0xA2B000 VA: 0x180A2BC00
	public int TopologyPreference() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x972280 Offset: 0x971680 VA: 0x180972280
	public NavMeshAgent get_Agent() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xA2BE00 Offset: 0xA2B200 VA: 0x180A2BE00
	private void set_Agent(NavMeshAgent value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7AACD0 Offset: 0x7AA0D0 VA: 0x1807AACD0
	public BaseCombatEntity get_BaseEntity() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xA2BE10 Offset: 0xA2B210 VA: 0x180A2BE10
	private void set_BaseEntity(BaseCombatEntity value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xA2BD80 Offset: 0xA2B180 VA: 0x180A2BD80
	public Vector3 get_Destination() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xA2BE30 Offset: 0xA2B230 VA: 0x180A2BE30
	protected void set_Destination(Vector3 value) { }

	// RVA: 0xA2BDA0 Offset: 0xA2B1A0 VA: 0x180A2BDA0 Slot: 6
	public virtual bool get_IsOnNavMeshLink() { }

	// RVA: 0xA2BDF0 Offset: 0xA2B1F0 VA: 0x180A2BDF0
	public bool get_Moving() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xA2BD70 Offset: 0xA2B170 VA: 0x180A2BD70
	public BaseNavigator.NavigationType get_CurrentNavigationType() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xA2BE20 Offset: 0xA2B220 VA: 0x180A2BE20
	private void set_CurrentNavigationType(BaseNavigator.NavigationType value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x84C150 Offset: 0x84B550 VA: 0x18084C150
	public BaseNavigator.NavigationType get_LastUsedNavigationType() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x75BD40 Offset: 0x75B140 VA: 0x18075BD40
	private void set_LastUsedNavigationType(BaseNavigator.NavigationType value) { }

	// RVA: 0xA2BCA0 Offset: 0xA2B0A0 VA: 0x180A2BCA0
	public void .ctor() { }

	// RVA: 0xA2BC10 Offset: 0xA2B010 VA: 0x180A2BC10
	private static void .cctor() { }

}

public enum BaseNavigator.NavigationType // TypeDefIndex: 8946
{	// Fields
	public int value__; // 0x0
	public const BaseNavigator.NavigationType None = 0;
	public const BaseNavigator.NavigationType NavMesh = 1;
	public const BaseNavigator.NavigationType AStar = 2;
	public const BaseNavigator.NavigationType Custom = 3;
	public const BaseNavigator.NavigationType Base = 4;

}

public enum BaseNavigator.NavigationSpeed // TypeDefIndex: 8947
{	// Fields
	public int value__; // 0x0
	public const BaseNavigator.NavigationSpeed Slowest = 0;
	public const BaseNavigator.NavigationSpeed Slow = 1;
	public const BaseNavigator.NavigationSpeed Normal = 2;
	public const BaseNavigator.NavigationSpeed Fast = 3;

}

