public class ScreenRotate : BaseScreenShake // TypeDefIndex: 9368
{	// Fields
	public AnimationCurve Pitch; // 0x28
	public AnimationCurve Yaw; // 0x30
	public AnimationCurve Roll; // 0x38
	public AnimationCurve ViewmodelEffect; // 0x40
	public float scale; // 0x48
	public bool useViewModelEffect; // 0x4C

	// Methods

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 4
	public override void Setup() { }

	// RVA: 0x4A1960 Offset: 0x4A0D60 VA: 0x1804A1960 Slot: 5
	public override void Run(float delta, ref CachedTransform<Camera> cam, ref CachedTransform<BaseViewModel> vm) { }

	// RVA: 0x4A1CD0 Offset: 0x4A10D0 VA: 0x1804A1CD0
	public void .ctor() { }

}

