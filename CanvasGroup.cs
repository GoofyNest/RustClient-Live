public sealed class CanvasGroup : Behaviour, ICanvasRaycastFilter // TypeDefIndex: 4734
{
	[NativePropertyAttribute] 
	public float alpha { get; set; }
	[NativePropertyAttribute] 
	public bool interactable { get; set; }
	[NativePropertyAttribute] 
	public bool blocksRaycasts { get; set; }
	[NativePropertyAttribute] 
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

