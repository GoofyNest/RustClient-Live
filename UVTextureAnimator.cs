internal class UVTextureAnimator : MonoBehaviour // TypeDefIndex: 11473
{	// Fields
	public int Rows; // 0x18
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

	// Methods

	// RVA: 0x9E4D90 Offset: 0x9E4190 VA: 0x1809E4D90
	private void Start() { }

	// RVA: 0x9E48F0 Offset: 0x9E3CF0 VA: 0x1809E48F0
	private void InitDefaultVariables() { }

	// RVA: 0x9E4D10 Offset: 0x9E4110 VA: 0x1809E4D10
	private void Play() { }

	// RVA: 0x9E4CA0 Offset: 0x9E40A0 VA: 0x1809E4CA0
	private void PlayDelay() { }

	// RVA: 0x9E4C70 Offset: 0x9E4070 VA: 0x1809E4C70
	private void OnEnable() { }

	// RVA: 0x9E4C20 Offset: 0x9E4020 VA: 0x1809E4C20
	private void OnDisable() { }

	[IteratorStateMachineAttribute] // RVA: 0xB4560 Offset: 0xB3960 VA: 0x1800B4560
	// RVA: 0x9E4F00 Offset: 0x9E4300 VA: 0x1809E4F00
	private IEnumerator UpdateCorutine() { }

	// RVA: 0x9E4E00 Offset: 0x9E4200 VA: 0x1809E4E00
	private void UpdateCorutineFrame() { }

	// RVA: 0x9E4B70 Offset: 0x9E3F70 VA: 0x1809E4B70
	private void OnDestroy() { }

	// RVA: 0x9E4F70 Offset: 0x9E4370 VA: 0x1809E4F70
	public void .ctor() { }

}

private sealed class UVTextureAnimator.<UpdateCorutine>d__21 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11474
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public UVTextureAnimator <>4__this; // 0x20

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

	// RVA: 0x9DECE0 Offset: 0x9DE0E0 VA: 0x1809DECE0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x9DEEC0 Offset: 0x9DE2C0 VA: 0x1809DEEC0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

