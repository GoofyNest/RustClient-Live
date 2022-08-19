public class MissionsHUD : SingletonComponent<MissionsHUD> // TypeDefIndex: 11180
{	// Fields
	public SoundDefinition listComplete; // 0x18
	public SoundDefinition itemComplete; // 0x20
	public SoundDefinition popup; // 0x28
	public Canvas Canvas; // 0x30
	public Text titleText; // 0x38
	public GameObject timerObject; // 0x40
	public RustText timerText; // 0x48
	private MissionsHUDToDo[] items; // 0x50
	private bool blockOpenSound; // 0x58
	private float nextTextUpdateTime; // 0x5C

	// Properties
	public bool IsOpen { get; }

	// Methods

	// RVA: 0x768AE0 Offset: 0x767EE0 VA: 0x180768AE0
	public bool get_IsOpen() { }

	// RVA: 0x768080 Offset: 0x767480 VA: 0x180768080
	public void OnEnable() { }

	// RVA: 0x767960 Offset: 0x766D60 VA: 0x180767960
	private void ClientConnected() { }

	// RVA: 0x768180 Offset: 0x767580 VA: 0x180768180
	public void Reset() { }

	// RVA: 0x767970 Offset: 0x766D70 VA: 0x180767970
	public static void ClientMissionUpdate() { }

	// RVA: 0x767A40 Offset: 0x766E40 VA: 0x180767A40
	public void ForceUpdate() { }

	// RVA: 0x7685E0 Offset: 0x7679E0 VA: 0x1807685E0
	public void UpdateTimeText() { }

	// RVA: 0x768A70 Offset: 0x767E70 VA: 0x180768A70
	public void Update() { }

	[IteratorStateMachineAttribute] // RVA: 0x9E950 Offset: 0x9DD50 VA: 0x18009E950
	// RVA: 0x768570 Offset: 0x767970 VA: 0x180768570
	private IEnumerator Think() { }

	// RVA: 0x768200 Offset: 0x767600 VA: 0x180768200
	public bool ShouldShow() { }

	// RVA: 0x767BF0 Offset: 0x766FF0 VA: 0x180767BF0
	public void Hide() { }

	// RVA: 0x7683A0 Offset: 0x7677A0 VA: 0x1807683A0
	private void Show() { }

	// RVA: 0x767D70 Offset: 0x767170 VA: 0x180767D70
	public void Initialize() { }

	// RVA: 0x7680E0 Offset: 0x7674E0 VA: 0x1807680E0
	public void OnItemComplete() { }

	// RVA: 0x767600 Offset: 0x766A00 VA: 0x180767600
	public void CheckForListComplete() { }

	// RVA: 0x52D6F0 Offset: 0x52CAF0 VA: 0x18052D6F0
	public void BlockNextOpenSound() { }

	// RVA: 0x768A80 Offset: 0x767E80 VA: 0x180768A80
	public void .ctor() { }

}

private sealed class MissionsHUD.<Think>d__19 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11181
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public MissionsHUD <>4__this; // 0x20

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

	// RVA: 0x77D220 Offset: 0x77C620 VA: 0x18077D220 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x77D300 Offset: 0x77C700 VA: 0x18077D300 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

