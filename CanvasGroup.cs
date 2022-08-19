public sealed class CanvasGroup : Behaviour, ICanvasRaycastFilter // TypeDefIndex: 4731
{	// Properties
	[NativePropertyAttribute] // RVA: 0xA4070 Offset: 0xA3470 VA: 0x1800A4070
	public float alpha { get; set; }
	[NativePropertyAttribute] // RVA: 0xA41C0 Offset: 0xA35C0 VA: 0x1800A41C0
	public bool interactable { get; set; }
	[NativePropertyAttribute] // RVA: 0xA4400 Offset: 0xA3800 VA: 0x1800A4400
	public bool blocksRaycasts { get; set; }
	[NativePropertyAttribute] // RVA: 0xA44D0 Offset: 0xA38D0 VA: 0x1800A44D0
	public bool ignoreParentGroups { get; }

	// Methods

	// RVA: 0x2302AF0 Offset: 0x2301EF0 VA: 0x182302AF0
	public float get_alpha() { }

	// RVA: 0x2302BB0 Offset: 0x2301FB0 VA: 0x182302BB0
	public void set_alpha(float value) { }

	// RVA: 0x2302B70 Offset: 0x2301F70 VA: 0x182302B70
	public bool get_interactable() { }

	// RVA: 0x2302C50 Offset: 0x2302050 VA: 0x182302C50
	public void set_interactable(bool value) { }

	// RVA: 0x2302AB0 Offset: 0x2301EB0 VA: 0x182302AB0
	public bool get_blocksRaycasts() { }

	// RVA: 0x2302C00 Offset: 0x2302000 VA: 0x182302C00
	public void set_blocksRaycasts(bool value) { }

	// RVA: 0x2302B30 Offset: 0x2301F30 VA: 0x182302B30
	public bool get_ignoreParentGroups() { }

	// RVA: 0x2302AB0 Offset: 0x2301EB0 VA: 0x182302AB0 Slot: 4
	public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) { }

}

