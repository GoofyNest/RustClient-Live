public class NVGCamera : FacepunchBehaviour, IClothingChanged // TypeDefIndex: 8676
{	// Fields
	public static NVGCamera instance; // 0x0
	public PostProcessVolume postProcessVolume; // 0x18
	public GameObject lights; // 0x20
	private bool initalized; // 0x28

	// Methods

	// RVA: 0x7C3820 Offset: 0x7C2C20 VA: 0x1807C3820
	public void Awake() { }

	// RVA: 0x7C4280 Offset: 0x7C3680 VA: 0x1807C4280
	public void Start() { }

	// RVA: 0x7C3E20 Offset: 0x7C3220 VA: 0x1807C3E20
	private void OnEnable() { }

	// RVA: 0x7C3D70 Offset: 0x7C3170 VA: 0x1807C3D70
	private void OnDisable() { }

	// RVA: 0x7C3B00 Offset: 0x7C2F00 VA: 0x1807C3B00 Slot: 4
	public void OnClothingChanged() { }

	// RVA: 0x7C3A00 Offset: 0x7C2E00 VA: 0x1807C3A00
	public static bool IsEffectOn() { }

	// RVA: 0x7C3FB0 Offset: 0x7C33B0 VA: 0x1807C3FB0
	public static void SetEffectsOn(bool wantsOn, bool fadeOut = True) { }

	// RVA: 0x7C3EA0 Offset: 0x7C32A0 VA: 0x1807C3EA0
	public void OnThink() { }

	// RVA: 0x7C38F0 Offset: 0x7C2CF0 VA: 0x1807C38F0
	public void FadeOut() { }

	// RVA: 0x4B7D40 Offset: 0x4B7140 VA: 0x1804B7D40
	public void .ctor() { }

}

