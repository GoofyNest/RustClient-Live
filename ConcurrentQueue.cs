private sealed class ConcurrentQueue.Segment<T> // TypeDefIndex: 1437
{
	internal readonly ConcurrentQueue.Segment.Slot<T>[] _slots; 
	internal readonly int _slotsMask; 
	internal PaddedHeadAndTail _headAndTail; 
	internal bool _preservedForObservation; 
	internal bool _frozenForEnqueues; 
	internal ConcurrentQueue.Segment<T> _nextSegment; 

internal int Capacity { get; }
internal int FreezeOffset { get; }


public void .ctor(int boundedLength) { }
/* GenericInstMethod :
|
|-ConcurrentQueue.Segment<SteamNetworkingUtils.DebugMessage>..ctor
|
|-ConcurrentQueue.Segment<object>..ctor
*/

internal int get_Capacity() { }
/* GenericInstMethod :
|
|-ConcurrentQueue.Segment<SteamNetworkingUtils.DebugMessage>.get_Capacity
|-ConcurrentQueue.Segment<object>.get_Capacity
*/

internal int get_FreezeOffset() { }
/* GenericInstMethod :
|
|-ConcurrentQueue.Segment<SteamNetworkingUtils.DebugMessage>.get_FreezeOffset
|-ConcurrentQueue.Segment<object>.get_FreezeOffset
*/

internal void EnsureFrozenForEnqueues() { }
/* GenericInstMethod :
|
|-ConcurrentQueue.Segment<SteamNetworkingUtils.DebugMessage>.EnsureFrozenForEnqueues
|-ConcurrentQueue.Segment<object>.EnsureFrozenForEnqueues
*/

public bool TryDequeue(out T item) { }
/* GenericInstMethod :
|
|-ConcurrentQueue.Segment<SteamNetworkingUtils.DebugMessage>.TryDequeue
|
|-ConcurrentQueue.Segment<object>.TryDequeue
*/

public bool TryPeek(out T result, bool resultUsed) { }
/* GenericInstMethod :
|
|-ConcurrentQueue.Segment<SteamNetworkingUtils.DebugMessage>.TryPeek
|
|-ConcurrentQueue.Segment<object>.TryPeek
*/

public bool TryEnqueue(T item) { }
/* GenericInstMethod :
|
|-ConcurrentQueue.Segment<SteamNetworkingUtils.DebugMessage>.TryEnqueue
|
|-ConcurrentQueue.Segment<object>.TryEnqueue
*/

}

internal struct ConcurrentQueue.Segment.Slot<T> // TypeDefIndex: 1438
{
	public T Item; 
	public int SequenceNumber; 

}

private sealed class ConcurrentQueue.<Enumerate>d__27<T> : IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 1439
{
	private int <>1__state; 
	private T <>2__current; 
	public ConcurrentQueue.Segment<T> head; 
	public ConcurrentQueue.Segment<T> tail; 
	public int tailTail; 
	public int headHead; 
	public ConcurrentQueue<T> <>4__this; 
	private int <i>5__1; 
	private int <headTail>5__2; 
	private int <i>5__3; 
	private int <i>5__4; 
	private ConcurrentQueue.Segment<T> <s>5__5; 
	private int <i>5__6; 
	private int <sTail>5__7; 
	private int <i>5__8; 

private T System.Collections.Generic.IEnumerator<T>.Current { get; }
private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] 
public void .ctor(int <>1__state) { }
/* GenericInstMethod :
|
|-ConcurrentQueue.<Enumerate>d__27<SteamNetworkingUtils.DebugMessage>..ctor
|-ConcurrentQueue.<Enumerate>d__27<object>..ctor
*/

	[DebuggerHiddenAttribute] 
private void System.IDisposable.Dispose() { }
/* GenericInstMethod :
|
|-ConcurrentQueue.<Enumerate>d__27<SteamNetworkingUtils.DebugMessage>.System.IDisposable.Dispose
|-ConcurrentQueue.<Enumerate>d__27<object>.System.IDisposable.Dispose
*/

private bool MoveNext() { }
/* GenericInstMethod :
|
|-ConcurrentQueue.<Enumerate>d__27<SteamNetworkingUtils.DebugMessage>.MoveNext
|
|-ConcurrentQueue.<Enumerate>d__27<object>.MoveNext
*/

	[DebuggerHiddenAttribute] 
private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
/* GenericInstMethod :
|
|-ConcurrentQueue.<Enumerate>d__27<SteamNetworkingUtils.DebugMessage>.System.Collections.Generic.IEnumerator<T>.get_Current
|
|-ConcurrentQueue.<Enumerate>d__27<object>.System.Collections.Generic.IEnumerator<T>.get_Current
*/

	[DebuggerHiddenAttribute] 
private void System.Collections.IEnumerator.Reset() { }
/* GenericInstMethod :
|
|-ConcurrentQueue.<Enumerate>d__27<SteamNetworkingUtils.DebugMessage>.System.Collections.IEnumerator.Reset
|
|-ConcurrentQueue.<Enumerate>d__27<object>.System.Collections.IEnumerator.Reset
*/

	[DebuggerHiddenAttribute] 
private object System.Collections.IEnumerator.get_Current() { }
/* GenericInstMethod :
|
|-ConcurrentQueue.<Enumerate>d__27<SteamNetworkingUtils.DebugMessage>.System.Collections.IEnumerator.get_Current
|
|-ConcurrentQueue.<Enumerate>d__27<object>.System.Collections.IEnumerator.get_Current
*/

}

