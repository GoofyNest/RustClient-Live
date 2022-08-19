public class FrankensteinTableVisuals : MonoBehaviour // TypeDefIndex: 8695
{	// Fields
	public GameObject FXReady; // 0x18
	public GameObject FXNotReady; // 0x20
	public GameObject FXWake; // 0x28
	public Transform HeadVisualAnchor; // 0x30
	public Transform TorsoVisualAnchor; // 0x38
	public Transform LegsVisualAnchor; // 0x40
	public Animator Animator; // 0x48

	// Methods

	// RVA: 0x6EFAD0 Offset: 0x6EEED0 VA: 0x1806EFAD0
	public void Refresh(List<ItemDefinition> items, FrankensteinTable table) { }

	// RVA: 0x6EF770 Offset: 0x6EEB70 VA: 0x1806EF770
	private void DisableAllReadyFX() { }

	// RVA: 0x6EFE30 Offset: 0x6EF230 VA: 0x1806EFE30
	private void SetReadyFX(bool ready) { }

	// RVA: 0x6EF3E0 Offset: 0x6EE7E0 VA: 0x1806EF3E0
	public void Clear() { }

	// RVA: 0x6EF570 Offset: 0x6EE970 VA: 0x1806EF570
	private void DestroyAnchorChildren(Transform t) { }

	// RVA: 0x6EF7B0 Offset: 0x6EEBB0 VA: 0x1806EF7B0
	public void DisplayItem(ItemDefinition item, FrankensteinTable table) { }

	// RVA: 0x6EF910 Offset: 0x6EED10 VA: 0x1806EF910
	public void DisplayItem(ItemDefinition item, Transform anchor) { }

	// RVA: 0x6EFF00 Offset: 0x6EF300 VA: 0x1806EFF00
	public void StartWaking() { }

	[IteratorStateMachineAttribute] // RVA: 0xBBA60 Offset: 0xBAE60 VA: 0x1800BBA60
	// RVA: 0x6EFF70 Offset: 0x6EF370 VA: 0x1806EFF70
	private IEnumerator Wake() { }

	// RVA: 0x6EFE80 Offset: 0x6EF280 VA: 0x1806EFE80
	private void SetTableUp(bool flag) { }

	// RVA: 0x6EFDB0 Offset: 0x6EF1B0 VA: 0x1806EFDB0
	private void SetLeverUp(bool flag) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

private sealed class FrankensteinTableVisuals.<Wake>d__15 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 8696
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public FrankensteinTableVisuals <>4__this; // 0x20

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

	// RVA: 0x701B00 Offset: 0x700F00 VA: 0x180701B00 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x701D90 Offset: 0x701190 VA: 0x180701D90 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

