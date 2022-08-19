public class BaseAIEvent // TypeDefIndex: 9392
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private AIEventType <EventType>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <TriggerStateContainerID>k__BackingField; // 0x14
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private BaseAIEvent.ExecuteRate <Rate>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <ShouldExecute>k__BackingField; // 0x1C
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <Result>k__BackingField; // 0x1D
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <Inverted>k__BackingField; // 0x1E
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <OutputEntityMemorySlot>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <InputEntityMemorySlot>k__BackingField; // 0x24
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <ID>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private BaseEntity <Owner>k__BackingField; // 0x30
	private float executeTimer; // 0x38
	protected float deltaTime; // 0x3C

	// Properties
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

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x36A480 Offset: 0x369880 VA: 0x18036A480
	public AIEventType get_EventType() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x596240 Offset: 0x595640 VA: 0x180596240
	private void set_EventType(AIEventType value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x596230 Offset: 0x595630 VA: 0x180596230
	public int get_TriggerStateContainerID() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x596250 Offset: 0x595650 VA: 0x180596250
	private void set_TriggerStateContainerID(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4BE200 Offset: 0x4BD600 VA: 0x1804BE200
	public BaseAIEvent.ExecuteRate get_Rate() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7E8E20 Offset: 0x7E8220 VA: 0x1807E8E20
	protected void set_Rate(BaseAIEvent.ExecuteRate value) { }

	// RVA: 0x7E8D50 Offset: 0x7E8150 VA: 0x1807E8D50
	public float get_ExecutionRate() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7E8DD0 Offset: 0x7E81D0 VA: 0x1807E8DD0
	public bool get_ShouldExecute() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7E8E40 Offset: 0x7E8240 VA: 0x1807E8E40
	protected void set_ShouldExecute(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7E8DC0 Offset: 0x7E81C0 VA: 0x1807E8DC0
	public bool get_Result() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7E8E30 Offset: 0x7E8230 VA: 0x1807E8E30
	protected void set_Result(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7E8DB0 Offset: 0x7E81B0 VA: 0x1807E8DB0
	public bool get_Inverted() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7E8E10 Offset: 0x7E8210 VA: 0x1807E8E10
	private void set_Inverted(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4D0170 Offset: 0x4CF570 VA: 0x1804D0170
	public int get_OutputEntityMemorySlot() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x69CC40 Offset: 0x69C040 VA: 0x18069CC40
	protected void set_OutputEntityMemorySlot(int value) { }

	// RVA: 0x7E8DE0 Offset: 0x7E81E0 VA: 0x1807E8DE0
	public bool get_ShouldSetOutputEntityMemory() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7E8DA0 Offset: 0x7E81A0 VA: 0x1807E8DA0
	public int get_InputEntityMemorySlot() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7E8E00 Offset: 0x7E8200 VA: 0x1807E8E00
	protected void set_InputEntityMemorySlot(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4BB390 Offset: 0x4BA790 VA: 0x1804BB390
	public int get_ID() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7E8DF0 Offset: 0x7E81F0 VA: 0x1807E8DF0
	protected void set_ID(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0
	public BaseEntity get_Owner() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4A2F10 Offset: 0x4A2310 VA: 0x1804A2F10
	private void set_Owner(BaseEntity value) { }

	// RVA: 0x7E8D90 Offset: 0x7E8190 VA: 0x1807E8D90
	public bool get_HasValidTriggerState() { }

	// RVA: 0x7E8D10 Offset: 0x7E8110 VA: 0x1807E8D10
	public void .ctor(AIEventType type) { }

	// RVA: 0x7E8AB0 Offset: 0x7E7EB0 VA: 0x1807E8AB0 Slot: 4
	public virtual void Init(AIEventData data, BaseEntity owner) { }

	// RVA: 0x7E8B00 Offset: 0x7E7F00 VA: 0x1807E8B00 Slot: 5
	public virtual void Init(int triggerStateContainer, int id, BaseEntity owner, int inputMemorySlot, int outputMemorySlot, bool inverted) { }

	// RVA: 0x7E8BD0 Offset: 0x7E7FD0 VA: 0x1807E8BD0 Slot: 6
	public virtual AIEventData ToProto() { }

	// RVA: 0x7E8B50 Offset: 0x7E7F50 VA: 0x1807E8B50 Slot: 7
	public virtual void Reset() { }

	// RVA: 0x7E8B60 Offset: 0x7E7F60 VA: 0x1807E8B60
	public void Tick(float deltaTime, IAIEventListener listener) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 8
	public virtual void Execute(AIMemory memory, AIBrainSenses senses, StateStatus stateStatus) { }

	// RVA: 0x7E8B40 Offset: 0x7E7F40 VA: 0x1807E8B40 Slot: 9
	public virtual void PostExecute() { }

	// RVA: 0x7E8C50 Offset: 0x7E8050 VA: 0x1807E8C50
	public void TriggerStateChange(IAIEventListener listener, int sourceEventID) { }

	// RVA: 0x7E8630 Offset: 0x7E7A30 VA: 0x1807E8630
	public static BaseAIEvent CreateEvent(AIEventType eventType) { }

}

public enum BaseAIEvent.ExecuteRate // TypeDefIndex: 9393
{	// Fields
	public int value__; // 0x0
	public const BaseAIEvent.ExecuteRate Slow = 0;
	public const BaseAIEvent.ExecuteRate Normal = 1;
	public const BaseAIEvent.ExecuteRate Fast = 2;
	public const BaseAIEvent.ExecuteRate VeryFast = 3;

}

