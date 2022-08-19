public class InstantCameraTool : HeldEntity // TypeDefIndex: 8584
{	// Fields
	public ItemDefinition photoItem; // 0x1F8
	public GameObjectRef screenshotEffect; // 0x200
	public SoundDefinition startPhotoSoundDef; // 0x208
	public SoundDefinition finishPhotoSoundDef; // 0x210
	[RangeAttribute] // RVA: 0xAC5F0 Offset: 0xAB9F0 VA: 0x1800AC5F0
	public int resolutionX; // 0x218
	[RangeAttribute] // RVA: 0xAC670 Offset: 0xABA70 VA: 0x1800AC670
	public int resolutionY; // 0x21C
	[RangeAttribute] // RVA: 0xAC790 Offset: 0xABB90 VA: 0x1800AC790
	public int quality; // 0x220
	[RangeAttribute] // RVA: 0x75910 Offset: 0x74D10 VA: 0x180075910
	public float cooldownSeconds; // 0x224
	private TimeSince _sinceLastPhoto; // 0x228
	private float cameraFOV; // 0x22C
	private CameraFocusMode _focusMode; // 0x230
	private float focalDistance; // 0x234
	private float focalDistanceSmooth; // 0x238
	private float focalDistanceTarget; // 0x23C

	// Methods

	// RVA: 0x813630 Offset: 0x812A30 VA: 0x180813630 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x812A80 Offset: 0x811E80 VA: 0x180812A80 Slot: 135
	public override void EditViewAngles() { }

	// RVA: 0x813110 Offset: 0x812510 VA: 0x180813110 Slot: 137
	public override void OnFrame() { }

	// RVA: 0x812E30 Offset: 0x812230 VA: 0x180812E30
	private float GetAutofocusDistance() { }

	// RVA: 0x813350 Offset: 0x812750 VA: 0x180813350 Slot: 138
	public override void OnInput() { }

	[IteratorStateMachineAttribute] // RVA: 0xAC980 Offset: 0xABD80 VA: 0x1800AC980
	// RVA: 0x813870 Offset: 0x812C70 VA: 0x180813870
	private IEnumerator TakePhoto() { }

	// RVA: 0x813720 Offset: 0x812B20 VA: 0x180813720
	private void RenderCallback() { }

	// RVA: 0x812ED0 Offset: 0x8122D0 VA: 0x180812ED0
	private void GetScreenCallback(Texture2D texture) { }

	// RVA: 0x812F50 Offset: 0x812350 VA: 0x180812F50 Slot: 146
	public override void ModifyCamera() { }

	// RVA: 0x812CC0 Offset: 0x8120C0 VA: 0x180812CC0
	private void FadeOut() { }

	// RVA: 0x813070 Offset: 0x812470 VA: 0x180813070 Slot: 141
	public override void OnDeployed() { }

	// RVA: 0x8132B0 Offset: 0x8126B0 VA: 0x1808132B0 Slot: 143
	public override void OnHolstered() { }

	// RVA: 0x8138E0 Offset: 0x812CE0 VA: 0x1808138E0
	public void .ctor() { }

}

private sealed class InstantCameraTool.<TakePhoto>d__19 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 8585
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public InstantCameraTool <>4__this; // 0x20
	private int <originalNudity>5__2; // 0x28

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

	// RVA: 0x81E1C0 Offset: 0x81D5C0 VA: 0x18081E1C0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x81E3F0 Offset: 0x81D7F0 VA: 0x18081E3F0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

