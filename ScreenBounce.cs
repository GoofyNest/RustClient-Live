public class ScreenBounce : BaseScreenShake // TypeDefIndex: 9365
{	public AnimationCurve bounceScale; // 0x28
	public AnimationCurve bounceSpeed; // 0x30
	public AnimationCurve bounceViewmodel; // 0x38
	private float bounceTime; // 0x40
	private Vector3 bounceVelocity; // 0x44


	public override void Setup() { }

	public override void Run(float delta, ref CachedTransform<Camera> cam, ref CachedTransform<BaseViewModel> vm) { }

	public void .ctor() { }

}

