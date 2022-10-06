public class BaseAIBrain : EntityComponent<BaseEntity>, IPet, IAISleepable, IAIDesign, IAIGroupable, IAIEventListener // TypeDefIndex: 10195
{
	public bool UseQueuedMovementUpdates; 
	public bool AllowedToSleep; 
	public AIDesignSO DefaultDesignSO; 
	public List<AIDesignSO> Designs; 
	public AIDesign InstanceSpecificDesign; 
	public float SenseRange; 
	public float AttackRangeMultiplier; 
	public float TargetLostRange; 
	public float VisionCone; 
	public bool CheckVisionCone; 
	public bool CheckLOS; 
	public bool IgnoreNonVisionSneakers; 
	public float ListenRange; 
	public EntityType SenseTypes; 
	public bool HostileTargetsOnly; 
	public bool IgnoreSafeZonePlayers; 
	public int MaxGroupSize; 
	public float MemoryDuration; 
	public bool RefreshKnownLOS; 
	[CompilerGeneratedAttribute] 
	private BaseAIBrain.BasicAIState <CurrentState>k__BackingField; 
	public Vector3 mainInterestPoint; 
	[CompilerGeneratedAttribute] 
	private AIThinkMode <ThinkMode>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private float <Age>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private AIBrainSenses <Senses>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private BasePathFinder <PathFinder>k__BackingField; 
	public bool UseAIDesign; 
	[CompilerGeneratedAttribute] 
	private AIEvents <Events>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private AIDesign <AIDesign>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private BasePlayer <DesigningPlayer>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private BasePlayer <OwningPlayer>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private bool <IsGroupLeader>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private bool <IsGrouped>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private IAIGroupable <GroupLeader>k__BackingField; 
	public bool Pet; 
	private List<IAIGroupable> groupMembers; 
	[HeaderAttribute] 
	public bool CanUseHealingItems; 
	public float HealChance; 
	public float HealBelowHealthFraction; 

	public BaseAIBrain.BasicAIState CurrentState { get; set; }
	public AIThinkMode ThinkMode { get; set; }
	public float Age { get; set; }
	public AIBrainSenses Senses { get; set; }
	public BasePathFinder PathFinder { get; set; }
	public AIEvents Events { get; set; }
	public AIDesign AIDesign { get; set; }
	public BasePlayer DesigningPlayer { get; set; }
	public BasePlayer OwningPlayer { get; set; }
	public bool IsGroupLeader { get; set; }
	public bool IsGrouped { get; set; }
	public IAIGroupable GroupLeader { get; set; }


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public bool IsPet() { }

	public void SetPetOwner(BasePlayer player) { }

	public bool IsOwnedBy(BasePlayer player) { }

	public bool IssuePetCommand(PetCommandType cmd, int param, Nullable<Ray> ray) { }

	[CompilerGeneratedAttribute] 
	public BaseAIBrain.BasicAIState get_CurrentState() { }

	[CompilerGeneratedAttribute] 
	private void set_CurrentState(BaseAIBrain.BasicAIState value) { }

	[CompilerGeneratedAttribute] 
	public AIThinkMode get_ThinkMode() { }

	[CompilerGeneratedAttribute] 
	protected void set_ThinkMode(AIThinkMode value) { }

	[CompilerGeneratedAttribute] 
	public float get_Age() { }

	[CompilerGeneratedAttribute] 
	private void set_Age(float value) { }

	public void ForceSetAge(float age) { }

	[CompilerGeneratedAttribute] 
	public AIBrainSenses get_Senses() { }

	[CompilerGeneratedAttribute] 
	private void set_Senses(AIBrainSenses value) { }

	[CompilerGeneratedAttribute] 
	public BasePathFinder get_PathFinder() { }

	[CompilerGeneratedAttribute] 
	protected void set_PathFinder(BasePathFinder value) { }

	[CompilerGeneratedAttribute] 
	public AIEvents get_Events() { }

	[CompilerGeneratedAttribute] 
	private void set_Events(AIEvents value) { }

	[CompilerGeneratedAttribute] 
	public AIDesign get_AIDesign() { }

	[CompilerGeneratedAttribute] 
	private void set_AIDesign(AIDesign value) { }

	[CompilerGeneratedAttribute] 
	public BasePlayer get_DesigningPlayer() { }

	[CompilerGeneratedAttribute] 
	private void set_DesigningPlayer(BasePlayer value) { }

	[CompilerGeneratedAttribute] 
	public BasePlayer get_OwningPlayer() { }

	[CompilerGeneratedAttribute] 
	private void set_OwningPlayer(BasePlayer value) { }

	[CompilerGeneratedAttribute] 
	public bool get_IsGroupLeader() { }

	[CompilerGeneratedAttribute] 
	private void set_IsGroupLeader(bool value) { }

	[CompilerGeneratedAttribute] 
	public bool get_IsGrouped() { }

	[CompilerGeneratedAttribute] 
	private void set_IsGrouped(bool value) { }

	[CompilerGeneratedAttribute] 
	public IAIGroupable get_GroupLeader() { }

	[CompilerGeneratedAttribute] 
	private void set_GroupLeader(IAIGroupable value) { }

	private bool IAIDesign.CanPlayerDesignAI(BasePlayer player) { }

	private bool PlayerCanDesignAI(BasePlayer player) { }

	public void EventTriggeredStateChange(int newStateContainerID, int sourceEventID) { }

	public void .ctor() { }

}

public class BaseAIBrain.BasicAIState // TypeDefIndex: 10196
{

	public void .ctor() { }

}

