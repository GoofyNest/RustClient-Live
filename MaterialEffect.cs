public class MaterialEffect : ScriptableObject // TypeDefIndex: 11921
{
	public GameObjectRef DefaultEffect; 
	public SoundDefinition DefaultSoundDefinition; 
	public MaterialEffect.Entry[] Entries; 
	public int waterFootstepIndex; 
	public MaterialEffect.Entry deepWaterEntry; 
	public float deepWaterDepth; 
	public MaterialEffect.Entry submergedWaterEntry; 
	public float submergedWaterDepth; 
	public bool ScaleVolumeWithSpeed; 
	public AnimationCurve SpeedGainCurve; 


	public MaterialEffect.Entry GetEntryFromMaterial(PhysicMaterial mat) { }

	public MaterialEffect.Entry GetWaterEntry() { }

	public void SpawnOnRay(Ray ray, int mask, float length = 0,5, Vector3 forward, float speed = 0) { }

	public void PlaySound(SoundDefinition definition, Vector3 position, float velocity = 0) { }

	public void .ctor() { }

}

public class MaterialEffect.Entry // TypeDefIndex: 11922
{
	public PhysicMaterial Material; 
	public GameObjectRef Effect; 
	public SoundDefinition SoundDefinition; 


	public void .ctor() { }

}

