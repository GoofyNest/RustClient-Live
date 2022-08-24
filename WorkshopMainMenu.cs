public class WorkshopMainMenu : SingletonComponent<WorkshopMainMenu> // TypeDefIndex: 11174
{
	public static Translate.Phrase loading_workshop; 
	public static Translate.Phrase loading_workshop_setup; 
	public static Translate.Phrase loading_workshop_skinnables; 
	public static Translate.Phrase loading_workshop_item; 


	public void CreateNewItem() { }

	private void OnEnable() { }

	[IteratorStateMachineAttribute] 
	private IEnumerator CreateNewItemAsync() { }

	public void StartEditingItem(IWorkshopContent id) { }

	public void StartViewingItem(IWorkshopContent id) { }

	[IteratorStateMachineAttribute] 
	private IEnumerator LoadEditor() { }

	[IteratorStateMachineAttribute] 
	private IEnumerator StartEditingItemAsync(IWorkshopContent id) { }

	[IteratorStateMachineAttribute] 
	private IEnumerator StartViewingItemAsync(IWorkshopContent id) { }

	public void .ctor() { }

	private static void .cctor() { }

}

private sealed class WorkshopMainMenu.<CreateNewItemAsync>d__6 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11175
{
	private int <>1__state; 
	private object <>2__current; 
	public WorkshopMainMenu <>4__this; 

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

private sealed class WorkshopMainMenu.<>c // TypeDefIndex: 11176
{
	public static readonly WorkshopMainMenu.<>c <>9; 
	public static Action<bool, string> <>9__9_0; 


	private static void .cctor() { }

	public void .ctor() { }

	internal void <LoadEditor>b__9_0(bool o, string str) { }

}

private sealed class WorkshopMainMenu.<LoadEditor>d__9 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11177
{
	private int <>1__state; 
	private object <>2__current; 
	public WorkshopMainMenu <>4__this; 

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

private sealed class WorkshopMainMenu.<StartEditingItemAsync>d__10 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11178
{
	private int <>1__state; 
	private object <>2__current; 
	public WorkshopMainMenu <>4__this; 
	public IWorkshopContent id; 

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

private sealed class WorkshopMainMenu.<StartViewingItemAsync>d__11 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11179
{
	private int <>1__state; 
	private object <>2__current; 
	public WorkshopMainMenu <>4__this; 
	public IWorkshopContent id; 

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

