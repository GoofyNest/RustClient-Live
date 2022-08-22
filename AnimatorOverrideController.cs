public class AnimatorOverrideController : RuntimeAnimatorController // TypeDefIndex: 4488
{	internal AnimatorOverrideController.OnOverrideControllerDirtyCallback OnOverrideControllerDirty; // 0x18

	public AnimationClip Item { get; }


	public AnimationClip get_Item(string name) { }

	[NativeMethodAttribute] // RVA: 0xCD010 Offset: 0xCC410 VA: 0x1800CD010
	private AnimationClip Internal_GetClipByName(string name, bool returnEffectiveClip) { }

	[RequiredByNativeCodeAttribute] // RVA: 0xCD0C0 Offset: 0xCC4C0 VA: 0x1800CD0C0
	[NativeConditionalAttribute] // RVA: 0xCD0C0 Offset: 0xCC4C0 VA: 0x1800CD0C0
	internal static void OnInvalidateOverrideController(AnimatorOverrideController controller) { }

}

internal sealed class AnimatorOverrideController.OnOverrideControllerDirtyCallback : MulticastDelegate // TypeDefIndex: 4489
{
	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke() { }

	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

