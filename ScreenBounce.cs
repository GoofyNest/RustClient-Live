public class ScreenBounce : BaseScreenShake // TypeDefIndex: 11106
{
	public AnimationCurve bounceScale;
	public AnimationCurve bounceSpeed;
	public AnimationCurve bounceViewmodel;
	private float bounceTime;
	private Vector3 bounceVelocity;


	public override void Setup() { }

	public override void Run(float delta, ref CachedTransform<Camera> cam, ref CachedTransform<BaseViewModel> vm) { }

	public void .ctor() { }

}

