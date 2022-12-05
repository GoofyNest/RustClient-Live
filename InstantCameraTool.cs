public class InstantCameraTool : HeldEntity // TypeDefIndex: 10308
{
	public ItemDefinition photoItem;
	public GameObjectRef screenshotEffect;
	public SoundDefinition startPhotoSoundDef;
	public SoundDefinition finishPhotoSoundDef;
	[RangeAttribute]
	public int resolutionX;
	[RangeAttribute]
	public int resolutionY;
	[RangeAttribute]
	public int quality;
	[RangeAttribute]
	public float cooldownSeconds;
	private TimeSince _sinceLastPhoto;
	private float cameraFOV;
	private CameraFocusMode _focusMode;
	private float focalDistance;
	private float focalDistanceSmooth;
	private float focalDistanceTarget;


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override void EditViewAngles() { }

	public override void OnFrame() { }

	private float GetAutofocusDistance() { }

	public override void OnInput() { }

	[IteratorStateMachineAttribute]
	private IEnumerator TakePhoto() { }

	private void RenderCallback() { }

	private void GetScreenCallback(Texture2D texture) { }

	public override void ModifyCamera() { }

	private void FadeOut() { }

	public override void OnDeployed() { }

	public override void OnHolstered() { }

	public void .ctor() { }

}

private sealed class InstantCameraTool.<TakePhoto>d__19 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 10309
{
	private int <>1__state;
	private object <>2__current;
	public InstantCameraTool <>4__this;
	private int <originalNudity>5__2;

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

