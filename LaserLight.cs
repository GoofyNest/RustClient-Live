public class LaserLight : AudioVisualisationEntity // TypeDefIndex: 9450
{
	public Animator LaserAnimator; 
	public LineRenderer[] LineRenderers; 
	public MeshRenderer[] DotRenderers; 
	public MeshRenderer FlareRenderer; 
	public Light[] LightSources; 
	public LaserLight.ColourSetting RedSettings; 
	public LaserLight.ColourSetting GreenSettings; 
	public LaserLight.ColourSetting BlueSettings; 
	public LaserLight.ColourSetting YellowSettings; 
	public LaserLight.ColourSetting PinkSettings; 
	private static int AnimSpeedParameter; 
	private static readonly int TintColor; 
	private static MaterialPropertyBlock laserBlock; 
	private float lookingAtTime; 
	private TimeSince lastLookAtTick; 
	private static bool hasAwardedLookAtAchievement; 

	public override bool ShowColourOption { get; }
	public override bool ShowSpeedOption { get; }
	public override bool ShowVolumeOption { get; }


	protected override void ClientInit(Entity info) { }

	protected override void UpdateVisualisation(float volume, bool force = False) { }

	private void GetCurrentVolumeRange(out float min, out float max) { }

	private void GetCurrentSpeedRange(out float minSpeed, out float maxSpeed) { }

	private LaserLight.ColourSetting GetColourSettings(AudioVisualisationEntity.LightColour colour) { }

	protected override void UpdateVisualSettings() { }

	public override bool get_ShowColourOption() { }

	public override bool get_ShowSpeedOption() { }

	public override bool get_ShowVolumeOption() { }

	public override void LookingAtTick() { }

	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public struct LaserLight.ColourSetting // TypeDefIndex: 9451
{
	public Color PointLightColour; 
	public Material LaserMaterial; 
	public Color DotColour; 
	public Color FlareColour; 

}

