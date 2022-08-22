public class RCMenu : ComputerMenu // TypeDefIndex: 8687
{	public Image backgroundOpaque; // 0x58
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

	public bool RequiresMouseForControl { get; }


	public override void InitMenu(BaseEntity computer) { }

	public ComputerStation GetOwnerComputer() { }

	public void SetDevicesVisible(bool wants) { }

	public void ToggleDevicePanelVisible() { }

	public void BackgroundClick() { }

	public float GetInterferenceLevel() { }

	public IRemoteControllable GetCurrentlyControllingEnt() { }

	public bool get_RequiresMouseForControl() { }

	public void Update() { }

	public void OnDestroy() { }

	public void DelayedLODRefresh() { }

	[IteratorStateMachineAttribute] // RVA: 0xB9DD0 Offset: 0xB91D0 VA: 0x1800B9DD0
	private IEnumerator RefreshLODs() { }

	public void AddBookmarkPressed() { }

	public override void DeletePressed(RCBookmarkEntry entry) { }

	public void Exit() { }

	public override bool IsControlling(string identifier) { }

	public override void DisconnectPressed(RCBookmarkEntry entry) { }

	public override void BookmarkPressed(RCBookmarkEntry entryPressed) { }

	public override BasePlayer.CameraMode GetCameraMode() { }

	public override bool WantsEyeOverride() { }

	public override Transform GetCameraOverrideTransform() { }

	public void .ctor() { }

	private static void .cctor() { }

}

private sealed class RCMenu.<RefreshLODs>d__31 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 8688
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18

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

