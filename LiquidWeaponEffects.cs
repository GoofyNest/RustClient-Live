public class LiquidWeaponEffects : MonoBehaviour // TypeDefIndex: 9469
{	// Fields
	public ParticleSystem RootPS; // 0x18
	public ParticleSystem EmissionPS; // 0x20
	public ParticleSystem InnerEmissionPS; // 0x28
	public LiquidWobble Liquid; // 0x30
	[HeaderAttribute] // RVA: 0x71A60 Offset: 0x70E60 VA: 0x180071A60
	public float MinPressureSpeed; // 0x38
	public float MaxPressureSpeed; // 0x3C
	public AnimationCurve PressureSpeedCurve; // 0x40
	public Vector2 StreamSize; // 0x48
	public AnimationCurve PressureSizeMultiplierCurve; // 0x50
	[HeaderAttribute] // RVA: 0x71BE0 Offset: 0x70FE0 VA: 0x180071BE0
	public float MinPressureInnerSpeed; // 0x58
	public float MaxPressureInnerSpeed; // 0x5C
	public AnimationCurve InnerPressureSpeedCurve; // 0x60
	public Vector2 InnerStreamSize; // 0x68
	public AnimationCurve InnerPressureSizeMultiplierCurve; // 0x70
	[HeaderAttribute] // RVA: 0x71D40 Offset: 0x71140 VA: 0x180071D40
	public bool UseImpactSplashEffect; // 0x78
	public GameObjectRef ImpactSplashEffect; // 0x80
	public float ImpactSplashEffectInterval; // 0x88
	public float FillSpeed; // 0x8C
	private BasePlayer player; // 0x90
	private float maxRange; // 0x98
	private float currentRange; // 0x9C
	private float pressure; // 0xA0
	private float nextSplashTime; // 0xA4
	private float targetWaterLevel; // 0xA8
	[HeaderAttribute] // RVA: 0x71F00 Offset: 0x71300 VA: 0x180071F00
	public bool firstPersonSounds; // 0xAC
	public SoundDefinition shootStartSoundDef; // 0xB0
	public SoundDefinition shootLoopSoundDef; // 0xB8
	public SoundDefinition shootLowPressureLoopSoundDef; // 0xC0
	private Sound shootLoopSound; // 0xC8
	private Sound shootLowPressureLoopSound; // 0xD0
	private SoundModulation.Modulator shootLoopGainMod; // 0xD8
	private SoundModulation.Modulator shootLowPressureGainMod; // 0xE0
	public SoundDefinition impactStartSoundDef; // 0xE8
	public SoundDefinition impactLoopSoundDef; // 0xF0
	private Sound impactLoopSound; // 0xF8
	private bool impactStartPlayed; // 0x100
	private bool lastImpactHit; // 0x101
	private Vector3 lastImpactPosition; // 0x104
	private bool emitting; // 0x110

	// Methods

	// RVA: 0x4F18B0 Offset: 0x4F0CB0 VA: 0x1804F18B0
	public void Init(BasePlayer player, float currentRange, float maxRange) { }

	// RVA: 0x4F1C70 Offset: 0x4F1070 VA: 0x1804F1C70
	public void SetWaterLevel(float fraction, bool instant) { }

	// RVA: 0x4F1C60 Offset: 0x4F1060 VA: 0x1804F1C60
	public void SetPressureFraction(float pressure) { }

	// RVA: 0x4F26F0 Offset: 0x4F1AF0 VA: 0x1804F26F0
	private void Update() { }

	// RVA: 0x4F1900 Offset: 0x4F0D00 VA: 0x1804F1900
	public void OnDisable() { }

	// RVA: 0x4F1D20 Offset: 0x4F1120 VA: 0x1804F1D20
	public void StartEmission() { }

	// RVA: 0x4F2400 Offset: 0x4F1800 VA: 0x1804F2400
	public void StopEmission(float delay) { }

	// RVA: 0x4F2370 Offset: 0x4F1770 VA: 0x1804F2370
	private void StopEmissionCo() { }

	// RVA: 0x4F12E0 Offset: 0x4F06E0 VA: 0x1804F12E0
	private void FixedUpdate() { }

	// RVA: 0x4F1200 Offset: 0x4F0600 VA: 0x1804F1200
	private void DoSplash(Vector3 point, Vector3 direction) { }

	// RVA: 0x4F19A0 Offset: 0x4F0DA0 VA: 0x1804F19A0
	private void OnDrawGizmos() { }

	// RVA: 0x4F1FB0 Offset: 0x4F13B0 VA: 0x1804F1FB0
	public void StartShootSounds() { }

	// RVA: 0x4F2550 Offset: 0x4F1950 VA: 0x1804F2550
	public void StopShootSounds() { }

	// RVA: 0x4F26A0 Offset: 0x4F1AA0 VA: 0x1804F26A0
	private void UpdateShootSounds() { }

	// RVA: 0x4F1DD0 Offset: 0x4F11D0 VA: 0x1804F1DD0
	private void StartImpactSounds(Vector3 position) { }

	// RVA: 0x4F2490 Offset: 0x4F1890 VA: 0x1804F2490
	private void StopImpactSounds() { }

	// RVA: 0x4F1BA0 Offset: 0x4F0FA0 VA: 0x1804F1BA0
	private void RepositionImpactSounds(Vector3 position) { }

	// RVA: 0x4F2940 Offset: 0x4F1D40 VA: 0x1804F2940
	public void .ctor() { }

}

