public class LightEx : UpdateBehaviour, IClientComponent // TypeDefIndex: 9195
{	public bool alterColor; // 0x20
	public float colorTimeScale; // 0x24
	public Color colorA; // 0x28
	public Color colorB; // 0x38
	public AnimationCurve blendCurve; // 0x48
	public bool loopColor; // 0x50
	public bool alterIntensity; // 0x51
	public float intensityTimeScale; // 0x54
	public AnimationCurve intenseCurve; // 0x58
	public float intensityCurveScale; // 0x60
	public bool loopIntensity; // 0x64
	public bool randomOffset; // 0x65
	public float randomIntensityStartScale; // 0x68
	private float initialRange; // 0x6C
	private Color initialColor; // 0x70
	private float initialIntensity; // 0x80
	private Light lightComponent; // 0x88
	private bool canToggleLight; // 0x90
	private float time; // 0x94
	private LightLOD lightLOD; // 0x98


	protected void Awake() { }

	protected override void OnEnable() { }

	protected override void OnDisable() { }

	public override void DeltaUpdate(float deltaTime) { }

	protected void OnValidate() { }

	public static bool CheckConflict(GameObject go) { }

	public void .ctor() { }

}

