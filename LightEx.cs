public class LightEx : UpdateBehaviour, IClientComponent // TypeDefIndex: 9195
{	// Fields
	public bool alterColor; // 0x20
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

	// Methods

	// RVA: 0x4EBE30 Offset: 0x4EB230 VA: 0x1804EBE30
	protected void Awake() { }

	// RVA: 0x4EC4C0 Offset: 0x4EB8C0 VA: 0x1804EC4C0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x4EC430 Offset: 0x4EB830 VA: 0x1804EC430 Slot: 6
	protected override void OnDisable() { }

	// RVA: 0x4EC080 Offset: 0x4EB480 VA: 0x1804EC080 Slot: 4
	public override void DeltaUpdate(float deltaTime) { }

	// RVA: 0x4EC610 Offset: 0x4EBA10 VA: 0x1804EC610
	protected void OnValidate() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0
	public static bool CheckConflict(GameObject go) { }

	// RVA: 0x4EC620 Offset: 0x4EBA20 VA: 0x1804EC620
	public void .ctor() { }

}

