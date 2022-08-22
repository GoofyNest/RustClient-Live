internal class UVTextureAnimator : MonoBehaviour // TypeDefIndex: 11473
{	public int Rows; // 0x18
	public int Columns; // 0x1C
	public float Fps; // 0x20
	public int OffsetMat; // 0x24
	public bool IsLoop; // 0x28
	public float StartDelay; // 0x2C
	private bool isInizialised; // 0x30
	private int index; // 0x34
	private int count; // 0x38
	private int allCount; // 0x3C
	private float deltaFps; // 0x40
	private bool isVisible; // 0x44
	private bool isCorutineStarted; // 0x45
	private Renderer currentRenderer; // 0x48
	private Material instanceMaterial; // 0x50


	private void Start() { }

	private void InitDefaultVariables() { }

	private void Play() { }

	private void PlayDelay() { }

	private void OnEnable() { }

	private void OnDisable() { }

	[IteratorStateMachineAttribute] // RVA: 0xB4560 Offset: 0xB3960 VA: 0x1800B4560
	private IEnumerator UpdateCorutine() { }

	private void UpdateCorutineFrame() { }

	private void OnDestroy() { }

	public void .ctor() { }

}

private sealed class UVTextureAnimator.<UpdateCorutine>d__21 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11474
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public UVTextureAnimator <>4__this; // 0x20

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

