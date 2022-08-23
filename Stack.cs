public class Stack : ICollection, IEnumerable, ICloneable // TypeDefIndex: 1423
{
[DebuggerDisplayAttribute] // RVA: 0xEA070 Offset: 0xE9470 VA: 0x1800EA070
[DebuggerTypeProxyAttribute] // RVA: 0xEA070 Offset: 0xE9470 VA: 0x1800EA070
[ComVisibleAttribute] // RVA: 0xEA070 Offset: 0xE9470 VA: 0x1800EA070
[Serializable]
public class Stack : ICollection, IEnumerable, ICloneable // TypeDefIndex: 1423
	private object[] _array; // 0x10
	private int _size; // 0x18
	private int _version; // 0x1C
	private object _syncRoot; // 0x20

	public virtual int Count { get; }
	public virtual object SyncRoot { get; }


	public void .ctor() { }

	public void .ctor(int initialCapacity) { }

	public virtual int get_Count() { }

	public virtual object get_SyncRoot() { }

	public virtual void Clear() { }

	public virtual object Clone() { }

	public virtual void CopyTo(Array array, int index) { }

	public virtual IEnumerator GetEnumerator() { }

	public virtual object Peek() { }

	public virtual object Pop() { }

	public virtual void Push(object obj) { }

}

private class Stack.StackEnumerator : IEnumerator, ICloneable // TypeDefIndex: 1424
{	private Stack _stack; // 0x10
	private int _index; // 0x18
	private int _version; // 0x1C
	private object currentElement; // 0x20

	public virtual object Current { get; }


	internal void .ctor(Stack stack) { }

	public object Clone() { }

	public virtual bool MoveNext() { }

	public virtual object get_Current() { }

	public virtual void Reset() { }

}

public struct Stack.Enumerator<T> : IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 3153
{	private readonly Stack<T> _stack; // 0x0
	private readonly int _version; // 0x0
	private int _index; // 0x0
	private T _currentElement; // 0x0

	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	internal void .ctor(Stack<T> stack) { }
	/* GenericInstMethod :
	|
	|-Stack.Enumerator<KeyValuePair<int, int>>..ctor
	|-Stack.Enumerator<IntPtr>..ctor
	|-Stack.Enumerator<object>..ctor
	|-Stack.Enumerator<Vector2>..ctor
	|
	|-Stack.Enumerator<SequenceNode.SequenceConstructPosContext>..ctor
	|
	|-Stack.Enumerator<Matrix4x4>..ctor
	|
	|-Stack.Enumerator<EventDispatcher.DispatchContext>..ctor
	*/

	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-Stack.Enumerator<Poolable>.Dispose
	|-Stack.Enumerator<KeyValuePair<int, int>>.Dispose
	|-Stack.Enumerator<IntPtr>.Dispose
	|-Stack.Enumerator<object>.Dispose
	|-Stack.Enumerator<SequenceNode.SequenceConstructPosContext>.Dispose
	|-Stack.Enumerator<Matrix4x4>.Dispose
	|-Stack.Enumerator<Object>.Dispose
	|-Stack.Enumerator<EventDispatcher.DispatchContext>.Dispose
	|-Stack.Enumerator<Vector2>.Dispose
	*/

	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-Stack.Enumerator<Poolable>.MoveNext
	|-Stack.Enumerator<object>.MoveNext
	|-Stack.Enumerator<Object>.MoveNext
	|
	|-Stack.Enumerator<KeyValuePair<int, int>>.MoveNext
	|
	|-Stack.Enumerator<IntPtr>.MoveNext
	|
	|-Stack.Enumerator<SequenceNode.SequenceConstructPosContext>.MoveNext
	|
	|-Stack.Enumerator<Matrix4x4>.MoveNext
	|
	|-Stack.Enumerator<EventDispatcher.DispatchContext>.MoveNext
	|
	|-Stack.Enumerator<Vector2>.MoveNext
	*/

	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-Stack.Enumerator<Poolable>.get_Current
	|-Stack.Enumerator<Object>.get_Current
	|-Stack.Enumerator<object>.get_Current
	|
	|-Stack.Enumerator<KeyValuePair<int, int>>.get_Current
	|
	|-Stack.Enumerator<IntPtr>.get_Current
	|
	|-Stack.Enumerator<SequenceNode.SequenceConstructPosContext>.get_Current
	|
	|-Stack.Enumerator<Matrix4x4>.get_Current
	|
	|-Stack.Enumerator<EventDispatcher.DispatchContext>.get_Current
	|
	|-Stack.Enumerator<Vector2>.get_Current
	*/

	private void ThrowEnumerationNotStartedOrEnded() { }
	/* GenericInstMethod :
	|
	|-Stack.Enumerator<KeyValuePair<int, int>>.ThrowEnumerationNotStartedOrEnded
	|
	|-Stack.Enumerator<IntPtr>.ThrowEnumerationNotStartedOrEnded
	|
	|-Stack.Enumerator<object>.ThrowEnumerationNotStartedOrEnded
	|
	|-Stack.Enumerator<SequenceNode.SequenceConstructPosContext>.ThrowEnumerationNotStartedOrEnded
	|
	|-Stack.Enumerator<Matrix4x4>.ThrowEnumerationNotStartedOrEnded
	|
	|-Stack.Enumerator<EventDispatcher.DispatchContext>.ThrowEnumerationNotStartedOrEnded
	|
	|-Stack.Enumerator<Vector2>.ThrowEnumerationNotStartedOrEnded
	*/

	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-Stack.Enumerator<KeyValuePair<int, int>>.System.Collections.IEnumerator.get_Current
	|
	|-Stack.Enumerator<IntPtr>.System.Collections.IEnumerator.get_Current
	|
	|-Stack.Enumerator<object>.System.Collections.IEnumerator.get_Current
	|
	|-Stack.Enumerator<SequenceNode.SequenceConstructPosContext>.System.Collections.IEnumerator.get_Current
	|
	|-Stack.Enumerator<Matrix4x4>.System.Collections.IEnumerator.get_Current
	|
	|-Stack.Enumerator<EventDispatcher.DispatchContext>.System.Collections.IEnumerator.get_Current
	|
	|-Stack.Enumerator<Vector2>.System.Collections.IEnumerator.get_Current
	*/

	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-Stack.Enumerator<KeyValuePair<int, int>>.System.Collections.IEnumerator.Reset
	|
	|-Stack.Enumerator<IntPtr>.System.Collections.IEnumerator.Reset
	|
	|-Stack.Enumerator<object>.System.Collections.IEnumerator.Reset
	|
	|-Stack.Enumerator<SequenceNode.SequenceConstructPosContext>.System.Collections.IEnumerator.Reset
	|
	|-Stack.Enumerator<Matrix4x4>.System.Collections.IEnumerator.Reset
	|
	|-Stack.Enumerator<EventDispatcher.DispatchContext>.System.Collections.IEnumerator.Reset
	|
	|-Stack.Enumerator<Vector2>.System.Collections.IEnumerator.Reset
	*/

}

