public class MissionsHUD : SingletonComponent<MissionsHUD> // TypeDefIndex: 11180
{	public SoundDefinition listComplete; // 0x18
	public SoundDefinition itemComplete; // 0x20
	public SoundDefinition popup; // 0x28
	public Canvas Canvas; // 0x30
	public Text titleText; // 0x38
	public GameObject timerObject; // 0x40
	public RustText timerText; // 0x48
	private MissionsHUDToDo[] items; // 0x50
	private bool blockOpenSound; // 0x58
	private float nextTextUpdateTime; // 0x5C

	public bool IsOpen { get; }


	public bool get_IsOpen() { }

	public void OnEnable() { }

	private void ClientConnected() { }

	public void Reset() { }

	public static void ClientMissionUpdate() { }

	public void ForceUpdate() { }

	public void UpdateTimeText() { }

	public void Update() { }

	[IteratorStateMachineAttribute] // RVA: 0x9E950 Offset: 0x9DD50 VA: 0x18009E950
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

private sealed class MissionsHUD.<Think>d__19 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11181
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public MissionsHUD <>4__this; // 0x20

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.IEnumerator.get_Current() { }

}

