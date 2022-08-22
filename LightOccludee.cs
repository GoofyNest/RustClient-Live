public class LightOccludee : MonoBehaviour // TypeDefIndex: 11306
{	public float RadiusScale; // 0x18
	public float MinTimeVisible; // 0x1C
	public bool IsDynamic; // 0x20
	private Light light; // 0x28
	private LightEx lightEx; // 0x30
	private VolumetricLightBeam volumetricBeam; // 0x38
	private OccludeeSphere occludee; // 0x40
	private bool lodVisible; // 0x60
	private bool volumeVisible; // 0x61
	private bool occludeeCulled; // 0x62

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

