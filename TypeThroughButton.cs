public class TypeThroughButton : Button, IUpdateSelectedHandler, IEventSystemHandler // TypeDefIndex: 12991
{
	public InputField typingTarget; 
	private Event _processingEvent; 


	public void OnUpdateSelected(BaseEventData eventData) { }

	[IteratorStateMachineAttribute] 
	private IEnumerator DelayedActivateTextField(Event e) { }

	public void .ctor() { }

}

private sealed class TypeThroughButton.<DelayedActivateTextField>d__3 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 12992
{
	private int <>1__state; 
	private object <>2__current; 
	public TypeThroughButton <>4__this; 
	public Event e; 

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

