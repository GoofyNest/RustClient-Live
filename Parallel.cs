public static class Parallel // TypeDefIndex: 5599
{	// Fields
	public static int MaxThreads; // 0x25E0

	// Methods

	// RVA: -1 Offset: -1
	public static void ForEach<T>(IList<T> data, Action<T> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5EC6F0 Offset: 0x5EBAF0 VA: 0x1805EC6F0
	|-Parallel.ForEach<object>
	*/

	// RVA: -1 Offset: -1
	public static void ForEach<T>(IList<T> data, int threads, Action<T> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5EC780 Offset: 0x5EBB80 VA: 0x1805EC780
	|-Parallel.ForEach<object>
	*/

	// RVA: 0x21B7A80 Offset: 0x21B6E80 VA: 0x1821B7A80
	public static void For(int fromInclusive, int toExclusive, Action<int> action) { }

	// RVA: 0x21B7830 Offset: 0x21B6C30 VA: 0x1821B7830
	public static void For(int fromInclusive, int toExclusive, int threads, Action<int> action) { }

	// RVA: 0x21B7750 Offset: 0x21B6B50 VA: 0x1821B7750
	public static void Call(Action<int, int> action) { }

	// RVA: 0x21B7520 Offset: 0x21B6920 VA: 0x1821B7520
	public static void Call(int threads, Action<int, int> action) { }

	[IteratorStateMachineAttribute] // RVA: 0xB66C0 Offset: 0xB5AC0 VA: 0x1800B66C0
	// RVA: 0x21B77C0 Offset: 0x21B6BC0 VA: 0x1821B77C0
	public static IEnumerator Coroutine(Action action) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private static void .cctor() { }

}

private sealed class Parallel.<>c__DisplayClass2_0<T> // TypeDefIndex: 5600
{	// Fields
	public Action<T> action; // 0x0
	public IList<T> data; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD55DC0 Offset: 0xD551C0 VA: 0x180D55DC0
	|-Parallel.<>c__DisplayClass2_0<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <ForEach>b__0(int i) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19C2190 Offset: 0x19C1590 VA: 0x1819C2190
	|-Parallel.<>c__DisplayClass2_0<object>.<ForEach>b__0
	*/

}

private sealed class Parallel.<>c__DisplayClass4_0 // TypeDefIndex: 5601
{	// Fields
	public int chunk_size; // 0x10
	public int toExclusive; // 0x14
	public Action<int> action; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x21B8CB0 Offset: 0x21B80B0 VA: 0x1821B8CB0
	internal void <For>b__0(int thread_id) { }

}

private sealed class Parallel.<>c__DisplayClass6_0 // TypeDefIndex: 5602
{	// Fields
	public Action<int, int> action; // 0x10
	public int threads; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x21B8D60 Offset: 0x21B8160 VA: 0x1821B8D60
	internal void <Call>b__0(int thread_id) { }

}

private sealed class Parallel.<Coroutine>d__7 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 5603
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Action action; // 0x20
	private IAsyncResult <asyncResult>5__2; // 0x28

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497770 Offset: 0x496B70 VA: 0x180497770
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x21B8B10 Offset: 0x21B7F10 VA: 0x1821B8B10 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x21B8C60 Offset: 0x21B8060 VA: 0x1821B8C60 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

