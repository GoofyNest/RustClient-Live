private sealed class ImmutableStack.EmptyStack<T> : IImmutableStack<T>, IEnumerable<T>, IEnumerable // TypeDefIndex: 4804
{
	public int Count { get; }


	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-ImmutableStack.EmptyStack<object>.get_Count
	*/

	public IImmutableStack<T> Push(T value) { }
	/* GenericInstMethod :
	|
	|-ImmutableStack.EmptyStack<object>.Push
	*/

	public IImmutableStack<T> Pop() { }
	/* GenericInstMethod :
	|
	|-ImmutableStack.EmptyStack<object>.Pop
	*/

	public T Peek() { }
	/* GenericInstMethod :
	|
	|-ImmutableStack.EmptyStack<object>.Peek
	*/

	[IteratorStateMachineAttribute]
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-ImmutableStack.EmptyStack<object>.GetEnumerator
	*/

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-ImmutableStack.EmptyStack<object>.System.Collections.IEnumerable.GetEnumerator
	*/

	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-ImmutableStack.EmptyStack<object>..ctor
	*/

}

private sealed class ImmutableStack.EmptyStack.<GetEnumerator>d__5<T> : IEnumerator<T>, IEnumerator, IDisposable // TypeDefIndex: 4805
{
	private int <>1__state;
	private T <>2__current;

	private T System.Collections.Generic.IEnumerator<T>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute]
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-ImmutableStack.EmptyStack.<GetEnumerator>d__5<object>..ctor
	*/

	[DebuggerHiddenAttribute]
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-ImmutableStack.EmptyStack.<GetEnumerator>d__5<object>.System.IDisposable.Dispose
	*/

	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-ImmutableStack.EmptyStack.<GetEnumerator>d__5<object>.MoveNext
	*/

	[DebuggerHiddenAttribute]
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-ImmutableStack.EmptyStack.<GetEnumerator>d__5<object>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHiddenAttribute]
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-ImmutableStack.EmptyStack.<GetEnumerator>d__5<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute]
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-ImmutableStack.EmptyStack.<GetEnumerator>d__5<object>.System.Collections.IEnumerator.get_Current
	*/

}

private sealed class ImmutableStack.<GetEnumerator>d__13<T> : IEnumerator<T>, IEnumerator, IDisposable // TypeDefIndex: 4806
{
	private int <>1__state;
	private T <>2__current;
	public ImmutableStack<T> <>4__this;
	private IImmutableStack<T> <stack>5__2;

	private T System.Collections.Generic.IEnumerator<T>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute]
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-ImmutableStack.<GetEnumerator>d__13<object>..ctor
	*/

	[DebuggerHiddenAttribute]
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-ImmutableStack.<GetEnumerator>d__13<object>.System.IDisposable.Dispose
	*/

	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-ImmutableStack.<GetEnumerator>d__13<object>.MoveNext
	*/

	[DebuggerHiddenAttribute]
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-ImmutableStack.<GetEnumerator>d__13<object>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHiddenAttribute]
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-ImmutableStack.<GetEnumerator>d__13<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute]
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-ImmutableStack.<GetEnumerator>d__13<object>.System.Collections.IEnumerator.get_Current
	*/

}

