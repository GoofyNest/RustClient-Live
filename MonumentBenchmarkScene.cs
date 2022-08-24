public class MonumentBenchmarkScene : BenchmarkScene // TypeDefIndex: 8257
{
	public string[] monumentPrefabs; 
	public Transform[] vantagePoints; 
	private bool isFinished; 

public override bool SubmitsOwnResults { get; }


public override bool get_SubmitsOwnResults() { }

public override void StartBenchmark() { }

	[IteratorStateMachineAttribute] 
private IEnumerator DoMonumentBenchmark() { }

public override bool ShouldEnd() { }

public void .ctor() { }

}

private sealed class MonumentBenchmarkScene.<DoMonumentBenchmark>d__6 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 8258
{
	private int <>1__state; 
	private object <>2__current; 
	public MonumentBenchmarkScene <>4__this; 
	private int <prefabNum>5__2; 
	private string <monumentName>5__3; 
	private GameObject <monument>5__4; 
	private Transform[] <>7__wrap4; 
	private int <>7__wrap5; 
	private Transform <vantage>5__7; 
	private int <i>5__8; 
	private double <frameTimes>5__9; 
	private string <ident>5__10; 
	private Stopwatch <sw>5__11; 
	private int <i>5__12; 

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

