private sealed class CircularBuffer.<GetEnumerator>d__26<T> : IEnumerator<T>, IEnumerator, IDisposable // TypeDefIndex: 4832
{	private int <>1__state; // 0x0
	private T <>2__current; // 0x0
	public CircularBuffer<T> <>4__this; // 0x0
	private IEnumerator<ArraySegment<T>> <>7__wrap1; // 0x0
	private ArraySegment<T> <segment>5__3; // 0x0
	private int <i>5__4; // 0x0

	private T System.Collections.Generic.IEnumerator<T>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-CircularBuffer.<GetEnumerator>d__26<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-CircularBuffer.<GetEnumerator>d__26<object>.System.IDisposable.Dispose
	*/

	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-CircularBuffer.<GetEnumerator>d__26<object>.MoveNext
	*/

	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-CircularBuffer.<GetEnumerator>d__26<object>.<>m__Finally1
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-CircularBuffer.<GetEnumerator>d__26<object>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-CircularBuffer.<GetEnumerator>d__26<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-CircularBuffer.<GetEnumerator>d__26<object>.System.Collections.IEnumerator.get_Current
	*/

}

private sealed class CircularBuffer.<GetItems>d__15<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 7621
{	private int <>1__state; // 0x0
	private T <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private int start; // 0x0
	public int <>3__start; // 0x0
	public CircularBuffer<T> <>4__this; // 0x0
	private int end; // 0x0
	public int <>3__end; // 0x0
	private int <i>5__2; // 0x0

	private T System.Collections.Generic.IEnumerator<T>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-CircularBuffer.<GetItems>d__15<byte>..ctor
	|
	|-CircularBuffer.<GetItems>d__15<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-CircularBuffer.<GetItems>d__15<byte>.System.IDisposable.Dispose
	|-CircularBuffer.<GetItems>d__15<object>.System.IDisposable.Dispose
	*/

	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-CircularBuffer.<GetItems>d__15<byte>.MoveNext
	|
	|-CircularBuffer.<GetItems>d__15<object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-CircularBuffer.<GetItems>d__15<byte>.System.Collections.Generic.IEnumerator<T>.get_Current
	|
	|-CircularBuffer.<GetItems>d__15<object>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-CircularBuffer.<GetItems>d__15<byte>.System.Collections.IEnumerator.Reset
	|
	|-CircularBuffer.<GetItems>d__15<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-CircularBuffer.<GetItems>d__15<byte>.System.Collections.IEnumerator.get_Current
	|
	|-CircularBuffer.<GetItems>d__15<object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-CircularBuffer.<GetItems>d__15<byte>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-CircularBuffer.<GetItems>d__15<object>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-CircularBuffer.<GetItems>d__15<byte>.System.Collections.IEnumerable.GetEnumerator
	|-CircularBuffer.<GetItems>d__15<object>.System.Collections.IEnumerable.GetEnumerator
	*/

}

