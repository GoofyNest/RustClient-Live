public static class JobsUtility // TypeDefIndex: 3313
{	// Methods

	// RVA: 0x182B700 Offset: 0x182AB00 VA: 0x18182B700
	public static void GetJobRange(ref JobRanges ranges, int jobIndex, out int beginIndex, out int endIndex) { }

	[NativeMethodAttribute] // RVA: 0xEA8C0 Offset: 0xE9CC0 VA: 0x1800EA8C0
	// RVA: 0x182B750 Offset: 0x182AB50 VA: 0x18182B750
	public static bool GetWorkStealingRange(ref JobRanges ranges, int jobIndex, out int beginIndex, out int endIndex) { }

	[FreeFunctionAttribute] // RVA: 0xEA990 Offset: 0xE9D90 VA: 0x1800EA990
	// RVA: 0x182B990 Offset: 0x182AD90 VA: 0x18182B990
	public static JobHandle Schedule(ref JobsUtility.JobScheduleParameters parameters) { }

	[FreeFunctionAttribute] // RVA: 0xEAA90 Offset: 0xE9E90 VA: 0x1800EAA90
	// RVA: 0x182B8D0 Offset: 0x182ACD0 VA: 0x18182B8D0
	public static JobHandle ScheduleParallelFor(ref JobsUtility.JobScheduleParameters parameters, int arrayLength, int innerloopBatchCount) { }

	[FreeFunctionAttribute] // RVA: 0xEBEE0 Offset: 0xEB2E0 VA: 0x1800EBEE0
	// RVA: 0x182B810 Offset: 0x182AC10 VA: 0x18182B810
	public static JobHandle ScheduleParallelForTransform(ref JobsUtility.JobScheduleParameters parameters, IntPtr transfromAccesssArray) { }

	[FreeFunctionAttribute] // RVA: 0x7A1F0 Offset: 0x795F0 VA: 0x18007A1F0
	// RVA: 0x182B690 Offset: 0x182AA90 VA: 0x18182B690
	private static IntPtr CreateJobReflectionData(Type wrapperJobType, Type userJobType, JobType jobType, object managedJobFunction0, object managedJobFunction1, object managedJobFunction2) { }

	// RVA: 0x182B620 Offset: 0x182AA20 VA: 0x18182B620
	public static IntPtr CreateJobReflectionData(Type type, JobType jobType, object managedJobFunction0, object managedJobFunction1, object managedJobFunction2) { }

	// RVA: 0x182B940 Offset: 0x182AD40 VA: 0x18182B940
	private static void Schedule_Injected(ref JobsUtility.JobScheduleParameters parameters, out JobHandle ret) { }

	// RVA: 0x182B870 Offset: 0x182AC70 VA: 0x18182B870
	private static void ScheduleParallelFor_Injected(ref JobsUtility.JobScheduleParameters parameters, int arrayLength, int innerloopBatchCount, out JobHandle ret) { }

	// RVA: 0x182B7B0 Offset: 0x182ABB0 VA: 0x18182B7B0
	private static void ScheduleParallelForTransform_Injected(ref JobsUtility.JobScheduleParameters parameters, IntPtr transfromAccesssArray, out JobHandle ret) { }

}

public struct JobsUtility.JobScheduleParameters // TypeDefIndex: 3314
{	// Fields
	public JobHandle Dependency; // 0x0
	public int ScheduleMode; // 0x10
	public IntPtr ReflectionData; // 0x18
	public IntPtr JobDataPtr; // 0x20

	// Methods

	// RVA: 0x213460 Offset: 0x212860 VA: 0x180213460
	public void .ctor(void* i_jobData, IntPtr i_reflectionData, JobHandle i_dependency, ScheduleMode i_scheduleMode) { }

}

