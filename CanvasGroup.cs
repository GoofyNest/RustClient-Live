public sealed class CanvasGroup : Behaviour, ICanvasRaycastFilter // TypeDefIndex: 4731
{	[NativePropertyAttribute] // RVA: 0xA4070 Offset: 0xA3470 VA: 0x1800A4070
	public float alpha { get; set; }
	[NativePropertyAttribute] // RVA: 0xA41C0 Offset: 0xA35C0 VA: 0x1800A41C0
	public bool interactable { get; set; }
	[NativePropertyAttribute] // RVA: 0xA4400 Offset: 0xA3800 VA: 0x1800A4400
	public bool blocksRaycasts { get; set; }
	[NativePropertyAttribute] // RVA: 0xA44D0 Offset: 0xA38D0 VA: 0x1800A44D0
	public bool ignoreParentGroups { get; }


	public float get_alpha() { }

	public void set_alpha(float value) { }

	public bool get_interactable() { }

	public void set_interactable(bool value) { }

	public bool get_blocksRaycasts() { }

	public void set_blocksRaycasts(bool value) { }

	public bool get_ignoreParentGroups() { }

	public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) { }

}

