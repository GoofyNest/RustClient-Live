public class MaterialSound : ScriptableObject // TypeDefIndex: 10204
{
	public SoundDefinition DefaultSound; 
	public MaterialSound.Entry[] Entries; 


	public void .ctor() { }

}

public class MaterialSound.Entry // TypeDefIndex: 10205
{
	public PhysicMaterial Material; 
	public SoundDefinition Sound; 


	public void .ctor() { }

}

