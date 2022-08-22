public class DiscoFloor : AudioVisualisationEntity // TypeDefIndex: 9438
{	public float GradientDuration; // 0x320
	public float VolumeSensitivityMultiplier; // 0x324
	public float BaseSpeed; // 0x328
	public Light[] LightSources; // 0x330
	public DiscoFloorMesh FloorMesh; // 0x338
	private float currentFloorTime; // 0x340
	private DiscoFloorColourLookups cachedLookups; // 0x348

	private Gradient ColourGradient { get; }
	public override bool ShowPatternOption { get; }
	public override bool ShowSpeedOption { get; }
	public override bool ShowVolumeOption { get; }
	public override bool ShowGradientOption { get; }


	private Gradient get_ColourGradient() { }

	protected override void ClientInit(Entity info) { }

	public override void ClientOnEnable() { }

	protected override void UpdateVisualisation(float volume, bool force = False) { }

	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	public override bool get_ShowPatternOption() { }

	public override bool get_ShowSpeedOption() { }

	public override bool get_ShowVolumeOption() { }

	public override bool get_ShowGradientOption() { }

	protected override void UpdateVisualSettings() { }

	private float GetCurrentVolumeSensitivity() { }

	private float GetCurrentSpeed() { }

	public void .ctor() { }

}

