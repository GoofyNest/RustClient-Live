public class ViewmodelSway : MonoBehaviour // TypeDefIndex: 13200
{
	public float positionalSwaySpeed; 
	public float positionalSwayAmount; 
	public float rotationSwaySpeed; 
	public float rotationSwayAmount; 
	internal Vector3 lastPosition; 
	internal Vector3 smoothedVelocity; 
	internal Vector3 lastRotation; 
	internal Vector3 smoothedRotation; 
	public float rotateAmountTest; 


	public void Apply(ref CachedTransform<BaseViewModel> vm, BasePlayer player) { }

	private void ApplyPositionalSway(ref CachedTransform<BaseViewModel> vm, bool aiming, BasePlayer player) { }

	private void ApplyRotationSway(ref CachedTransform<BaseViewModel> vm, bool aiming) { }

	public void .ctor() { }

}

