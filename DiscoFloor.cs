public class DiscoFloor : AudioVisualisationEntity // TypeDefIndex: 9438
{	// Fields
	public float GradientDuration; // 0x320
	public float VolumeSensitivityMultiplier; // 0x324
	public float BaseSpeed; // 0x328
	public Light[] LightSources; // 0x330
	public DiscoFloorMesh FloorMesh; // 0x338
	private float currentFloorTime; // 0x340
	private DiscoFloorColourLookups cachedLookups; // 0x348

	// Properties
	private Gradient ColourGradient { get; }
	public override bool ShowPatternOption { get; }
	public override bool ShowSpeedOption { get; }
	public override bool ShowVolumeOption { get; }
	public override bool ShowGradientOption { get; }

	// Methods

	// RVA: 0x9C75A0 Offset: 0x9C69A0 VA: 0x1809C75A0
	private Gradient get_ColourGradient() { }

	// RVA: 0x9C6B10 Offset: 0x9C5F10 VA: 0x1809C6B10 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x9C6C00 Offset: 0x9C6000 VA: 0x1809C6C00 Slot: 13
	public override void ClientOnEnable() { }

	// RVA: 0x9C6FE0 Offset: 0x9C63E0 VA: 0x1809C6FE0 Slot: 159
	protected override void UpdateVisualisation(float volume, bool force = False) { }

	// RVA: 0x9C6CE0 Offset: 0x9C60E0 VA: 0x1809C6CE0 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 163
	public override bool get_ShowPatternOption() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 162
	public override bool get_ShowSpeedOption() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 161
	public override bool get_ShowVolumeOption() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 164
	public override bool get_ShowGradientOption() { }

	// RVA: 0x9C6F80 Offset: 0x9C6380 VA: 0x1809C6F80 Slot: 165
	protected override void UpdateVisualSettings() { }

	// RVA: 0x9C6CA0 Offset: 0x9C60A0 VA: 0x1809C6CA0
	private float GetCurrentVolumeSensitivity() { }

	// RVA: 0x9C6C70 Offset: 0x9C6070 VA: 0x1809C6C70
	private float GetCurrentSpeed() { }

	// RVA: 0x9C7530 Offset: 0x9C6930 VA: 0x1809C7530
	public void .ctor() { }

}

