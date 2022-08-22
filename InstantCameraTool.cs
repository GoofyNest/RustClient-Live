public class InstantCameraTool : HeldEntity // TypeDefIndex: 8584
{	public ItemDefinition photoItem; // 0x1F8
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


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override void EditViewAngles() { }

	public override void OnFrame() { }

	private float GetAutofocusDistance() { }

	public override void OnInput() { }

	[IteratorStateMachineAttribute] // RVA: 0xAC980 Offset: 0xABD80 VA: 0x1800AC980
	private IEnumerator TakePhoto() { }

	private void RenderCallback() { }

	private void GetScreenCallback(Texture2D texture) { }

	public override void ModifyCamera() { }

	private void FadeOut() { }

	public override void OnDeployed() { }

	public override void OnHolstered() { }

	public void .ctor() { }

}

private sealed class InstantCameraTool.<TakePhoto>d__19 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 8585
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public InstantCameraTool <>4__this; // 0x20
	private int <originalNudity>5__2; // 0x28

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

