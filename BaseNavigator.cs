public class BaseNavigator : BaseMonoBehaviour // TypeDefIndex: 8948
{
	[ServerVar] 
	public static float maxStepUpDistance; 
	[ServerVar] 
	public static int baseNavMovementFrameInterval; 
	[ServerVar] 
	public static float stuckTriggerDuration; 
	[ServerVar] 
	public static float navTypeHeightOffset; 
	[ServerVar] 
	public static float navTypeDistance; 
	[HeaderAttribute] 
	public bool CanNavigateMounted; 
	public bool CanUseNavMesh; 
	public bool CanUseAStar; 
	public bool CanUseBaseNav; 
	public bool CanUseCustomNav; 
	public float StoppingDistance; 
	public string DefaultArea; 
	[HeaderAttribute] 
	public bool TriggerStuckEvent; 
	public float StuckDistance; 
	[HeaderAttribute] 
	public float Speed; 
	public float Acceleration; 
	public float TurnSpeed; 
	[HeaderAttribute] 
	public float SlowestSpeedFraction; 
	public float SlowSpeedFraction; 
	public float NormalSpeedFraction; 
	public float FastSpeedFraction; 
	public float LowHealthSpeedReductionTriggerFraction; 
	public float LowHealthMaxSpeedFraction; 
	public float SwimmingSpeedMultiplier; 
	[HeaderAttribute] 
	public float BestMovementPointMaxDistance; 
	public float BestCoverPointMaxDistance; 
	public float BestRoamPointMaxDistance; 
	public float MaxRoamDistanceFromHome; 
	[HeaderAttribute] 
	public float MaxWaterDepth; 
	public bool SpeedBasedAvoidancePriority; 
	private NavMeshPath path; 
	private NavMeshQueryFilter navMeshQueryFilter; 
	[CompilerGeneratedAttribute] 
	private AIMovePointPath <Path>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private BasePath <AStarGraph>k__BackingField; 
	private int defaultAreaMask; 
	[InspectorFlagsAttribute] 
	public TerrainBiome.Enum biomePreference; 
	public bool UseBiomePreference; 
	[InspectorFlagsAttribute] 
	public TerrainTopology.Enum topologyPreference; 
	[CompilerGeneratedAttribute] 
	private NavMeshAgent <Agent>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private BaseCombatEntity <BaseEntity>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Vector3 <Destination>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private BaseNavigator.NavigationType <CurrentNavigationType>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private BaseNavigator.NavigationType <LastUsedNavigationType>k__BackingField; 

	public AIMovePointPath Path { get; set; }
	public BasePath AStarGraph { get; set; }
	public NavMeshAgent Agent { get; set; }
	public BaseCombatEntity BaseEntity { get; set; }
	public Vector3 Destination { get; set; }
	public virtual bool IsOnNavMeshLink { get; }
	public bool Moving { get; }
	public BaseNavigator.NavigationType CurrentNavigationType { get; set; }
	public BaseNavigator.NavigationType LastUsedNavigationType { get; set; }


	[CompilerGeneratedAttribute] 
	public AIMovePointPath get_Path() { }

	[CompilerGeneratedAttribute] 
	public void set_Path(AIMovePointPath value) { }

	[CompilerGeneratedAttribute] 
	public BasePath get_AStarGraph() { }

	[CompilerGeneratedAttribute] 
	public void set_AStarGraph(BasePath value) { }

	public int TopologyPreference() { }

	[CompilerGeneratedAttribute] 
	public NavMeshAgent get_Agent() { }

	[CompilerGeneratedAttribute] 
	private void set_Agent(NavMeshAgent value) { }

	[CompilerGeneratedAttribute] 
	public BaseCombatEntity get_BaseEntity() { }

	[CompilerGeneratedAttribute] 
	private void set_BaseEntity(BaseCombatEntity value) { }

	[CompilerGeneratedAttribute] 
	public Vector3 get_Destination() { }

	[CompilerGeneratedAttribute] 
	protected void set_Destination(Vector3 value) { }

	public virtual bool get_IsOnNavMeshLink() { }

	public bool get_Moving() { }

	[CompilerGeneratedAttribute] 
	public BaseNavigator.NavigationType get_CurrentNavigationType() { }

	[CompilerGeneratedAttribute] 
	private void set_CurrentNavigationType(BaseNavigator.NavigationType value) { }

	[CompilerGeneratedAttribute] 
	public BaseNavigator.NavigationType get_LastUsedNavigationType() { }

	[CompilerGeneratedAttribute] 
	private void set_LastUsedNavigationType(BaseNavigator.NavigationType value) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public enum BaseNavigator.NavigationType // TypeDefIndex: 8949
{
	public int value__; 
	public const BaseNavigator.NavigationType None = 0;
	public const BaseNavigator.NavigationType NavMesh = 1;
	public const BaseNavigator.NavigationType AStar = 2;
	public const BaseNavigator.NavigationType Custom = 3;
	public const BaseNavigator.NavigationType Base = 4;

}

public enum BaseNavigator.NavigationSpeed // TypeDefIndex: 8950
{
	public int value__; 
	public const BaseNavigator.NavigationSpeed Slowest = 0;
	public const BaseNavigator.NavigationSpeed Slow = 1;
	public const BaseNavigator.NavigationSpeed Normal = 2;
	public const BaseNavigator.NavigationSpeed Fast = 3;

}

