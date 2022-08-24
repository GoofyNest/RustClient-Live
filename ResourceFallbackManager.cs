internal class ResourceFallbackManager : IEnumerable<CultureInfo>, IEnumerable // TypeDefIndex: 489
{
	private CultureInfo m_startingCulture; 
	private CultureInfo m_neutralResourcesCulture; 
	private bool m_useParents; 


	internal void .ctor(CultureInfo startingCulture, CultureInfo neutralResourcesCulture, bool useParents) { }

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[IteratorStateMachineAttribute] 
	public IEnumerator<CultureInfo> GetEnumerator() { }

}

private sealed class ResourceFallbackManager.<GetEnumerator>d__5 : IEnumerator<CultureInfo>, IDisposable, IEnumerator // TypeDefIndex: 490
{
	private int <>1__state; 
	private CultureInfo <>2__current; 
	public ResourceFallbackManager <>4__this; 
	private CultureInfo <currentCulture>5__1; 
	private bool <reachedNeutralResourcesCulture>5__2; 

	private CultureInfo System.Collections.Generic.IEnumerator<System.Globalization.CultureInfo>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] 
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] 
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] 
	private CultureInfo System.Collections.Generic.IEnumerator<System.Globalization.CultureInfo>.get_Current() { }

	[DebuggerHiddenAttribute] 
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] 
	private object System.Collections.IEnumerator.get_Current() { }

}

