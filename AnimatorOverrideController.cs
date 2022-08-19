public class AnimatorOverrideController : RuntimeAnimatorController // TypeDefIndex: 4488
{	// Fields
	internal AnimatorOverrideController.OnOverrideControllerDirtyCallback OnOverrideControllerDirty; // 0x18

	// Properties
	public AnimationClip Item { get; }

	// Methods

	// RVA: 0x22D65C0 Offset: 0x22D59C0 VA: 0x1822D65C0
	public AnimationClip get_Item(string name) { }

	[NativeMethodAttribute] // RVA: 0xCD010 Offset: 0xCC410 VA: 0x1800CD010
	// RVA: 0x22D6530 Offset: 0x22D5930 VA: 0x1822D6530
	private AnimationClip Internal_GetClipByName(string name, bool returnEffectiveClip) { }

	[RequiredByNativeCodeAttribute] // RVA: 0xCD0C0 Offset: 0xCC4C0 VA: 0x1800CD0C0
	[NativeConditionalAttribute] // RVA: 0xCD0C0 Offset: 0xCC4C0 VA: 0x1800CD0C0
	// RVA: 0x22D6590 Offset: 0x22D5990 VA: 0x1822D6590
	internal static void OnInvalidateOverrideController(AnimatorOverrideController controller) { }

}

internal sealed class AnimatorOverrideController.OnOverrideControllerDirtyCallback : MulticastDelegate // TypeDefIndex: 4489
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A76FB0 Offset: 0x1A763B0 VA: 0x181A76FB0 Slot: 12
	public virtual void Invoke() { }

	// RVA: 0x497020 Offset: 0x496420 VA: 0x180497020 Slot: 13
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

