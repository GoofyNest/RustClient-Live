public class LightLOD : MonoBehaviour, ILOD, IClientComponent // TypeDefIndex: 11305
{	// Fields
	public float DistanceBias; // 0x18
	public bool ToggleLight; // 0x1C
	public bool ToggleShadows; // 0x1D
	private static List<LightLOD> pointLights; // 0x0
	private static List<LightLOD> spotLights; // 0x8
	private Light lightComponent; // 0x20
	private LightOccludee lightOccludee; // 0x28
	private LightEx lightEx; // 0x30
	private VolumetricLightBeam volumetricBeam; // 0x38
	private float cameraDist; // 0x40
	private float fadeSign; // 0x44
	private float maxLightIntensity; // 0x48
	private float shadowIntensity; // 0x4C
	private static ListHashSet<LightLOD> registered; // 0x10
	private static readonly int UpdatePerFrame; // 0x18
	private static int updateIndex; // 0x1C

	// Methods

	// RVA: 0x4EE3A0 Offset: 0x4ED7A0 VA: 0x1804EE3A0
	private int GetMaxLightCount() { }

	// RVA: 0x4EE2F0 Offset: 0x4ED6F0 VA: 0x1804EE2F0
	private List<LightLOD> GetCurrentLights() { }

	// RVA: 0x4EE2D0 Offset: 0x4ED6D0 VA: 0x1804EE2D0
	private void FadeIn() { }

	// RVA: 0x4EE2E0 Offset: 0x4ED6E0 VA: 0x1804EE2E0
	private void FadeOut() { }

	// RVA: 0x4EDEC0 Offset: 0x4ED2C0 VA: 0x1804EDEC0
	protected void Awake() { }

	// RVA: 0x4EE5E0 Offset: 0x4ED9E0 VA: 0x1804EE5E0
	protected void OnEnable() { }

	// RVA: 0x4EE4B0 Offset: 0x4ED8B0 VA: 0x1804EE4B0
	protected void OnDisable() { }

	// RVA: 0x4EE240 Offset: 0x4ED640 VA: 0x1804EE240
	public static void ClearAll() { }

	// RVA: 0x4EE6D0 Offset: 0x4EDAD0 VA: 0x1804EE6D0
	public static void UpdateAll() { }

	// RVA: 0x4EEA90 Offset: 0x4EDE90 VA: 0x1804EEA90
	private void UpdateLight(float lightIntensity, float shadowIntensity) { }

	// RVA: 0x4EE980 Offset: 0x4EDD80 VA: 0x1804EE980
	private void UpdateLight() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	public void RefreshLOD() { }

	// RVA: 0x4EDFB0 Offset: 0x4ED3B0 VA: 0x1804EDFB0 Slot: 4
	public void ChangeLOD() { }

	// RVA: 0x4EC610 Offset: 0x4EBA10 VA: 0x1804EC610
	protected void OnValidate() { }

	// RVA: 0x4EEE80 Offset: 0x4EE280 VA: 0x1804EEE80
	public void .ctor() { }

	// RVA: 0x4EED70 Offset: 0x4EE170 VA: 0x1804EED70
	private static void .cctor() { }

}

