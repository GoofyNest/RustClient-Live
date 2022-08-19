private sealed class ImmutableStack.EmptyStack<T> : IImmutableStack<T>, IEnumerable<T>, IEnumerable // TypeDefIndex: 4799
{	// Properties
	public int Count { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80
	|-ImmutableStack.EmptyStack<object>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public IImmutableStack<T> Push(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17ECDE0 Offset: 0x17EC1E0 VA: 0x1817ECDE0
	|-ImmutableStack.EmptyStack<object>.Push
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public IImmutableStack<T> Pop() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17ECD80 Offset: 0x17EC180 VA: 0x1817ECD80
	|-ImmutableStack.EmptyStack<object>.Pop
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public T Peek() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17ECD20 Offset: 0x17EC120 VA: 0x1817ECD20
	|-ImmutableStack.EmptyStack<object>.Peek
	*/

	[IteratorStateMachineAttribute] // RVA: 0xD5330 Offset: 0xD4730 VA: 0x1800D5330
	// RVA: -1 Offset: -1 Slot: 8
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17ECCC0 Offset: 0x17EC0C0 VA: 0x1817ECCC0
	|-ImmutableStack.EmptyStack<object>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17ECE60 Offset: 0x17EC260 VA: 0x1817ECE60
	|-ImmutableStack.EmptyStack<object>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD55DC0 Offset: 0xD551C0 VA: 0x180D55DC0
	|-ImmutableStack.EmptyStack<object>..ctor
	*/

}

private sealed class ImmutableStack.EmptyStack.<GetEnumerator>d__5<T> : IEnumerator<T>, IEnumerator, IDisposable // TypeDefIndex: 4800
{	// Fields
	private int <>1__state; // 0x0
	private T <>2__current; // 0x0

	// Properties
	private T System.Collections.Generic.IEnumerator<T>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E3C10 Offset: 0x15E3010 VA: 0x1815E3C10
	|-ImmutableStack.EmptyStack.<GetEnumerator>d__5<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 5
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	|-ImmutableStack.EmptyStack.<GetEnumerator>d__5<object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13CA1C0 Offset: 0x13C95C0 VA: 0x1813CA1C0
	|-ImmutableStack.EmptyStack.<GetEnumerator>d__5<object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 4
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	|-ImmutableStack.EmptyStack.<GetEnumerator>d__5<object>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17F7220 Offset: 0x17F6620 VA: 0x1817F7220
	|-ImmutableStack.EmptyStack.<GetEnumerator>d__5<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	|-ImmutableStack.EmptyStack.<GetEnumerator>d__5<object>.System.Collections.IEnumerator.get_Current
	*/

}

private sealed class ImmutableStack.<GetEnumerator>d__13<T> : IEnumerator<T>, IEnumerator, IDisposable // TypeDefIndex: 4801
{	// Fields
	private int <>1__state; // 0x0
	private T <>2__current; // 0x0
	public ImmutableStack<T> <>4__this; // 0x0
	private IImmutableStack<T> <stack>5__2; // 0x0

	// Properties
	private T System.Collections.Generic.IEnumerator<T>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E3C10 Offset: 0x15E3010 VA: 0x1815E3C10
	|-ImmutableStack.<GetEnumerator>d__13<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 5
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	|-ImmutableStack.<GetEnumerator>d__13<object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17F69C0 Offset: 0x17F5DC0 VA: 0x1817F69C0
	|-ImmutableStack.<GetEnumerator>d__13<object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 4
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	|-ImmutableStack.<GetEnumerator>d__13<object>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17F6B20 Offset: 0x17F5F20 VA: 0x1817F6B20
	|-ImmutableStack.<GetEnumerator>d__13<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	|-ImmutableStack.<GetEnumerator>d__13<object>.System.Collections.IEnumerator.get_Current
	*/

}

