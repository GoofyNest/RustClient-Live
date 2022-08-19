public struct JobHandle // TypeDefIndex: 3306
{	// Fields
	internal IntPtr jobGroup; // 0x0
	internal int version; // 0x8

	// Methods

	// RVA: 0x2133F0 Offset: 0x2127F0 VA: 0x1802133F0
	public void Complete() { }

	// RVA: 0x182B440 Offset: 0x182A840 VA: 0x18182B440
	public static void CompleteAll(NativeArray<JobHandle> jobs) { }

	[NativeMethodAttribute] // RVA: 0x97750 Offset: 0x96B50 VA: 0x180097750
	// RVA: 0x182B5B0 Offset: 0x182A9B0 VA: 0x18182B5B0
	public static void ScheduleBatchedJobs() { }

	[NativeMethodAttribute] // RVA: 0x97750 Offset: 0x96B50 VA: 0x180097750
	// RVA: 0x182B570 Offset: 0x182A970 VA: 0x18182B570
	private static void ScheduleBatchedJobsAndComplete(ref JobHandle job) { }

	[NativeMethodAttribute] // RVA: 0x97750 Offset: 0x96B50 VA: 0x180097750
	// RVA: 0x182B530 Offset: 0x182A930 VA: 0x18182B530
	private static void ScheduleBatchedJobsAndCompleteAll(void* jobs, int count) { }

	// RVA: 0x182B3D0 Offset: 0x182A7D0 VA: 0x18182B3D0
	public static JobHandle CombineDependencies(JobHandle job0, JobHandle job1) { }

	[NativeMethodAttribute] // RVA: 0x97750 Offset: 0x96B50 VA: 0x180097750
	// RVA: 0x182B370 Offset: 0x182A770 VA: 0x18182B370
	private static JobHandle CombineDependenciesInternal2(ref JobHandle job0, ref JobHandle job1) { }

	// RVA: 0x182B310 Offset: 0x182A710 VA: 0x18182B310
	private static void CombineDependenciesInternal2_Injected(ref JobHandle job0, ref JobHandle job1, out JobHandle ret) { }

}

