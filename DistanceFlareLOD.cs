public class DistanceFlareLOD : FacepunchBehaviour, ILOD, IClientComponent // TypeDefIndex: 11301
{	// Fields
	public bool isDynamic; // 0x18
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

	// Methods

	// RVA: 0x9C9690 Offset: 0x9C8A90 VA: 0x1809C9690
	private float GetDistance() { }

	// RVA: 0x9C9150 Offset: 0x9C8550 VA: 0x1809C9150
	protected void Awake() { }

	// RVA: 0x9C97E0 Offset: 0x9C8BE0 VA: 0x1809C97E0
	protected void OnEnable() { }

	// RVA: 0x9C9710 Offset: 0x9C8B10 VA: 0x1809C9710
	protected void OnDisable() { }

	// RVA: 0x9C9A50 Offset: 0x9C8E50 VA: 0x1809C9A50
	private void UpdateMaterialPropertyBlock() { }

	// RVA: 0x9C9A30 Offset: 0x9C8E30 VA: 0x1809C9A30
	private void ToggleFlare(bool state) { }

	// RVA: 0x9C94F0 Offset: 0x9C88F0 VA: 0x1809C94F0
	private void FadingToggle() { }

	// RVA: 0x9C9910 Offset: 0x9C8D10 VA: 0x1809C9910
	public void SetFlareActive(bool lightOn) { }

	// RVA: 0x9C9A20 Offset: 0x9C8E20 VA: 0x1809C9A20
	public void SetFlareIntensity(float intensity) { }

	// RVA: 0x9C9880 Offset: 0x9C8C80 VA: 0x1809C9880 Slot: 5
	public void RefreshLOD() { }

	// RVA: 0x9C9360 Offset: 0x9C8760 VA: 0x1809C9360 Slot: 4
	public void ChangeLOD() { }

	// RVA: 0x9C9BD0 Offset: 0x9C8FD0 VA: 0x1809C9BD0
	public void .ctor() { }

	// RVA: 0x9C9B80 Offset: 0x9C8F80 VA: 0x1809C9B80
	private static void .cctor() { }

}

