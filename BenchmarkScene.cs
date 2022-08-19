public class BenchmarkScene : MonoBehaviour // TypeDefIndex: 8259
{	// Fields
	public string BenchmarkTitle; // 0x18
	public string BenchmarkIdent; // 0x20
	public int MaxNumberOfFrames; // 0x28
	public int MaxNumberOfSeconds; // 0x2C
	protected int FrameCount; // 0x30
	protected TimeSince TimeSinceStarted; // 0x34
	protected TimeSince TimeSinceFrame; // 0x38
	protected float FrameTimes; // 0x3C
	public static bool IsRunningInEditor; // 0x0

	// Properties
	public virtual bool SubmitsOwnResults { get; }

	// Methods

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 4
	public virtual bool get_SubmitsOwnResults() { }

	// RVA: 0x528A10 Offset: 0x527E10 VA: 0x180528A10 Slot: 5
	public virtual bool ShouldEnd() { }

	// RVA: 0x528A60 Offset: 0x527E60 VA: 0x180528A60
	public void Start() { }

	[IteratorStateMachineAttribute] // RVA: 0xA28C0 Offset: 0xA1CC0 VA: 0x1800A28C0
	// RVA: 0x5289A0 Offset: 0x527DA0 VA: 0x1805289A0
	public IEnumerator RunBenchmark() { }

	// RVA: 0x528980 Offset: 0x527D80 VA: 0x180528980 Slot: 6
	public virtual float GetResult() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 7
	public virtual void StartBenchmark() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 8
	public virtual void BenchmarkUpdate() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 9
	public virtual void StopBenchmark() { }

	// RVA: 0x528C60 Offset: 0x528060 VA: 0x180528C60
	public void .ctor() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private static void .cctor() { }

}

private sealed class BenchmarkScene.<RunBenchmark>d__13 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 8260
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public BenchmarkScene <>4__this; // 0x20
	private Stopwatch <sw>5__2; // 0x28

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

	// RVA: 0x53FCB0 Offset: 0x53F0B0 VA: 0x18053FCB0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x540190 Offset: 0x53F590 VA: 0x180540190 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

