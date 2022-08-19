public class Achievements : SingletonComponent<Achievements> // TypeDefIndex: 10822
{	// Fields
	public SoundDefinition listComplete; // 0x18
	public SoundDefinition itemComplete; // 0x20
	public SoundDefinition popup; // 0x28
	public Canvas Canvas; // 0x30
	public Text titleText; // 0x38
	private AchievementTodo[] items; // 0x40
	private bool blockOpenSound; // 0x48

	// Properties
	public bool IsOpen { get; }

	// Methods

	// RVA: 0x768AE0 Offset: 0x767EE0 VA: 0x180768AE0
	public bool get_IsOpen() { }

	// RVA: 0xA954A0 Offset: 0xA948A0 VA: 0x180A954A0
	public void OnEnable() { }

	// RVA: 0xA950E0 Offset: 0xA944E0 VA: 0x180A950E0
	private void ClientConnected() { }

	// RVA: 0xA955A0 Offset: 0xA949A0 VA: 0x180A955A0
	public void Reset() { }

	[IteratorStateMachineAttribute] // RVA: 0x7CFD0 Offset: 0x7C3D0 VA: 0x18007CFD0
	// RVA: 0xA95BE0 Offset: 0xA94FE0 VA: 0x180A95BE0
	private IEnumerator Think() { }

	// RVA: 0xA95620 Offset: 0xA94A20 VA: 0x180A95620
	public bool ShouldShow() { }

	// RVA: 0xA950F0 Offset: 0xA944F0 VA: 0x180A950F0
	public void Hide() { }

	// RVA: 0xA95860 Offset: 0xA94C60 VA: 0x180A95860
	private void Show() { }

	// RVA: 0xA95270 Offset: 0xA94670 VA: 0x180A95270
	public void Initialize() { }

	// RVA: 0xA95A30 Offset: 0xA94E30 VA: 0x180A95A30
	private void SwitchToGroup(AchievementGroup group) { }

	// RVA: 0xA95500 Offset: 0xA94900 VA: 0x180A95500
	public void OnItemComplete() { }

	// RVA: 0xA94D80 Offset: 0xA94180 VA: 0x180A94D80
	public void CheckForListComplete() { }

	// RVA: 0xA94D70 Offset: 0xA94170 VA: 0x180A94D70
	public void BlockNextOpenSound() { }

	// RVA: 0xA95C50 Offset: 0xA95050 VA: 0x180A95C50
	public void .ctor() { }

}

private sealed class Achievements.<Think>d__12 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 10823
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Achievements <>4__this; // 0x20

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

	// RVA: 0xAA68E0 Offset: 0xAA5CE0 VA: 0x180AA68E0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xAA69C0 Offset: 0xAA5DC0 VA: 0x180AA69C0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

