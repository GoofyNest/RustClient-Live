internal sealed class ThreadPoolWorkQueue // TypeDefIndex: 809
{
	internal ThreadPoolWorkQueue.QueueSegment queueHead; 
	internal ThreadPoolWorkQueue.QueueSegment queueTail; 
	internal static ThreadPoolWorkQueue.SparseArray<ThreadPoolWorkQueue.WorkStealingQueue> allThreadQueues; 
	private int numOutstandingThreadRequests; 


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
{
	private T[] m_array; 

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
{
	internal IThreadPoolWorkItem[] m_array; 
	private int m_mask; 
	private int m_headIndex; 
	private int m_tailIndex; 
	private SpinLock m_foreignLock; 


public void LocalPush(IThreadPoolWorkItem obj) { }

public bool LocalFindAndPop(IThreadPoolWorkItem obj) { }

public bool LocalPop(out IThreadPoolWorkItem obj) { }

public bool TrySteal(out IThreadPoolWorkItem obj, ref bool missedSteal) { }

private bool TrySteal(out IThreadPoolWorkItem obj, ref bool missedSteal, int millisecondsTimeout) { }

public void .ctor() { }

}

internal class ThreadPoolWorkQueue.QueueSegment // TypeDefIndex: 812
{
	internal readonly IThreadPoolWorkItem[] nodes; 
	private int indexes; 
	public ThreadPoolWorkQueue.QueueSegment Next; 


private void GetIndexes(out int upper, out int lower) { }

private bool CompareExchangeIndexes(ref int prevUpper, int newUpper, ref int prevLower, int newLower) { }

	[ReliabilityContractAttribute] 
public void .ctor() { }

public bool IsUsedUp() { }

public bool TryEnqueue(IThreadPoolWorkItem node) { }

public bool TryDequeue(out IThreadPoolWorkItem node) { }

}

