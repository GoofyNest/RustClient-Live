public static class ThreadPool // TypeDefIndex: 816
{	// Methods

	// RVA: 0x16070B0 Offset: 0x16064B0 VA: 0x1816070B0
	private static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, uint millisecondsTimeOutInterval, bool executeOnlyOnce, ref StackCrawlMark stackMark, bool compressStack) { }

	// RVA: 0x1607270 Offset: 0x1606670 VA: 0x181607270
	public static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, TimeSpan timeout, bool executeOnlyOnce) { }

	// RVA: 0x1607080 Offset: 0x1606480 VA: 0x181607080
	public static bool QueueUserWorkItem(WaitCallback callBack, object state) { }

	// RVA: 0x1607050 Offset: 0x1606450 VA: 0x181607050
	public static bool QueueUserWorkItem(WaitCallback callBack) { }

	// RVA: 0x1607700 Offset: 0x1606B00 VA: 0x181607700
	public static bool UnsafeQueueUserWorkItem(WaitCallback callBack, object state) { }

	// RVA: 0x1606ED0 Offset: 0x16062D0 VA: 0x181606ED0
	private static bool QueueUserWorkItemHelper(WaitCallback callBack, object state, ref StackCrawlMark stackMark, bool compressStack) { }

	// RVA: 0x1607620 Offset: 0x1606A20 VA: 0x181607620
	internal static void UnsafeQueueCustomWorkItem(IThreadPoolWorkItem workItem, bool forceGlobal) { }

	// RVA: 0x1607520 Offset: 0x1606920 VA: 0x181607520
	internal static bool TryPopCustomWorkItem(IThreadPoolWorkItem workItem) { }

	// RVA: 0x1607510 Offset: 0x1606910 VA: 0x181607510
	internal static bool RequestWorkerThread() { }

	// RVA: 0x1606DF0 Offset: 0x16061F0 VA: 0x181606DF0
	private static void EnsureVMInitialized() { }

	// RVA: 0x1606EB0 Offset: 0x16062B0 VA: 0x181606EB0
	internal static bool NotifyWorkItemComplete() { }

	// RVA: 0xD6DE90 Offset: 0xD6D290 VA: 0x180D6DE90
	internal static void ReportThreadStatus(bool isWorking) { }

	// RVA: 0x16056D0 Offset: 0x1604AD0 VA: 0x1816056D0
	internal static void NotifyWorkItemProgress() { }

	// RVA: 0x1606EC0 Offset: 0x16062C0 VA: 0x181606EC0
	internal static void NotifyWorkItemProgressNative() { }

	// RVA: 0xD64760 Offset: 0xD63B60 VA: 0x180D64760
	internal static bool IsThreadPoolHosted() { }

	// RVA: 0x1606EA0 Offset: 0x16062A0 VA: 0x181606EA0
	private static void InitializeVMTp(ref bool enableWorkerTracking) { }

}

