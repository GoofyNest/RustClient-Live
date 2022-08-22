public class ScreenRotate : BaseScreenShake // TypeDefIndex: 9368
{	public AnimationCurve Pitch; // 0x28
	public AnimationCurve Yaw; // 0x30
	public AnimationCurve Roll; // 0x38
	public AnimationCurve ViewmodelEffect; // 0x40
	public float scale; // 0x48
	public bool useViewModelEffect; // 0x4C


	public override void Setup() { }

	public override void Run(float delta, ref CachedTransform<Camera> cam, ref CachedTransform<BaseViewModel> vm) { }

	public void .ctor() { }

}

