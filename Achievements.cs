public class Achievements : SingletonComponent<Achievements> // TypeDefIndex: 12501
{
	public SoundDefinition listComplete; 
	public SoundDefinition itemComplete; 
	public SoundDefinition popup; 
	public Canvas Canvas; 
	public Text titleText; 
	private AchievementTodo[] items; 
	private bool blockOpenSound; 

	public bool IsOpen { get; }


	public bool get_IsOpen() { }

	public void OnEnable() { }

	private void ClientConnected() { }

	public void Reset() { }

	[IteratorStateMachineAttribute] 
	private IEnumerator Think() { }

	public bool ShouldShow() { }

	public void Hide() { }

	private void Show() { }

	public void Initialize() { }

	private void SwitchToGroup(AchievementGroup group) { }

	public void OnItemComplete() { }

	public void CheckForListComplete() { }

	public void BlockNextOpenSound() { }

	public void .ctor() { }

}

private sealed class Achievements.<Think>d__12 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 12502
{
	private int <>1__state; 
	private object <>2__current; 
	public Achievements <>4__this; 

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

