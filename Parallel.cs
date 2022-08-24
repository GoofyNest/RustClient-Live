public static class Parallel // TypeDefIndex: 5599
{
	public static int MaxThreads; 


	public static void ForEach<T>(IList<T> data, Action<T> action) { }
	/* GenericInstMethod :
	|
	|-Parallel.ForEach<object>
	*/

	public static void ForEach<T>(IList<T> data, int threads, Action<T> action) { }
	/* GenericInstMethod :
	|
	|-Parallel.ForEach<object>
	*/

	public static void For(int fromInclusive, int toExclusive, Action<int> action) { }

	public static void For(int fromInclusive, int toExclusive, int threads, Action<int> action) { }

	public static void Call(Action<int, int> action) { }

	public static void Call(int threads, Action<int, int> action) { }

	[IteratorStateMachineAttribute] 
	public static IEnumerator Coroutine(Action action) { }

	private static void .cctor() { }

}

private sealed class Parallel.<>c__DisplayClass2_0<T> // TypeDefIndex: 5600
{
	public Action<T> action; 
	public IList<T> data; 


	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-Parallel.<>c__DisplayClass2_0<object>..ctor
	*/

	internal void <ForEach>b__0(int i) { }
	/* GenericInstMethod :
	|
	|-Parallel.<>c__DisplayClass2_0<object>.<ForEach>b__0
	*/

}

private sealed class Parallel.<>c__DisplayClass4_0 // TypeDefIndex: 5601
{
	public int chunk_size; 
	public int toExclusive; 
	public Action<int> action; 


	public void .ctor() { }

	internal void <For>b__0(int thread_id) { }

}

private sealed class Parallel.<>c__DisplayClass6_0 // TypeDefIndex: 5602
{
	public Action<int, int> action; 
	public int threads; 


	public void .ctor() { }

	internal void <Call>b__0(int thread_id) { }

}

private sealed class Parallel.<Coroutine>d__7 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 5603
{
	private int <>1__state; 
	private object <>2__current; 
	public Action action; 
	private IAsyncResult <asyncResult>5__2; 

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] 
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] 
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] 
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] 
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] 
	private object System.Collections.IEnumerator.get_Current() { }

}

