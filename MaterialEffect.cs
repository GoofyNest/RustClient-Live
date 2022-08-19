public class MaterialEffect : ScriptableObject // TypeDefIndex: 10195
{	// Fields
	public GameObjectRef DefaultEffect; // 0x18
	public SoundDefinition DefaultSoundDefinition; // 0x20
	public MaterialEffect.Entry[] Entries; // 0x28
	public int waterFootstepIndex; // 0x30
	public MaterialEffect.Entry deepWaterEntry; // 0x38
	public float deepWaterDepth; // 0x40
	public MaterialEffect.Entry submergedWaterEntry; // 0x48
	public float submergedWaterDepth; // 0x50
	public bool ScaleVolumeWithSpeed; // 0x54
	public AnimationCurve SpeedGainCurve; // 0x58

	// Methods

	// RVA: 0x9565D0 Offset: 0x9559D0 VA: 0x1809565D0
	public MaterialEffect.Entry GetEntryFromMaterial(PhysicMaterial mat) { }

	// RVA: 0x9566B0 Offset: 0x955AB0 VA: 0x1809566B0
	public MaterialEffect.Entry GetWaterEntry() { }

	// RVA: 0x956910 Offset: 0x955D10 VA: 0x180956910
	public void SpawnOnRay(Ray ray, int mask, float length = 0,5, Vector3 forward, float speed = 0) { }

	// RVA: 0x956800 Offset: 0x955C00 VA: 0x180956800
	public void PlaySound(SoundDefinition definition, Vector3 position, float velocity = 0) { }

	// RVA: 0x9570F0 Offset: 0x9564F0 VA: 0x1809570F0
	public void .ctor() { }

}

public class MaterialEffect.Entry // TypeDefIndex: 10196
{	// Fields
	public PhysicMaterial Material; // 0x10
	public GameObjectRef Effect; // 0x18
	public SoundDefinition SoundDefinition; // 0x20

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

