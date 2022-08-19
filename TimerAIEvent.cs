public class TimerAIEvent : BaseAIEvent // TypeDefIndex: 9415
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float <DurationMin>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float <DurationMax>k__BackingField; // 0x44
	protected float currentDuration; // 0x48
	protected float elapsedDuration; // 0x4C

	// Properties
	public float DurationMin { get; set; }
	public float DurationMax { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x54D6A0 Offset: 0x54CAA0 VA: 0x18054D6A0
	public float get_DurationMin() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x54D6B0 Offset: 0x54CAB0 VA: 0x18054D6B0
	public void set_DurationMin(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7E53E0 Offset: 0x7E47E0 VA: 0x1807E53E0
	public float get_DurationMax() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x84F290 Offset: 0x84E690 VA: 0x18084F290
	public void set_DurationMax(float value) { }

	// RVA: 0x84F270 Offset: 0x84E670 VA: 0x18084F270
	public void .ctor() { }

	// RVA: 0x84F130 Offset: 0x84E530 VA: 0x18084F130 Slot: 4
	public override void Init(AIEventData data, BaseEntity owner) { }

	// RVA: 0x84F1C0 Offset: 0x84E5C0 VA: 0x18084F1C0 Slot: 6
	public override AIEventData ToProto() { }

	// RVA: 0x84F180 Offset: 0x84E580 VA: 0x18084F180 Slot: 7
	public override void Reset() { }

	// RVA: 0x84F100 Offset: 0x84E500 VA: 0x18084F100 Slot: 8
	public override void Execute(AIMemory memory, AIBrainSenses senses, StateStatus stateStatus) { }

}

