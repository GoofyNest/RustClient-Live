public class SedanWheelSmoke : MonoBehaviour // TypeDefIndex: 8297
{	public ParticleSystem[] tireSmoke; // 0x18
	public ParticleSystem[] tireWaterSplash; // 0x20
	public ParticleSystem[] tireWaterSplash_Extra; // 0x28
	public bool[] wheelTouching; // 0x30
	private ParticleSystem[] activeTireEffect; // 0x38
	private Vector3 vecLastPosition; // 0x40
	private float forwardSpeed; // 0x4C
	private float updateTime; // 0x50


	public void InitWheelSmoke() { }

	public void UpdateWheelSmoke() { }

	private void UpdateTireEffects(float speedRatio) { }

	private bool CheckInWater(int i) { }

	public void .ctor() { }

}

