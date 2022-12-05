public class BaseAIEvent // TypeDefIndex: 11134
{
	[CompilerGeneratedAttribute]
	private AIEventType <EventType>k__BackingField;
	[CompilerGeneratedAttribute]
	private int <TriggerStateContainerID>k__BackingField;
	[CompilerGeneratedAttribute]
	private BaseAIEvent.ExecuteRate <Rate>k__BackingField;
	[CompilerGeneratedAttribute]
	private bool <ShouldExecute>k__BackingField;
	[CompilerGeneratedAttribute]
	private bool <Result>k__BackingField;
	[CompilerGeneratedAttribute]
	private bool <Inverted>k__BackingField;
	[CompilerGeneratedAttribute]
	private int <OutputEntityMemorySlot>k__BackingField;
	[CompilerGeneratedAttribute]
	private int <InputEntityMemorySlot>k__BackingField;
	[CompilerGeneratedAttribute]
	private int <ID>k__BackingField;
	[CompilerGeneratedAttribute]
	private BaseEntity <Owner>k__BackingField;
	private float executeTimer;
	protected float deltaTime;

	public AIEventType EventType { get; set; }
	public int TriggerStateContainerID { get; set; }
	public BaseAIEvent.ExecuteRate Rate { get; set; }
	public float ExecutionRate { get; }
	public bool ShouldExecute { get; set; }
	public bool Result { get; set; }
	public bool Inverted { get; set; }
	public int OutputEntityMemorySlot { get; set; }
	public bool ShouldSetOutputEntityMemory { get; }
	public int InputEntityMemorySlot { get; set; }
	public int ID { get; set; }
	public BaseEntity Owner { get; set; }
	public bool HasValidTriggerState { get; }


	[CompilerGeneratedAttribute]
	public AIEventType get_EventType() { }

	[CompilerGeneratedAttribute]
	private void set_EventType(AIEventType value) { }

	[CompilerGeneratedAttribute]
	public int get_TriggerStateContainerID() { }

	[CompilerGeneratedAttribute]
	private void set_TriggerStateContainerID(int value) { }

	[CompilerGeneratedAttribute]
	public BaseAIEvent.ExecuteRate get_Rate() { }

	[CompilerGeneratedAttribute]
	protected void set_Rate(BaseAIEvent.ExecuteRate value) { }

	public float get_ExecutionRate() { }

	[CompilerGeneratedAttribute]
	public bool get_ShouldExecute() { }

	[CompilerGeneratedAttribute]
	protected void set_ShouldExecute(bool value) { }

	[CompilerGeneratedAttribute]
	public bool get_Result() { }

	[CompilerGeneratedAttribute]
	protected void set_Result(bool value) { }

	[CompilerGeneratedAttribute]
	public bool get_Inverted() { }

	[CompilerGeneratedAttribute]
	private void set_Inverted(bool value) { }

	[CompilerGeneratedAttribute]
	public int get_OutputEntityMemorySlot() { }

	[CompilerGeneratedAttribute]
	protected void set_OutputEntityMemorySlot(int value) { }

	public bool get_ShouldSetOutputEntityMemory() { }

	[CompilerGeneratedAttribute]
	public int get_InputEntityMemorySlot() { }

	[CompilerGeneratedAttribute]
	protected void set_InputEntityMemorySlot(int value) { }

	[CompilerGeneratedAttribute]
	public int get_ID() { }

	[CompilerGeneratedAttribute]
	protected void set_ID(int value) { }

	[CompilerGeneratedAttribute]
	public BaseEntity get_Owner() { }

	[CompilerGeneratedAttribute]
	private void set_Owner(BaseEntity value) { }

	public bool get_HasValidTriggerState() { }

	public void .ctor(AIEventType type) { }

	public virtual void Init(AIEventData data, BaseEntity owner) { }

	public virtual void Init(int triggerStateContainer, int id, BaseEntity owner, int inputMemorySlot, int outputMemorySlot, bool inverted) { }

	public virtual AIEventData ToProto() { }

	public virtual void Reset() { }

	public void Tick(float deltaTime, IAIEventListener listener) { }

	public virtual void Execute(AIMemory memory, AIBrainSenses senses, StateStatus stateStatus) { }

	public virtual void PostExecute() { }

	public void TriggerStateChange(IAIEventListener listener, int sourceEventID) { }

	public static BaseAIEvent CreateEvent(AIEventType eventType) { }

}

public enum BaseAIEvent.ExecuteRate // TypeDefIndex: 11135
{
	public int value__;
	public const BaseAIEvent.ExecuteRate Slow = 0;
	public const BaseAIEvent.ExecuteRate Normal = 1;
	public const BaseAIEvent.ExecuteRate Fast = 2;
	public const BaseAIEvent.ExecuteRate VeryFast = 3;

}

