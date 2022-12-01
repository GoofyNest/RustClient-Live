public class MissionsHUD : SingletonComponent<MissionsHUD> // TypeDefIndex: 12976
{
	public SoundDefinition listComplete;
	public SoundDefinition itemComplete;
	public SoundDefinition popup;
	public Canvas Canvas;
	public Text titleText;
	public GameObject timerObject;
	public RustText timerText;
	private MissionsHUDToDo[] items;
	private bool blockOpenSound;
	private float nextTextUpdateTime;

	public bool IsOpen { get; }


	public bool get_IsOpen() { }

	public void OnEnable() { }

	private void ClientConnected() { }

	public void Reset() { }

	public static void ClientMissionUpdate() { }

	public void ForceUpdate() { }

	public void UpdateTimeText() { }

	public void Update() { }

	[IteratorStateMachineAttribute]
	private IEnumerator Think() { }

	public bool ShouldShow() { }

	public void Hide() { }

	private void Show() { }

	public void Initialize() { }

	public void OnItemComplete() { }

	public void CheckForListComplete() { }

	public void BlockNextOpenSound() { }

	public void .ctor() { }

}

private sealed class MissionsHUD.<Think>d__19 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 12977
{
	private int <>1__state;
	private object <>2__current;
	public MissionsHUD <>4__this;

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

