public static class Parallel // TypeDefIndex: 5599
{	public static int MaxThreads; // 0x25E0


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

	[IteratorStateMachineAttribute] // RVA: 0xB66C0 Offset: 0xB5AC0 VA: 0x1800B66C0
	public static IEnumerator Coroutine(Action action) { }

	private static void .cctor() { }

}

private sealed class Parallel.<>c__DisplayClass2_0<T> // TypeDefIndex: 5600
{	public Action<T> action; // 0x0
	public IList<T> data; // 0x0


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
{	public int chunk_size; // 0x10
	public int toExclusive; // 0x14
	public Action<int> action; // 0x18


	public void .ctor() { }

	internal void <For>b__0(int thread_id) { }

}

private sealed class Parallel.<>c__DisplayClass6_0 // TypeDefIndex: 5602
{	public Action<int, int> action; // 0x10
	public int threads; // 0x18


	public void .ctor() { }

	internal void <Call>b__0(int thread_id) { }

}

private sealed class Parallel.<Coroutine>d__7 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 5603
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Action action; // 0x20
	private IAsyncResult <asyncResult>5__2; // 0x28

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.IEnumerator.get_Current() { }

}

