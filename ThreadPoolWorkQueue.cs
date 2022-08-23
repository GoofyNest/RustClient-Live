internal sealed class ThreadPoolWorkQueue // TypeDefIndex: 809
{	internal ThreadPoolWorkQueue.QueueSegment queueHead; // 0x10
	internal ThreadPoolWorkQueue.QueueSegment queueTail; // 0x18
	internal static ThreadPoolWorkQueue.SparseArray<ThreadPoolWorkQueue.WorkStealingQueue> allThreadQueues; // 0x0
	private int numOutstandingThreadRequests; // 0x20


	public void .ctor() { }

	public ThreadPoolWorkQueueThreadLocals EnsureCurrentThreadHasQueue() { }

	internal void EnsureThreadRequested() { }

	internal void MarkThreadRequestSatisfied() { }

	public void Enqueue(IThreadPoolWorkItem callback, bool forceGlobal) { }

	internal bool LocalFindAndPop(IThreadPoolWorkItem callback) { }

	public void Dequeue(ThreadPoolWorkQueueThreadLocals tl, out IThreadPoolWorkItem callback, out bool missedSteal) { }

	internal static bool Dispatch() { }

	private static void .cctor() { }

}

internal class ThreadPoolWorkQueue.SparseArray<T> // TypeDefIndex: 810
{	private T[] m_array; // 0x0

	internal T[] Current { get; }


	internal void .ctor(int initialSize) { }
	/* GenericInstMethod :
	|
	|-ThreadPoolWorkQueue.SparseArray<object>..ctor
	|-ThreadPoolWorkQueue.SparseArray<ThreadPoolWorkQueue.WorkStealingQueue>..ctor
	*/

	internal T[] get_Current() { }
	/* GenericInstMethod :
	|
	|-ThreadPoolWorkQueue.SparseArray<object>.get_Current
	|-ThreadPoolWorkQueue.SparseArray<ThreadPoolWorkQueue.WorkStealingQueue>.get_Current
	*/

	internal int Add(T e) { }
	/* GenericInstMethod :
	|
	|-ThreadPoolWorkQueue.SparseArray<object>.Add
	|-ThreadPoolWorkQueue.SparseArray<ThreadPoolWorkQueue.WorkStealingQueue>.Add
	*/

	internal void Remove(T e) { }
	/* GenericInstMethod :
	|
	|-ThreadPoolWorkQueue.SparseArray<object>.Remove
	|-ThreadPoolWorkQueue.SparseArray<ThreadPoolWorkQueue.WorkStealingQueue>.Remove
	*/

}

internal class ThreadPoolWorkQueue.WorkStealingQueue // TypeDefIndex: 811
{	internal IThreadPoolWorkItem[] m_array; // 0x10
	private int m_mask; // 0x18
	private int m_headIndex; // 0x1C
	private int m_tailIndex; // 0x20
	private SpinLock m_foreignLock; // 0x24


	public void LocalPush(IThreadPoolWorkItem obj) { }

	public bool LocalFindAndPop(IThreadPoolWorkItem obj) { }

	public bool LocalPop(out IThreadPoolWorkItem obj) { }

	public bool TrySteal(out IThreadPoolWorkItem obj, ref bool missedSteal) { }

	private bool TrySteal(out IThreadPoolWorkItem obj, ref bool missedSteal, int millisecondsTimeout) { }

	public void .ctor() { }

}

internal class ThreadPoolWorkQueue.QueueSegment // TypeDefIndex: 812
{	internal readonly IThreadPoolWorkItem[] nodes; // 0x10
	private int indexes; // 0x18
	public ThreadPoolWorkQueue.QueueSegment Next; // 0x20


	private void GetIndexes(out int upper, out int lower) { }

	private bool CompareExchangeIndexes(ref int prevUpper, int newUpper, ref int prevLower, int newLower) { }

	[ReliabilityContractAttribute] // RVA: 0x83C10 Offset: 0x83010 VA: 0x180083C10
	public void .ctor() { }

	public bool IsUsedUp() { }

	public bool TryEnqueue(IThreadPoolWorkItem node) { }

	public bool TryDequeue(out IThreadPoolWorkItem node) { }

}

