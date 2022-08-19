public class BaseBulb : MonoBehaviour // TypeDefIndex: 8824
{	// Fields
	public Renderer bulbRenderer; // 0x18
	private static readonly int timeOffsetHash; // 0x0
	private static readonly int bulbIndexHash; // 0x4
	private static readonly int modeHash; // 0x8
	private AdvancedChristmasLights.AnimationType currentAnimationType; // 0x20
	private float timeOffset; // 0x24
	private int bulbIndex; // 0x28
	private bool isOn; // 0x2C
	private MaterialPropertyBlock materialPropertyBlock; // 0x30

	// Methods

	// RVA: 0x7EEBE0 Offset: 0x7EDFE0 VA: 0x1807EEBE0 Slot: 4
	public virtual void SetOn(bool wantsOn) { }

	// RVA: 0x7EEBF0 Offset: 0x7EDFF0 VA: 0x1807EEBF0 Slot: 5
	public virtual void SetSpacingIndex(float timeOffset, int bulbIndex) { }

	// RVA: 0x7EEBD0 Offset: 0x7EDFD0 VA: 0x1807EEBD0 Slot: 6
	public virtual void SetBulbAnimation(AdvancedChristmasLights.AnimationType type) { }

	// RVA: 0x7EEC00 Offset: 0x7EE000 VA: 0x1807EEC00
	private void UpdateMaterialProperties() { }

	// RVA: 0x7EEDC0 Offset: 0x7EE1C0 VA: 0x1807EEDC0
	public void .ctor() { }

	// RVA: 0x7EED40 Offset: 0x7EE140 VA: 0x1807EED40
	private static void .cctor() { }

}

