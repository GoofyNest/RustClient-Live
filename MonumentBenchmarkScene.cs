public class MonumentBenchmarkScene : BenchmarkScene // TypeDefIndex: 8257
{	// Fields
	public string[] monumentPrefabs; // 0x40
	public Transform[] vantagePoints; // 0x48
	private bool isFinished; // 0x50

	// Properties
	public override bool SubmitsOwnResults { get; }

	// Methods

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 4
	public override bool get_SubmitsOwnResults() { }

	// RVA: 0x778E50 Offset: 0x778250 VA: 0x180778E50 Slot: 7
	public override void StartBenchmark() { }

	[IteratorStateMachineAttribute] // RVA: 0xA2560 Offset: 0xA1960 VA: 0x1800A2560
	// RVA: 0x778DD0 Offset: 0x7781D0 VA: 0x180778DD0
	private IEnumerator DoMonumentBenchmark() { }

	// RVA: 0x778E40 Offset: 0x778240 VA: 0x180778E40 Slot: 5
	public override bool ShouldEnd() { }

	// RVA: 0x778ED0 Offset: 0x7782D0 VA: 0x180778ED0
	public void .ctor() { }

}

private sealed class MonumentBenchmarkScene.<DoMonumentBenchmark>d__6 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 8258
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public MonumentBenchmarkScene <>4__this; // 0x20
	private int <prefabNum>5__2; // 0x28
	private string <monumentName>5__3; // 0x30
	private GameObject <monument>5__4; // 0x38
	private Transform[] <>7__wrap4; // 0x40
	private int <>7__wrap5; // 0x48
	private Transform <vantage>5__7; // 0x50
	private int <i>5__8; // 0x58
	private double <frameTimes>5__9; // 0x60
	private string <ident>5__10; // 0x68
	private Stopwatch <sw>5__11; // 0x70
	private int <i>5__12; // 0x78

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

	// RVA: 0x77C820 Offset: 0x77BC20 VA: 0x18077C820 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x77D1D0 Offset: 0x77C5D0 VA: 0x18077D1D0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

