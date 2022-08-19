public class LightOccludee : MonoBehaviour // TypeDefIndex: 11306
{	// Fields
	public float RadiusScale; // 0x18
	public float MinTimeVisible; // 0x1C
	public bool IsDynamic; // 0x20
	private Light light; // 0x28
	private LightEx lightEx; // 0x30
	private VolumetricLightBeam volumetricBeam; // 0x38
	private OccludeeSphere occludee; // 0x40
	private bool lodVisible; // 0x60
	private bool volumeVisible; // 0x61
	private bool occludeeCulled; // 0x62

	// Properties
	public bool IsVisible { get; }

	// Methods

	// RVA: 0x4EFCF0 Offset: 0x4EF0F0 VA: 0x1804EFCF0
	public bool get_IsVisible() { }

	// RVA: 0x4EF220 Offset: 0x4EE620 VA: 0x1804EF220
	private void Awake() { }

	// RVA: 0x4EF380 Offset: 0x4EE780 VA: 0x1804EF380
	private void OnEnable() { }

	// RVA: 0x4EF2B0 Offset: 0x4EE6B0 VA: 0x1804EF2B0
	private void OnDisable() { }

	// RVA: 0x4EF910 Offset: 0x4EED10 VA: 0x1804EF910
	private void UpdateCullingSphere() { }

	// RVA: 0x4EFAD0 Offset: 0x4EEED0 VA: 0x1804EFAD0
	public void UpdateDynamicOccludee() { }

	// RVA: 0x4EF410 Offset: 0x4EE810 VA: 0x1804EF410
	private void RegisterToOcclusionCulling() { }

	// RVA: 0x4EF8A0 Offset: 0x4EECA0 VA: 0x1804EF8A0
	private void UnregisterFromOcclusionCulling() { }

	// RVA: 0x4EFB90 Offset: 0x4EEF90 VA: 0x1804EFB90
	private void UpdateVisibility() { }

	// RVA: 0x4EF880 Offset: 0x4EEC80 VA: 0x1804EF880
	public void SetLODVisible(bool state) { }

	// RVA: 0x4EF890 Offset: 0x4EEC90 VA: 0x1804EF890
	public void SetVolumeVisible(bool state) { }

	// RVA: 0x4EF400 Offset: 0x4EE800 VA: 0x1804EF400 Slot: 4
	protected virtual void OnVisibilityChanged(bool visible) { }

	// RVA: 0x4EFCD0 Offset: 0x4EF0D0 VA: 0x1804EFCD0
	public void .ctor() { }

}

