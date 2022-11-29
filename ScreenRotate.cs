public class ScreenRotate : BaseScreenShake // TypeDefIndex: 11103
{
	public AnimationCurve Pitch; 
	public AnimationCurve Yaw; 
	public AnimationCurve Roll; 
	public AnimationCurve ViewmodelEffect; 
	public float scale; 
	public bool useViewModelEffect; 


	public override void Setup() { }

	public override void Run(float delta, ref CachedTransform<Camera> cam, ref CachedTransform<BaseViewModel> vm) { }

	public void .ctor() { }

}

