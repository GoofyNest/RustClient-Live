public class SedanWheelSmoke : MonoBehaviour // TypeDefIndex: 8297
{	// Fields
	public ParticleSystem[] tireSmoke; // 0x18
	public ParticleSystem[] tireWaterSplash; // 0x20
	public ParticleSystem[] tireWaterSplash_Extra; // 0x28
	public bool[] wheelTouching; // 0x30
	private ParticleSystem[] activeTireEffect; // 0x38
	private Vector3 vecLastPosition; // 0x40
	private float forwardSpeed; // 0x4C
	private float updateTime; // 0x50

	// Methods

	// RVA: 0x4A4480 Offset: 0x4A3880 VA: 0x1804A4480
	public void InitWheelSmoke() { }

	// RVA: 0x4A4E00 Offset: 0x4A4200 VA: 0x1804A4E00
	public void UpdateWheelSmoke() { }

	// RVA: 0x4A4630 Offset: 0x4A3A30 VA: 0x1804A4630
	private void UpdateTireEffects(float speedRatio) { }

	// RVA: 0x4A4070 Offset: 0x4A3470 VA: 0x1804A4070
	private bool CheckInWater(int i) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

