public class LightLOD : MonoBehaviour, ILOD, IClientComponent // TypeDefIndex: 13044
{
	public float DistanceBias; 
	public bool ToggleLight; 
	public bool ToggleShadows; 
	private static List<LightLOD> pointLights; 
	private static List<LightLOD> spotLights; 
	private Light lightComponent; 
	private LightOccludee lightOccludee; 
	private LightEx lightEx; 
	private VolumetricLightBeam volumetricBeam; 
	private float cameraDist; 
	private float fadeSign; 
	private float maxLightIntensity; 
	private float shadowIntensity; 
	private static ListHashSet<LightLOD> registered; 
	private static readonly int UpdatePerFrame; 
	private static int updateIndex; 


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

