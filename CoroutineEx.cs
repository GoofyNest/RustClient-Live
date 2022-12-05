public static class CoroutineEx // TypeDefIndex: 13504
{
	public static WaitForEndOfFrame waitForEndOfFrame;
	public static WaitForFixedUpdate waitForFixedUpdate;
	private static Dictionary<float, WaitForSeconds> waitForSecondsBuffer;


	public static WaitForSeconds waitForSeconds(float seconds) { }

	public static WaitForSecondsRealtimeEx waitForSecondsRealtime(float seconds) { }

	[IteratorStateMachineAttribute]
	public static IEnumerator Combine(IEnumerator[] coroutines) { }

	private static void .cctor() { }

}

private sealed class CoroutineEx.<Combine>d__5 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 13505
{
	private int <>1__state;
	private object <>2__current;
	public IEnumerator[] coroutines;

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

