public class ScreenBounce : BaseScreenShake // TypeDefIndex: 9365
{	// Fields
	public AnimationCurve bounceScale; // 0x28
	public AnimationCurve bounceSpeed; // 0x30
	public AnimationCurve bounceViewmodel; // 0x38
	private float bounceTime; // 0x40
	private Vector3 bounceVelocity; // 0x44

	// Methods

	// RVA: 0x4A1030 Offset: 0x4A0430 VA: 0x1804A1030 Slot: 4
	public override void Setup() { }

	// RVA: 0x4A0C40 Offset: 0x4A0040 VA: 0x1804A0C40 Slot: 5
	public override void Run(float delta, ref CachedTransform<Camera> cam, ref CachedTransform<BaseViewModel> vm) { }

	// RVA: 0x4A1060 Offset: 0x4A0460 VA: 0x1804A1060
	public void .ctor() { }

}

