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
	|-RVA: 0x22F4F0 Offset: 0x22E8F0 VA: 0x18022F4F0
	|-Stack.Enumerator<KeyValuePair<int, int>>..ctor
	|-Stack.Enumerator<IntPtr>..ctor
	|-Stack.Enumerator<object>..ctor
	|-Stack.Enumerator<Vector2>..ctor
	|
	|-RVA: 0x22F5F0 Offset: 0x22E9F0 VA: 0x18022F5F0
	|-Stack.Enumerator<SequenceNode.SequenceConstructPosContext>..ctor
	|
	|-RVA: 0x22F590 Offset: 0x22E990 VA: 0x18022F590
	|-Stack.Enumerator<Matrix4x4>..ctor
	|
	|-RVA: 0x22F540 Offset: 0x22E940 VA: 0x18022F540
	|-Stack.Enumerator<EventDispatcher.DispatchContext>..ctor
	*/

	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22E750 Offset: 0x22DB50 VA: 0x18022E750
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
	|-RVA: 0x22E9C0 Offset: 0x22DDC0 VA: 0x18022E9C0
	|-Stack.Enumerator<Poolable>.MoveNext
	|-Stack.Enumerator<object>.MoveNext
	|-Stack.Enumerator<Object>.MoveNext
	|
	|-RVA: 0x22EAE0 Offset: 0x22DEE0 VA: 0x18022EAE0
	|-Stack.Enumerator<KeyValuePair<int, int>>.MoveNext
	|
	|-RVA: 0x22E8B0 Offset: 0x22DCB0 VA: 0x18022E8B0
	|-Stack.Enumerator<IntPtr>.MoveNext
	|
	|-RVA: 0x22EBF0 Offset: 0x22DFF0 VA: 0x18022EBF0
	|-Stack.Enumerator<SequenceNode.SequenceConstructPosContext>.MoveNext
	|
	|-RVA: 0x22E770 Offset: 0x22DB70 VA: 0x18022E770
	|-Stack.Enumerator<Matrix4x4>.MoveNext
	|
	|-RVA: 0x22EC00 Offset: 0x22E000 VA: 0x18022EC00
	|-Stack.Enumerator<EventDispatcher.DispatchContext>.MoveNext
	|
	|-RVA: 0x22E760 Offset: 0x22DB60 VA: 0x18022E760
	|-Stack.Enumerator<Vector2>.MoveNext
	*/

	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22F800 Offset: 0x22EC00 VA: 0x18022F800
	|-Stack.Enumerator<Poolable>.get_Current
	|-Stack.Enumerator<Object>.get_Current
	|-Stack.Enumerator<object>.get_Current
	|
	|-RVA: 0x22F770 Offset: 0x22EB70 VA: 0x18022F770
	|-Stack.Enumerator<KeyValuePair<int, int>>.get_Current
	|
	|-RVA: 0x22F6A0 Offset: 0x22EAA0 VA: 0x18022F6A0
	|-Stack.Enumerator<IntPtr>.get_Current
	|
	|-RVA: 0x22F720 Offset: 0x22EB20 VA: 0x18022F720
	|-Stack.Enumerator<SequenceNode.SequenceConstructPosContext>.get_Current
	|
	|-RVA: 0x22F640 Offset: 0x22EA40 VA: 0x18022F640
	|-Stack.Enumerator<Matrix4x4>.get_Current
	|
	|-RVA: 0x22F6E0 Offset: 0x22EAE0 VA: 0x18022F6E0
	|-Stack.Enumerator<EventDispatcher.DispatchContext>.get_Current
	|
	|-RVA: 0x22F7B0 Offset: 0x22EBB0 VA: 0x18022F7B0
	|-Stack.Enumerator<Vector2>.get_Current
	*/

	private void ThrowEnumerationNotStartedOrEnded() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22F480 Offset: 0x22E880 VA: 0x18022F480
	|-Stack.Enumerator<KeyValuePair<int, int>>.ThrowEnumerationNotStartedOrEnded
	|
	|-RVA: 0x22F4B0 Offset: 0x22E8B0 VA: 0x18022F4B0
	|-Stack.Enumerator<IntPtr>.ThrowEnumerationNotStartedOrEnded
	|
	|-RVA: 0x22F4E0 Offset: 0x22E8E0 VA: 0x18022F4E0
	|-Stack.Enumerator<object>.ThrowEnumerationNotStartedOrEnded
	|
	|-RVA: 0x22F490 Offset: 0x22E890 VA: 0x18022F490
	|-Stack.Enumerator<SequenceNode.SequenceConstructPosContext>.ThrowEnumerationNotStartedOrEnded
	|
	|-RVA: 0x22F4D0 Offset: 0x22E8D0 VA: 0x18022F4D0
	|-Stack.Enumerator<Matrix4x4>.ThrowEnumerationNotStartedOrEnded
	|
	|-RVA: 0x22F4A0 Offset: 0x22E8A0 VA: 0x18022F4A0
	|-Stack.Enumerator<EventDispatcher.DispatchContext>.ThrowEnumerationNotStartedOrEnded
	|
	|-RVA: 0x22F4C0 Offset: 0x22E8C0 VA: 0x18022F4C0
	|-Stack.Enumerator<Vector2>.ThrowEnumerationNotStartedOrEnded
	*/

	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22F130 Offset: 0x22E530 VA: 0x18022F130
	|-Stack.Enumerator<KeyValuePair<int, int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x22F3D0 Offset: 0x22E7D0 VA: 0x18022F3D0
	|-Stack.Enumerator<IntPtr>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x22F370 Offset: 0x22E770 VA: 0x18022F370
	|-Stack.Enumerator<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x22EFB0 Offset: 0x22E3B0 VA: 0x18022EFB0
	|-Stack.Enumerator<SequenceNode.SequenceConstructPosContext>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x22F1E0 Offset: 0x22E5E0 VA: 0x18022F1E0
	|-Stack.Enumerator<Matrix4x4>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x22F080 Offset: 0x22E480 VA: 0x18022F080
	|-Stack.Enumerator<EventDispatcher.DispatchContext>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x22F2B0 Offset: 0x22E6B0 VA: 0x18022F2B0
	|-Stack.Enumerator<Vector2>.System.Collections.IEnumerator.get_Current
	*/

	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22ED10 Offset: 0x22E110 VA: 0x18022ED10
	|-Stack.Enumerator<KeyValuePair<int, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x22EEB0 Offset: 0x22E2B0 VA: 0x18022EEB0
	|-Stack.Enumerator<IntPtr>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x22EC10 Offset: 0x22E010 VA: 0x18022EC10
	|-Stack.Enumerator<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x22ED90 Offset: 0x22E190 VA: 0x18022ED90
	|-Stack.Enumerator<SequenceNode.SequenceConstructPosContext>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x22EE20 Offset: 0x22E220 VA: 0x18022EE20
	|-Stack.Enumerator<Matrix4x4>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x22EF30 Offset: 0x22E330 VA: 0x18022EF30
	|-Stack.Enumerator<EventDispatcher.DispatchContext>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x22EC90 Offset: 0x22E090 VA: 0x18022EC90
	|-Stack.Enumerator<Vector2>.System.Collections.IEnumerator.Reset
	*/

}

