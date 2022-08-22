public class BenchmarkScene : MonoBehaviour // TypeDefIndex: 8259
{	public string BenchmarkTitle; // 0x18
	public string BenchmarkIdent; // 0x20
	public int MaxNumberOfFrames; // 0x28
	public int MaxNumberOfSeconds; // 0x2C
	protected int FrameCount; // 0x30
	protected TimeSince TimeSinceStarted; // 0x34
	protected TimeSince TimeSinceFrame; // 0x38
	protected float FrameTimes; // 0x3C
	public static bool IsRunningInEditor; // 0x0

	public virtual bool SubmitsOwnResults { get; }


	public virtual bool get_SubmitsOwnResults() { }

	public virtual bool ShouldEnd() { }

	public void Start() { }

	[IteratorStateMachineAttribute] // RVA: 0xA28C0 Offset: 0xA1CC0 VA: 0x1800A28C0
	public IEnumerator RunBenchmark() { }

	public virtual float GetResult() { }

	public virtual void StartBenchmark() { }

	public virtual void BenchmarkUpdate() { }

	public virtual void StopBenchmark() { }

	public void .ctor() { }

	private static void .cctor() { }

}

private sealed class BenchmarkScene.<RunBenchmark>d__13 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 8260
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public BenchmarkScene <>4__this; // 0x20
	private Stopwatch <sw>5__2; // 0x28

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

