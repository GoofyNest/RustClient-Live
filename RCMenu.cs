public class RCMenu : ComputerMenu // TypeDefIndex: 8687
{	// Fields
	public Image backgroundOpaque; // 0x58
	public InputField newBookmarkEntryField; // 0x60
	public NeedsCursor needsCursor; // 0x68
	public float hiddenOffset; // 0x70
	public RectTransform devicesPanel; // 0x78
	private Vector3 initialDevicesPosition; // 0x80
	public static bool isControllingCamera; // 0x0
	public CanvasGroup overExposure; // 0x90
	public CanvasGroup interference; // 0x98
	public float interferenceFadeDuration; // 0xA0
	public Text timeText; // 0xA8
	public Text watchedDurationText; // 0xB0
	public Text deviceNameText; // 0xB8
	public Text noSignalText; // 0xC0
	public SoundDefinition bookmarkPressedSoundDef; // 0xC8
	public GameObject[] hideIfStatic; // 0xD0
	private float startWatchingTime; // 0xD8
	private float noSignalDuration; // 0xDC
	private bool devicePanelVisible; // 0xE0

	// Properties
	public bool RequiresMouseForControl { get; }

	// Methods

	// RVA: 0x69D5B0 Offset: 0x69C9B0 VA: 0x18069D5B0 Slot: 10
	public override void InitMenu(BaseEntity computer) { }

	// RVA: 0x69D520 Offset: 0x69C920 VA: 0x18069D520
	public ComputerStation GetOwnerComputer() { }

	// RVA: 0x69D910 Offset: 0x69CD10 VA: 0x18069D910
	public void SetDevicesVisible(bool wants) { }

	// RVA: 0x69DA00 Offset: 0x69CE00 VA: 0x18069DA00
	public void ToggleDevicePanelVisible() { }

	// RVA: 0x69CD40 Offset: 0x69C140 VA: 0x18069CD40
	public void BackgroundClick() { }

	// RVA: 0x69D4F0 Offset: 0x69C8F0 VA: 0x18069D4F0
	public float GetInterferenceLevel() { }

	// RVA: 0x69D3D0 Offset: 0x69C7D0 VA: 0x18069D3D0
	public IRemoteControllable GetCurrentlyControllingEnt() { }

	// RVA: 0x69E700 Offset: 0x69DB00 VA: 0x18069E700
	public bool get_RequiresMouseForControl() { }

	// RVA: 0x69DAF0 Offset: 0x69CEF0 VA: 0x18069DAF0
	public void Update() { }

	// RVA: 0x69D820 Offset: 0x69CC20 VA: 0x18069D820
	public void OnDestroy() { }

	// RVA: 0x69CF70 Offset: 0x69C370 VA: 0x18069CF70
	public void DelayedLODRefresh() { }

	[IteratorStateMachineAttribute] // RVA: 0xB9DD0 Offset: 0xB91D0 VA: 0x1800B9DD0
	// RVA: 0x69D8C0 Offset: 0x69CCC0 VA: 0x18069D8C0
	private IEnumerator RefreshLODs() { }

	// RVA: 0x69CC50 Offset: 0x69C050 VA: 0x18069CC50
	public void AddBookmarkPressed() { }

	// RVA: 0x69D080 Offset: 0x69C480 VA: 0x18069D080 Slot: 16
	public override void DeletePressed(RCBookmarkEntry entry) { }

	// RVA: 0x69D200 Offset: 0x69C600 VA: 0x18069D200
	public void Exit() { }

	// RVA: 0x69D700 Offset: 0x69CB00 VA: 0x18069D700 Slot: 17
	public override bool IsControlling(string identifier) { }

	// RVA: 0x69D140 Offset: 0x69C540 VA: 0x18069D140 Slot: 15
	public override void DisconnectPressed(RCBookmarkEntry entry) { }

	// RVA: 0x69CDB0 Offset: 0x69C1B0 VA: 0x18069CDB0 Slot: 14
	public override void BookmarkPressed(RCBookmarkEntry entryPressed) { }

	// RVA: 0x69D290 Offset: 0x69C690 VA: 0x18069D290 Slot: 13
	public override BasePlayer.CameraMode GetCameraMode() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 11
	public override bool WantsEyeOverride() { }

	// RVA: 0x69D2D0 Offset: 0x69C6D0 VA: 0x18069D2D0 Slot: 12
	public override Transform GetCameraOverrideTransform() { }

	// RVA: 0x69E6E0 Offset: 0x69DAE0 VA: 0x18069E6E0
	public void .ctor() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private static void .cctor() { }

}

private sealed class RCMenu.<RefreshLODs>d__31 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 8688
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18

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

	// RVA: 0x6AC3D0 Offset: 0x6AB7D0 VA: 0x1806AC3D0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x6AC730 Offset: 0x6ABB30 VA: 0x1806AC730 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

