public class ScreenBounceFade : BaseScreenShake // TypeDefIndex: 9366
{	public AnimationCurve bounceScale; // 0x28
	public AnimationCurve bounceSpeed; // 0x30
	public AnimationCurve bounceViewmodel; // 0x38
	public AnimationCurve distanceFalloff; // 0x40
	public AnimationCurve timeFalloff; // 0x48
	private float bounceTime; // 0x50
	private Vector3 bounceVelocity; // 0x54
	public float maxDistance; // 0x60
	public float scale; // 0x64


	public override void Setup() { }

	public override void Run(float delta, ref CachedTransform<Camera> cam, ref CachedTransform<BaseViewModel> vm) { }

	public void .ctor() { }

}

