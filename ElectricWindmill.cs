public class ElectricWindmill : IOEntity // TypeDefIndex: 10466
{
	public Animator animator;
	public int maxPowerGeneration;
	public Transform vaneRot;
	public SoundDefinition wooshSound;
	public Transform wooshOrigin;
	public float targetSpeed;
	private float serverWindSpeed;
	private float lastServerTime;
	protected static int speedIndex;


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

