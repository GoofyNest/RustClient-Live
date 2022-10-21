private sealed class CircularBuffer.<GetEnumerator>d__26<T> : IEnumerator<T>, IEnumerator, IDisposable // TypeDefIndex: 4836
{
	private int <>1__state; 
	private T <>2__current; 
	public CircularBuffer<T> <>4__this; 
	private IEnumerator<ArraySegment<T>> <>7__wrap1; 
	private ArraySegment<T> <segment>5__3; 
	private int <i>5__4; 

	private T System.Collections.Generic.IEnumerator<T>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] 
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-CircularBuffer.<GetEnumerator>d__26<object>..ctor
	*/

	[DebuggerHiddenAttribute] 
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

	[DebuggerHiddenAttribute] 
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-CircularBuffer.<GetEnumerator>d__26<object>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHiddenAttribute] 
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-CircularBuffer.<GetEnumerator>d__26<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] 
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-CircularBuffer.<GetEnumerator>d__26<object>.System.Collections.IEnumerator.get_Current
	*/

}

private sealed class CircularBuffer.<GetItems>d__15<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 7629
{
	private int <>1__state; 
	private T <>2__current; 
	private int <>l__initialThreadId; 
	private int start; 
	public int <>3__start; 
	public CircularBuffer<T> <>4__this; 
	private int end; 
	public int <>3__end; 
	private int <i>5__2; 

	private T System.Collections.Generic.IEnumerator<T>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] 
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-CircularBuffer.<GetItems>d__15<byte>..ctor
	|
	|-CircularBuffer.<GetItems>d__15<object>..ctor
	*/

	[DebuggerHiddenAttribute] 
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

	[DebuggerHiddenAttribute] 
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-CircularBuffer.<GetItems>d__15<byte>.System.Collections.Generic.IEnumerator<T>.get_Current
	|
	|-CircularBuffer.<GetItems>d__15<object>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHiddenAttribute] 
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-CircularBuffer.<GetItems>d__15<byte>.System.Collections.IEnumerator.Reset
	|
	|-CircularBuffer.<GetItems>d__15<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] 
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-CircularBuffer.<GetItems>d__15<byte>.System.Collections.IEnumerator.get_Current
	|
	|-CircularBuffer.<GetItems>d__15<object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHiddenAttribute] 
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-CircularBuffer.<GetItems>d__15<byte>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-CircularBuffer.<GetItems>d__15<object>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] 
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-CircularBuffer.<GetItems>d__15<byte>.System.Collections.IEnumerable.GetEnumerator
	|-CircularBuffer.<GetItems>d__15<object>.System.Collections.IEnumerable.GetEnumerator
	*/

}

