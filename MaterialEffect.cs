public class MaterialEffect : ScriptableObject // TypeDefIndex: 10195
{	public GameObjectRef DefaultEffect; // 0x18
	public SoundDefinition DefaultSoundDefinition; // 0x20
	public MaterialEffect.Entry[] Entries; // 0x28
	public int waterFootstepIndex; // 0x30
	public MaterialEffect.Entry deepWaterEntry; // 0x38
	public float deepWaterDepth; // 0x40
	public MaterialEffect.Entry submergedWaterEntry; // 0x48
	public float submergedWaterDepth; // 0x50
	public bool ScaleVolumeWithSpeed; // 0x54
	public AnimationCurve SpeedGainCurve; // 0x58


	public MaterialEffect.Entry GetEntryFromMaterial(PhysicMaterial mat) { }

	public MaterialEffect.Entry GetWaterEntry() { }

	public void SpawnOnRay(Ray ray, int mask, float length = 0,5, Vector3 forward, float speed = 0) { }

	public void PlaySound(SoundDefinition definition, Vector3 position, float velocity = 0) { }

	public void .ctor() { }

}

public class MaterialEffect.Entry // TypeDefIndex: 10196
{	public PhysicMaterial Material; // 0x10
	public GameObjectRef Effect; // 0x18
	public SoundDefinition SoundDefinition; // 0x20


	public void .ctor() { }

}

