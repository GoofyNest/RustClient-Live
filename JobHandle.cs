public struct JobHandle // TypeDefIndex: 3306
{
	internal IntPtr jobGroup; 
	internal int version; 


public void Complete() { }

public static void CompleteAll(NativeArray<JobHandle> jobs) { }

	[NativeMethodAttribute] 
public static void ScheduleBatchedJobs() { }

	[NativeMethodAttribute] 
private static void ScheduleBatchedJobsAndComplete(ref JobHandle job) { }

	[NativeMethodAttribute] 
private static void ScheduleBatchedJobsAndCompleteAll(void* jobs, int count) { }

public static JobHandle CombineDependencies(JobHandle job0, JobHandle job1) { }

	[NativeMethodAttribute] 
private static JobHandle CombineDependenciesInternal2(ref JobHandle job0, ref JobHandle job1) { }

private static void CombineDependenciesInternal2_Injected(ref JobHandle job0, ref JobHandle job1, out JobHandle ret) { }

}

