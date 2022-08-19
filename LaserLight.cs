public class LaserLight : AudioVisualisationEntity // TypeDefIndex: 9446
{	// Fields
	public Animator LaserAnimator; // 0x320
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

	// Properties
	public override bool ShowColourOption { get; }
	public override bool ShowSpeedOption { get; }
	public override bool ShowVolumeOption { get; }

	// Methods

	// RVA: 0x6BF0D0 Offset: 0x6BE4D0 VA: 0x1806BF0D0 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x6BFA70 Offset: 0x6BEE70 VA: 0x1806BFA70 Slot: 159
	protected override void UpdateVisualisation(float volume, bool force = False) { }

	// RVA: 0x6BF270 Offset: 0x6BE670 VA: 0x1806BF270
	private void GetCurrentVolumeRange(out float min, out float max) { }

	// RVA: 0x6BF220 Offset: 0x6BE620 VA: 0x1806BF220
	private void GetCurrentSpeedRange(out float minSpeed, out float maxSpeed) { }

	// RVA: 0x6BF100 Offset: 0x6BE500 VA: 0x1806BF100
	private LaserLight.ColourSetting GetColourSettings(AudioVisualisationEntity.LightColour colour) { }

	// RVA: 0x6BF5E0 Offset: 0x6BE9E0 VA: 0x1806BF5E0 Slot: 165
	protected override void UpdateVisualSettings() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 160
	public override bool get_ShowColourOption() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 162
	public override bool get_ShowSpeedOption() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 161
	public override bool get_ShowVolumeOption() { }

	// RVA: 0x6BF2C0 Offset: 0x6BE6C0 VA: 0x1806BF2C0 Slot: 75
	public override void LookingAtTick() { }

	// RVA: 0x6BF410 Offset: 0x6BE810 VA: 0x1806BF410 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x6BFC30 Offset: 0x6BF030 VA: 0x1806BFC30
	public void .ctor() { }

	// RVA: 0x6BFB90 Offset: 0x6BEF90 VA: 0x1806BFB90
	private static void .cctor() { }

}

public struct LaserLight.ColourSetting // TypeDefIndex: 9447
{	// Fields
	public Color PointLightColour; // 0x0
	public Material LaserMaterial; // 0x10
	public Color DotColour; // 0x18
	public Color FlareColour; // 0x28

}

