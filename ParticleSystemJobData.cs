public struct ParticleSystemJobData // TypeDefIndex: 4555
{
	[CompilerGeneratedAttribute] 
	[DebuggerBrowsableAttribute] 
	private readonly int <count>k__BackingField; 
	[CompilerGeneratedAttribute] 
	[DebuggerBrowsableAttribute] 
	private readonly ParticleSystemNativeArray3 <positions>k__BackingField; 
	[DebuggerBrowsableAttribute] 
	[CompilerGeneratedAttribute] 
	private readonly ParticleSystemNativeArray3 <velocities>k__BackingField; 
	[DebuggerBrowsableAttribute] 
	[CompilerGeneratedAttribute] 
	private readonly ParticleSystemNativeArray3 <rotations>k__BackingField; 
	[CompilerGeneratedAttribute] 
	[DebuggerBrowsableAttribute] 
	private readonly ParticleSystemNativeArray3 <rotationalSpeeds>k__BackingField; 
	[CompilerGeneratedAttribute] 
	[DebuggerBrowsableAttribute] 
	private readonly ParticleSystemNativeArray3 <sizes>k__BackingField; 
	[DebuggerBrowsableAttribute] 
	[CompilerGeneratedAttribute] 
	private readonly NativeArray<Color32> <startColors>k__BackingField; 
	[DebuggerBrowsableAttribute] 
	[CompilerGeneratedAttribute] 
	private readonly NativeArray<float> <aliveTimePercent>k__BackingField; 
	[DebuggerBrowsableAttribute] 
	[CompilerGeneratedAttribute] 
	private readonly NativeArray<float> <inverseStartLifetimes>k__BackingField; 
	[DebuggerBrowsableAttribute] 
	[CompilerGeneratedAttribute] 
	private readonly NativeArray<uint> <randomSeeds>k__BackingField; 
	[CompilerGeneratedAttribute] 
	[DebuggerBrowsableAttribute] 
	private readonly ParticleSystemNativeArray4 <customData1>k__BackingField; 
	[CompilerGeneratedAttribute] 
	[DebuggerBrowsableAttribute] 
	private readonly ParticleSystemNativeArray4 <customData2>k__BackingField; 

	public int count { get; }
	public ParticleSystemNativeArray3 positions { get; }
	public ParticleSystemNativeArray3 velocities { get; }
	public NativeArray<float> aliveTimePercent { get; }
	public NativeArray<float> inverseStartLifetimes { get; }


	[CompilerGeneratedAttribute] 
	public int get_count() { }

	[CompilerGeneratedAttribute] 
	public ParticleSystemNativeArray3 get_positions() { }

	[CompilerGeneratedAttribute] 
	public ParticleSystemNativeArray3 get_velocities() { }

	[CompilerGeneratedAttribute] 
	public NativeArray<float> get_aliveTimePercent() { }

	[CompilerGeneratedAttribute] 
	public NativeArray<float> get_inverseStartLifetimes() { }

	internal void .ctor(ref NativeParticleData nativeData) { }

	internal NativeArray<T> CreateNativeArray<T>(void* src, int count) { }
	/* GenericInstMethod :
	|
	|-ParticleSystemJobData.CreateNativeArray<float>
	|-ParticleSystemJobData.CreateNativeArray<uint>
	|-ParticleSystemJobData.CreateNativeArray<Color32>
	*/

	internal ParticleSystemNativeArray3 CreateNativeArray3(ref NativeParticleData.Array3 ptrs, int count) { }

	internal ParticleSystemNativeArray4 CreateNativeArray4(ref NativeParticleData.Array4 ptrs, int count) { }

}

