public class BenchmarkScene : MonoBehaviour // TypeDefIndex: 9977
{
	public string BenchmarkTitle;
	public string BenchmarkIdent;
	public int MaxNumberOfFrames;
	public int MaxNumberOfSeconds;
	protected int FrameCount;
	protected TimeSince TimeSinceStarted;
	protected TimeSince TimeSinceFrame;
	protected float FrameTimes;
	public static bool IsRunningInEditor;

	public virtual bool SubmitsOwnResults { get; }


	public virtual bool get_SubmitsOwnResults() { }

	public virtual bool ShouldEnd() { }

	public void Start() { }

	[IteratorStateMachineAttribute]
	public IEnumerator RunBenchmark() { }

	public virtual float GetResult() { }

	public virtual void StartBenchmark() { }

	public virtual void BenchmarkUpdate() { }

	public virtual void StopBenchmark() { }

	public void .ctor() { }

	private static void .cctor() { }

}

private sealed class BenchmarkScene.<RunBenchmark>d__13 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 9978
{
	private int <>1__state;
	private object <>2__current;
	public BenchmarkScene <>4__this;
	private Stopwatch <sw>5__2;

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

