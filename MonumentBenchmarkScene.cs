public class MonumentBenchmarkScene : BenchmarkScene // TypeDefIndex: 8257
{	public string[] monumentPrefabs; // 0x40
	public Transform[] vantagePoints; // 0x48
	private bool isFinished; // 0x50

	public override bool SubmitsOwnResults { get; }


	public override bool get_SubmitsOwnResults() { }

	public override void StartBenchmark() { }

	[IteratorStateMachineAttribute] // RVA: 0xA2560 Offset: 0xA1960 VA: 0x1800A2560
	private IEnumerator DoMonumentBenchmark() { }

	public override bool ShouldEnd() { }

	public void .ctor() { }

}

private sealed class MonumentBenchmarkScene.<DoMonumentBenchmark>d__6 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 8258
{	private int <>1__state; // 0x10
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

