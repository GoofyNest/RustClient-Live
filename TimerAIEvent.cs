public class TimerAIEvent : BaseAIEvent // TypeDefIndex: 11125
{
	[CompilerGeneratedAttribute] 
	private float <DurationMin>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private float <DurationMax>k__BackingField; 
	protected float currentDuration; 
	protected float elapsedDuration; 

	public float DurationMin { get; set; }
	public float DurationMax { get; set; }


	[CompilerGeneratedAttribute] 
	public float get_DurationMin() { }

	[CompilerGeneratedAttribute] 
	public void set_DurationMin(float value) { }

	[CompilerGeneratedAttribute] 
	public float get_DurationMax() { }

	[CompilerGeneratedAttribute] 
	public void set_DurationMax(float value) { }

	public void .ctor() { }

	public override void Init(AIEventData data, BaseEntity owner) { }

	public override AIEventData ToProto() { }

	public override void Reset() { }

	public override void Execute(AIMemory memory, AIBrainSenses senses, StateStatus stateStatus) { }

}

