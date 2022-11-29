public static class PerformanceMetrics // TypeDefIndex: 13111
{
	private static PerformanceSamplePoint current; 
	private static Action OnBeforeRender; 
	private static int _mainThreadId; 


	public static PerformanceSamplePoint GetCurrent(bool reset = False) { }

	public static void Setup() { }

	private static void AddCPUTimeStopwatch() { }

	private static void AddStopwatch(PerformanceSample sample, ref Action pre, ref Action post) { }

}

private sealed class PerformanceMetrics.<>c // TypeDefIndex: 13112
{
	public static readonly PerformanceMetrics.<>c <>9; 
	public static UnityAction <>9__3_0; 


	private static void .cctor() { }

	public void .ctor() { }

	internal void <Setup>

}

private sealed class PerformanceMetrics.<>c__DisplayClass4_0 // TypeDefIndex: 13113
{
	public TimeSpan lastTime; 
	public int lastFrame; 
	public Stopwatch watch; 


	public void .ctor() { }

	internal void <AddCPUTimeStopwatch>

	internal void <AddCPUTimeStopwatch>

}

private sealed class PerformanceMetrics.<>c__DisplayClass6_0 // TypeDefIndex: 13114
{
	public bool active; 
	public Stopwatch watch; 
	public PerformanceSample sample; 


	public void .ctor() { }

	internal void <AddStopwatch>

	internal void <AddStopwatch>

}

