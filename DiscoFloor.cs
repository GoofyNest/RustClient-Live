public class DiscoFloor : AudioVisualisationEntity // TypeDefIndex: 11110
{
	public float GradientDuration; 
	public float VolumeSensitivityMultiplier; 
	public float BaseSpeed; 
	public Light[] LightSources; 
	public DiscoFloorMesh FloorMesh; 
	private float currentFloorTime; 
	private DiscoFloorColourLookups cachedLookups; 

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

