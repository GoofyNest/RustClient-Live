public class ViewmodelSway : MonoBehaviour // TypeDefIndex: 11461
{	// Fields
	public float positionalSwaySpeed; // 0x18
	public float positionalSwayAmount; // 0x1C
	public float rotationSwaySpeed; // 0x20
	public float rotationSwayAmount; // 0x24
	internal Vector3 lastPosition; // 0x28
	internal Vector3 smoothedVelocity; // 0x34
	internal Vector3 lastRotation; // 0x40
	internal Vector3 smoothedRotation; // 0x4C
	public float rotateAmountTest; // 0x58

	// Methods

	// RVA: 0x7DBDB0 Offset: 0x7DB1B0 VA: 0x1807DBDB0
	public void Apply(ref CachedTransform<BaseViewModel> vm, BasePlayer player) { }

	// RVA: 0x7DB100 Offset: 0x7DA500 VA: 0x1807DB100
	private void ApplyPositionalSway(ref CachedTransform<BaseViewModel> vm, bool aiming, BasePlayer player) { }

	// RVA: 0x7DB5E0 Offset: 0x7DA9E0 VA: 0x1807DB5E0
	private void ApplyRotationSway(ref CachedTransform<BaseViewModel> vm, bool aiming) { }

	// RVA: 0x7DBE90 Offset: 0x7DB290 VA: 0x1807DBE90
	public void .ctor() { }

}

