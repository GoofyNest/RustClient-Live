public class DistanceFlareLOD : FacepunchBehaviour, ILOD, IClientComponent // TypeDefIndex: 11301
{	public bool isDynamic; // 0x18
	public float minEnabledDistance; // 0x1C
	public float maxEnabledDistance; // 0x20
	public bool toggleFade; // 0x24
	public float toggleFadeDuration; // 0x28
	private LODCell cell; // 0x30
	private Renderer flareRenderer; // 0x38
	private float flareIntensity; // 0x40
	private float fadeIntensity; // 0x44
	private Color startColor; // 0x48
	private static int emissionColorID; // 0x0
	private static MaterialPropertyBlock block; // 0x8
	private LODEnvironmentMode EnvironmentMode; // 0x58
	private float fadeStartTime; // 0x5C
	private float fadeEndTime; // 0x60
	private bool fadeToState; // 0x64
	private bool queuedState; // 0x65


	private float GetDistance() { }

	protected void Awake() { }

	protected void OnEnable() { }

	protected void OnDisable() { }

	private void UpdateMaterialPropertyBlock() { }

	private void ToggleFlare(bool state) { }

	private void FadingToggle() { }

	public void SetFlareActive(bool lightOn) { }

	public void SetFlareIntensity(float intensity) { }

	public void RefreshLOD() { }

	public void ChangeLOD() { }

	public void .ctor() { }

	private static void .cctor() { }

}

