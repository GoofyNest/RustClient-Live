public class AnimatorOverrideController : RuntimeAnimatorController // TypeDefIndex: 4491
{
	internal AnimatorOverrideController.OnOverrideControllerDirtyCallback OnOverrideControllerDirty; 

	public AnimationClip Item { get; }


	public AnimationClip get_Item(string name) { }

	[NativeMethodAttribute] 
	private AnimationClip Internal_GetClipByName(string name, bool returnEffectiveClip) { }

	[RequiredByNativeCodeAttribute] 
	[NativeConditionalAttribute] 
	internal static void OnInvalidateOverrideController(AnimatorOverrideController controller) { }

}

internal sealed class AnimatorOverrideController.OnOverrideControllerDirtyCallback : MulticastDelegate // TypeDefIndex: 4492
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke() { }

	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

