public class LightOccludee : MonoBehaviour // TypeDefIndex: 13116
{
	public float RadiusScale;
	public float MinTimeVisible;
	public bool IsDynamic;
	private Light light;
	private LightEx lightEx;
	private VolumetricLightBeam volumetricBeam;
	private OccludeeSphere occludee;
	private bool lodVisible;
	private bool volumeVisible;
	private bool occludeeCulled;

	public bool IsVisible { get; }


	public bool get_IsVisible() { }

	private void Awake() { }

	private void OnEnable() { }

	private void OnDisable() { }

	private void UpdateCullingSphere() { }

	public void UpdateDynamicOccludee() { }

	private void RegisterToOcclusionCulling() { }

	private void UnregisterFromOcclusionCulling() { }

	private void UpdateVisibility() { }

	public void SetLODVisible(bool state) { }

	public void SetVolumeVisible(bool state) { }

	protected virtual void OnVisibilityChanged(bool visible) { }

	public void .ctor() { }

}

