public class RCMenu : ComputerMenu // TypeDefIndex: 10413
{
	public Image backgroundOpaque;
	public InputField newBookmarkEntryField;
	public NeedsCursor needsCursor;
	public float hiddenOffset;
	public RectTransform devicesPanel;
	private Vector3 initialDevicesPosition;
	public static bool isControllingCamera;
	public CanvasGroup overExposure;
	public CanvasGroup interference;
	public float interferenceFadeDuration;
	public Text timeText;
	public Text watchedDurationText;
	public Text deviceNameText;
	public Text noSignalText;
	public SoundDefinition bookmarkPressedSoundDef;
	public GameObject[] hideIfStatic;
	private float startWatchingTime;
	private float noSignalDuration;
	private bool devicePanelVisible;

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

	[IteratorStateMachineAttribute]
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

private sealed class RCMenu.<RefreshLODs>d__31 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 10414
{
	private int <>1__state;
	private object <>2__current;

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

