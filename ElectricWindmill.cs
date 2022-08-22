public class ElectricWindmill : IOEntity // TypeDefIndex: 8740
{	public Animator animator; // 0x288
	public int maxPowerGeneration; // 0x290
	public Transform vaneRot; // 0x298
	public SoundDefinition wooshSound; // 0x2A0
	public Transform wooshOrigin; // 0x2A8
	public float targetSpeed; // 0x2B0
	private float serverWindSpeed; // 0x2B4
	private float lastServerTime; // 0x2B8
	protected static int speedIndex; // 0x0


	public override int MaximalPowerOutput() { }

	public override bool IsRootEntity() { }

	public float GetWindSpeedScale() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public Vector3 GetWindAimDir(float time) { }

	public void Woosh() { }

	public void Update() { }

	public void .ctor() { }

	private static void .cctor() { }

}

