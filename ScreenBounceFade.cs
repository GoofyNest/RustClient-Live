public class ScreenBounceFade : BaseScreenShake // TypeDefIndex: 11087
{
	public AnimationCurve bounceScale; 
	public AnimationCurve bounceSpeed; 
	public AnimationCurve bounceViewmodel; 
	public AnimationCurve distanceFalloff; 
	public AnimationCurve timeFalloff; 
	private float bounceTime; 
	private Vector3 bounceVelocity; 
	public float maxDistance; 
	public float scale; 


	public override void Setup() { }

	public override void Run(float delta, ref CachedTransform<Camera> cam, ref CachedTransform<BaseViewModel> vm) { }

	public void .ctor() { }

}

