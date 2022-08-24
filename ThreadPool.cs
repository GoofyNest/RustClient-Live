public static class ThreadPool // TypeDefIndex: 816
{

	private static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, uint millisecondsTimeOutInterval, bool executeOnlyOnce, ref StackCrawlMark stackMark, bool compressStack) { }

	public static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, TimeSpan timeout, bool executeOnlyOnce) { }

	public static bool QueueUserWorkItem(WaitCallback callBack, object state) { }

	public static bool QueueUserWorkItem(WaitCallback callBack) { }

	public static bool UnsafeQueueUserWorkItem(WaitCallback callBack, object state) { }

	private static bool QueueUserWorkItemHelper(WaitCallback callBack, object state, ref StackCrawlMark stackMark, bool compressStack) { }

	internal static void UnsafeQueueCustomWorkItem(IThreadPoolWorkItem workItem, bool forceGlobal) { }

	internal static bool TryPopCustomWorkItem(IThreadPoolWorkItem workItem) { }

	internal static bool RequestWorkerThread() { }

	private static void EnsureVMInitialized() { }

	internal static bool NotifyWorkItemComplete() { }

	internal static void ReportThreadStatus(bool isWorking) { }

	internal static void NotifyWorkItemProgress() { }

	internal static void NotifyWorkItemProgressNative() { }

	internal static bool IsThreadPoolHosted() { }

	private static void InitializeVMTp(ref bool enableWorkerTracking) { }

}

