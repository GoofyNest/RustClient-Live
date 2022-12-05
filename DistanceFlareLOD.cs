public class DistanceFlareLOD : FacepunchBehaviour, ILOD, IClientComponent // TypeDefIndex: 13101
{
	public bool isDynamic;
	public float minEnabledDistance;
	public float maxEnabledDistance;
	public bool toggleFade;
	public float toggleFadeDuration;
	private LODCell cell;
	private Renderer flareRenderer;
	private float flareIntensity;
	private float fadeIntensity;
	private Color startColor;
	private static int emissionColorID;
	private static MaterialPropertyBlock block;
	private LODEnvironmentMode EnvironmentMode;
	private float fadeStartTime;
	private float fadeEndTime;
	private bool fadeToState;
	private bool queuedState;


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

