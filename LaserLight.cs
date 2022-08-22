public class LaserLight : AudioVisualisationEntity // TypeDefIndex: 9446
{	public Animator LaserAnimator; // 0x320
	public LineRenderer[] LineRenderers; // 0x328
	public MeshRenderer[] DotRenderers; // 0x330
	public MeshRenderer FlareRenderer; // 0x338
	public Light[] LightSources; // 0x340
	public LaserLight.ColourSetting RedSettings; // 0x348
	public LaserLight.ColourSetting GreenSettings; // 0x380
	public LaserLight.ColourSetting BlueSettings; // 0x3B8
	public LaserLight.ColourSetting YellowSettings; // 0x3F0
	public LaserLight.ColourSetting PinkSettings; // 0x428
	private static int AnimSpeedParameter; // 0x0
	private static readonly int TintColor; // 0x4
	private static MaterialPropertyBlock laserBlock; // 0x8
	private float lookingAtTime; // 0x460
	private TimeSince lastLookAtTick; // 0x464
	private static bool hasAwardedLookAtAchievement; // 0x10

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

public struct LaserLight.ColourSetting // TypeDefIndex: 9447
{	public Color PointLightColour; // 0x0
	public Material LaserMaterial; // 0x10
	public Color DotColour; // 0x18
	public Color FlareColour; // 0x28

}

