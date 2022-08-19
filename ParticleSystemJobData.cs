public struct ParticleSystemJobData // TypeDefIndex: 4550
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	[DebuggerBrowsableAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	private readonly int <count>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	[DebuggerBrowsableAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	private readonly ParticleSystemNativeArray3 <positions>k__BackingField; // 0x8
	[DebuggerBrowsableAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	[CompilerGeneratedAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	private readonly ParticleSystemNativeArray3 <velocities>k__BackingField; // 0x38
	[DebuggerBrowsableAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	[CompilerGeneratedAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	private readonly ParticleSystemNativeArray3 <rotations>k__BackingField; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	[DebuggerBrowsableAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	private readonly ParticleSystemNativeArray3 <rotationalSpeeds>k__BackingField; // 0x98
	[CompilerGeneratedAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	[DebuggerBrowsableAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	private readonly ParticleSystemNativeArray3 <sizes>k__BackingField; // 0xC8
	[DebuggerBrowsableAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	[CompilerGeneratedAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	private readonly NativeArray<Color32> <startColors>k__BackingField; // 0xF8
	[DebuggerBrowsableAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	[CompilerGeneratedAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	private readonly NativeArray<float> <aliveTimePercent>k__BackingField; // 0x108
	[DebuggerBrowsableAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	[CompilerGeneratedAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	private readonly NativeArray<float> <inverseStartLifetimes>k__BackingField; // 0x118
	[DebuggerBrowsableAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	[CompilerGeneratedAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	private readonly NativeArray<uint> <randomSeeds>k__BackingField; // 0x128
	[CompilerGeneratedAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	[DebuggerBrowsableAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	private readonly ParticleSystemNativeArray4 <customData1>k__BackingField; // 0x138
	[CompilerGeneratedAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	[DebuggerBrowsableAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	private readonly ParticleSystemNativeArray4 <customData2>k__BackingField; // 0x178

	// Properties
	public int count { get; }
	public ParticleSystemNativeArray3 positions { get; }
	public ParticleSystemNativeArray3 velocities { get; }
	public NativeArray<float> aliveTimePercent { get; }
	public NativeArray<float> inverseStartLifetimes { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF3850 Offset: 0xF2C50 VA: 0x1800F3850
	public int get_count() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x23BE30 Offset: 0x23B230 VA: 0x18023BE30
	public ParticleSystemNativeArray3 get_positions() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x23BE50 Offset: 0x23B250 VA: 0x18023BE50
	public ParticleSystemNativeArray3 get_velocities() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x23BE10 Offset: 0x23B210 VA: 0x18023BE10
	public NativeArray<float> get_aliveTimePercent() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x23BE20 Offset: 0x23B220 VA: 0x18023BE20
	public NativeArray<float> get_inverseStartLifetimes() { }

	// RVA: 0x23BE00 Offset: 0x23B200 VA: 0x18023BE00
	internal void .ctor(ref NativeParticleData nativeData) { }

	// RVA: -1 Offset: -1
	internal NativeArray<T> CreateNativeArray<T>(void* src, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22AFC0 Offset: 0x22A3C0 VA: 0x18022AFC0
	|-ParticleSystemJobData.CreateNativeArray<float>
	|-ParticleSystemJobData.CreateNativeArray<uint>
	|-ParticleSystemJobData.CreateNativeArray<Color32>
	*/

	// RVA: 0x23BDA0 Offset: 0x23B1A0 VA: 0x18023BDA0
	internal ParticleSystemNativeArray3 CreateNativeArray3(ref NativeParticleData.Array3 ptrs, int count) { }

	// RVA: 0x23BDD0 Offset: 0x23B1D0 VA: 0x18023BDD0
	internal ParticleSystemNativeArray4 CreateNativeArray4(ref NativeParticleData.Array4 ptrs, int count) { }

}

