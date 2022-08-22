public class ViewmodelSway : MonoBehaviour // TypeDefIndex: 11461
{	public float positionalSwaySpeed; // 0x18
	public float positionalSwayAmount; // 0x1C
	public float rotationSwaySpeed; // 0x20
	public float rotationSwayAmount; // 0x24
	internal Vector3 lastPosition; // 0x28
	internal Vector3 smoothedVelocity; // 0x34
	internal Vector3 lastRotation; // 0x40
	internal Vector3 smoothedRotation; // 0x4C
	public float rotateAmountTest; // 0x58


	public void Apply(ref CachedTransform<BaseViewModel> vm, BasePlayer player) { }

	private void ApplyPositionalSway(ref CachedTransform<BaseViewModel> vm, bool aiming, BasePlayer player) { }

	private void ApplyRotationSway(ref CachedTransform<BaseViewModel> vm, bool aiming) { }

	public void .ctor() { }

}

