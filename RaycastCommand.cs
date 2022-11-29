public struct RaycastCommand // TypeDefIndex: 3940
{
	[DebuggerBrowsableAttribute] 
	[CompilerGeneratedAttribute] 
	private Vector3 <from>k__BackingField; 
	[DebuggerBrowsableAttribute] 
	[CompilerGeneratedAttribute] 
	private Vector3 <direction>k__BackingField; 
	[DebuggerBrowsableAttribute] 
	[CompilerGeneratedAttribute] 
	private float <distance>k__BackingField; 
	[DebuggerBrowsableAttribute] 
	[CompilerGeneratedAttribute] 
	private int <layerMask>k__BackingField; 
	[DebuggerBrowsableAttribute] 
	[CompilerGeneratedAttribute] 
	private int <maxHits>k__BackingField; 

	public Vector3 from { set; }
	public Vector3 direction { set; }
	public float distance { set; }
	public int layerMask { set; }
	public int maxHits { set; }


	public void .ctor(Vector3 from, Vector3 direction, float distance = 3,402823E+38, int layerMask = -5, int maxHits = 1) { }

	[CompilerGeneratedAttribute] 
	public void set_from(Vector3 value) { }

	[CompilerGeneratedAttribute] 
	public void set_direction(Vector3 value) { }

	[CompilerGeneratedAttribute] 
	public void set_distance(float value) { }

	[CompilerGeneratedAttribute] 
	public void set_layerMask(int value) { }

	[CompilerGeneratedAttribute] 
	public void set_maxHits(int value) { }

	public static JobHandle ScheduleBatch(NativeArray<RaycastCommand> commands, NativeArray<RaycastHit> results, int minCommandsPerJob, JobHandle dependsOn) { }

	[FreeFunctionAttribute] 
	private static JobHandle ScheduleRaycastBatch(ref JobsUtility.JobScheduleParameters parameters, void* commands, int commandLen, void* result, int resultLen, int minCommandsPerJob) { }

	private static void ScheduleRaycastBatch_Injected(ref JobsUtility.JobScheduleParameters parameters, void* commands, int commandLen, void* result, int resultLen, int minCommandsPerJob, out JobHandle ret) { }

}

