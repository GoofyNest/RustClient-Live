public class LiquidWeaponEffects : MonoBehaviour // TypeDefIndex: 9469
{	public ParticleSystem RootPS; // 0x18
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


	public void Init(BasePlayer player, float currentRange, float maxRange) { }

	public void SetWaterLevel(float fraction, bool instant) { }

	public void SetPressureFraction(float pressure) { }

	private void Update() { }

	public void OnDisable() { }

	public void StartEmission() { }

	public void StopEmission(float delay) { }

	private void StopEmissionCo() { }

	private void FixedUpdate() { }

	private void DoSplash(Vector3 point, Vector3 direction) { }

	private void OnDrawGizmos() { }

	public void StartShootSounds() { }

	public void StopShootSounds() { }

	private void UpdateShootSounds() { }

	private void StartImpactSounds(Vector3 position) { }

	private void StopImpactSounds() { }

	private void RepositionImpactSounds(Vector3 position) { }

	public void .ctor() { }

}

