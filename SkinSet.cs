public class SkinSet : ScriptableObject // TypeDefIndex: 12475
{
	public string Label; 
	public Gradient SkinColour; 
	public HairSetCollection HairCollection; 
	[HeaderAttribute] 
	public GameObjectRef Head; 
	public GameObjectRef Torso; 
	public GameObjectRef Legs; 
	public GameObjectRef Feet; 
	public GameObjectRef Hands; 
	[HeaderAttribute] 
	public GameObjectRef CensoredTorso; 
	public GameObjectRef CensoredLegs; 
	[HeaderAttribute] 
	public Material HeadMaterial; 
	public Material BodyMaterial; 
	public Material EyeMaterial; 


	internal Color GetSkinColor(float skinNumber) { }

	public void .ctor() { }

}

