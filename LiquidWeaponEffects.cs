public class LiquidWeaponEffects : MonoBehaviour // TypeDefIndex: 11188
{
	public ParticleSystem RootPS; 
	public ParticleSystem EmissionPS; 
	public ParticleSystem InnerEmissionPS; 
	public LiquidWobble Liquid; 
	[HeaderAttribute] 
	public float MinPressureSpeed; 
	public float MaxPressureSpeed; 
	public AnimationCurve PressureSpeedCurve; 
	public Vector2 StreamSize; 
	public AnimationCurve PressureSizeMultiplierCurve; 
	[HeaderAttribute] 
	public float MinPressureInnerSpeed; 
	public float MaxPressureInnerSpeed; 
	public AnimationCurve InnerPressureSpeedCurve; 
	public Vector2 InnerStreamSize; 
	public AnimationCurve InnerPressureSizeMultiplierCurve; 
	[HeaderAttribute] 
	public bool UseImpactSplashEffect; 
	public GameObjectRef ImpactSplashEffect; 
	public float ImpactSplashEffectInterval; 
	public float FillSpeed; 
	private BasePlayer player; 
	private float maxRange; 
	private float currentRange; 
	private float pressure; 
	private float nextSplashTime; 
	private float targetWaterLevel; 
	[HeaderAttribute] 
	public bool firstPersonSounds; 
	public SoundDefinition shootStartSoundDef; 
	public SoundDefinition shootLoopSoundDef; 
	public SoundDefinition shootLowPressureLoopSoundDef; 
	private Sound shootLoopSound; 
	private Sound shootLowPressureLoopSound; 
	private SoundModulation.Modulator shootLoopGainMod; 
	private SoundModulation.Modulator shootLowPressureGainMod; 
	public SoundDefinition impactStartSoundDef; 
	public SoundDefinition impactLoopSoundDef; 
	private Sound impactLoopSound; 
	private bool impactStartPlayed; 
	private bool lastImpactHit; 
	private Vector3 lastImpactPosition; 
	private bool emitting; 


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

