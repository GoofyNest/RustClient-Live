internal sealed class ThreadPoolWorkQueue // TypeDefIndex: 809
{	// Fields
	internal ThreadPoolWorkQueue.QueueSegment queueHead; // 0x10
	internal ThreadPoolWorkQueue.QueueSegment queueTail; // 0x18
	internal static ThreadPoolWorkQueue.SparseArray<ThreadPoolWorkQueue.WorkStealingQueue> allThreadQueues; // 0x0
	private int numOutstandingThreadRequests; // 0x20

	// Methods

	// RVA: 0x1606D30 Offset: 0x1606130 VA: 0x181606D30
	public void .ctor() { }

	// RVA: 0x1606AE0 Offset: 0x1605EE0 VA: 0x181606AE0
	public ThreadPoolWorkQueueThreadLocals EnsureCurrentThreadHasQueue() { }

	// RVA: 0x1606B70 Offset: 0x1605F70 VA: 0x181606B70
	internal void EnsureThreadRequested() { }

	// RVA: 0x1606C70 Offset: 0x1606070 VA: 0x181606C70
	internal void MarkThreadRequestSatisfied() { }

	// RVA: 0x16068C0 Offset: 0x1605CC0 VA: 0x1816068C0
	public void Enqueue(IThreadPoolWorkItem callback, bool forceGlobal) { }

	// RVA: 0x1606C10 Offset: 0x1606010 VA: 0x181606C10
	internal bool LocalFindAndPop(IThreadPoolWorkItem callback) { }

	// RVA: 0x16060A0 Offset: 0x16054A0 VA: 0x1816060A0
	public void Dequeue(ThreadPoolWorkQueueThreadLocals tl, out IThreadPoolWorkItem callback, out bool missedSteal) { }

	// RVA: 0x16063F0 Offset: 0x16057F0 VA: 0x1816063F0
	internal static bool Dispatch() { }

	// RVA: 0x1606CC0 Offset: 0x16060C0 VA: 0x181606CC0
	private static void .cctor() { }

}

internal class ThreadPoolWorkQueue.SparseArray<T> // TypeDefIndex: 810
{	// Fields
	private T[] m_array; // 0x0

	// Properties
	internal T[] Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(int initialSize) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A451F0 Offset: 0x1A445F0 VA: 0x181A451F0
	|-ThreadPoolWorkQueue.SparseArray<object>..ctor
	|-ThreadPoolWorkQueue.SparseArray<ThreadPoolWorkQueue.WorkStealingQueue>..ctor
	*/

	// RVA: -1 Offset: -1
	internal T[] get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13637B0 Offset: 0x1362BB0 VA: 0x1813637B0
	|-ThreadPoolWorkQueue.SparseArray<object>.get_Current
	|-ThreadPoolWorkQueue.SparseArray<ThreadPoolWorkQueue.WorkStealingQueue>.get_Current
	*/

	// RVA: -1 Offset: -1
	internal int Add(T e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A44E10 Offset: 0x1A44210 VA: 0x181A44E10
	|-ThreadPoolWorkQueue.SparseArray<object>.Add
	|-ThreadPoolWorkQueue.SparseArray<ThreadPoolWorkQueue.WorkStealingQueue>.Add
	*/

	// RVA: -1 Offset: -1
	internal void Remove(T e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A45070 Offset: 0x1A44470 VA: 0x181A45070
	|-ThreadPoolWorkQueue.SparseArray<object>.Remove
	|-ThreadPoolWorkQueue.SparseArray<ThreadPoolWorkQueue.WorkStealingQueue>.Remove
	*/

}

internal class ThreadPoolWorkQueue.WorkStealingQueue // TypeDefIndex: 811
{	// Fields
	internal IThreadPoolWorkItem[] m_array; // 0x10
	private int m_mask; // 0x18
	private int m_headIndex; // 0x1C
	private int m_tailIndex; // 0x20
	private SpinLock m_foreignLock; // 0x24

	// Methods

	// RVA: 0x1618D80 Offset: 0x1618180 VA: 0x181618D80
	public void LocalPush(IThreadPoolWorkItem obj) { }

	// RVA: 0x1618730 Offset: 0x1617B30 VA: 0x181618730
	public bool LocalFindAndPop(IThreadPoolWorkItem obj) { }

	// RVA: 0x1618A30 Offset: 0x1617E30 VA: 0x181618A30
	public bool LocalPop(out IThreadPoolWorkItem obj) { }

	// RVA: 0x16194F0 Offset: 0x16188F0 VA: 0x1816194F0
	public bool TrySteal(out IThreadPoolWorkItem obj, ref bool missedSteal) { }

	// RVA: 0x1619230 Offset: 0x1618630 VA: 0x181619230
	private bool TrySteal(out IThreadPoolWorkItem obj, ref bool missedSteal, int millisecondsTimeout) { }

	// RVA: 0x1619510 Offset: 0x1618910 VA: 0x181619510
	public void .ctor() { }

}

internal class ThreadPoolWorkQueue.QueueSegment // TypeDefIndex: 812
{	// Fields
	internal readonly IThreadPoolWorkItem[] nodes; // 0x10
	private int indexes; // 0x18
	public ThreadPoolWorkQueue.QueueSegment Next; // 0x20

	// Methods

	// RVA: 0x1600F50 Offset: 0x1600350 VA: 0x181600F50
	private void GetIndexes(out int upper, out int lower) { }

	// RVA: 0x1600ED0 Offset: 0x16002D0 VA: 0x181600ED0
	private bool CompareExchangeIndexes(ref int prevUpper, int newUpper, ref int prevLower, int newLower) { }

	[ReliabilityContractAttribute] // RVA: 0x83C10 Offset: 0x83010 VA: 0x180083C10
	// RVA: 0x1601210 Offset: 0x1600610 VA: 0x181601210
	public void .ctor() { }

	// RVA: 0x1600F90 Offset: 0x1600390 VA: 0x181600F90
	public bool IsUsedUp() { }

	// RVA: 0x1601130 Offset: 0x1600530 VA: 0x181601130
	public bool TryEnqueue(IThreadPoolWorkItem node) { }

	// RVA: 0x1600FF0 Offset: 0x16003F0 VA: 0x181600FF0
	public bool TryDequeue(out IThreadPoolWorkItem node) { }

}

