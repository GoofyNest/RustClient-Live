internal class ImportVersion3 : SingletonComponent<ImportVersion3> // TypeDefIndex: 7791
{

	[IteratorStateMachineAttribute] 
	internal IEnumerator DoImport(IWorkshopContent item, Skin skin) { }

	[IteratorStateMachineAttribute] 
	private IEnumerator DownloadFromWorkshop(IWorkshopContent item) { }

	public void .ctor() { }

}

private sealed class ImportVersion3.<DoImport>d__0 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7792
{
	private int <>1__state; 
	private object <>2__current; 
	public ImportVersion3 <>4__this; 
	public IWorkshopContent item; 
	public Skin skin; 

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

private sealed class ImportVersion3.<DownloadFromWorkshop>d__1 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7793
{
	private int <>1__state; 
	private object <>2__current; 
	public IWorkshopContent item; 

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

