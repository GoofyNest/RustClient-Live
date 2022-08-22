public class LightLOD : MonoBehaviour, ILOD, IClientComponent // TypeDefIndex: 11305
{	public float DistanceBias; // 0x18
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


	private int GetMaxLightCount() { }

	private List<LightLOD> GetCurrentLights() { }

	private void FadeIn() { }

	private void FadeOut() { }

	protected void Awake() { }

	protected void OnEnable() { }

	protected void OnDisable() { }

	public static void ClearAll() { }

	public static void UpdateAll() { }

	private void UpdateLight(float lightIntensity, float shadowIntensity) { }

	private void UpdateLight() { }

	public void RefreshLOD() { }

	public void ChangeLOD() { }

	protected void OnValidate() { }

	public void .ctor() { }

	private static void .cctor() { }

}

