public class SkinSet : ScriptableObject // TypeDefIndex: 10758
{	// Fields
	public string Label; // 0x18
	public Gradient SkinColour; // 0x20
	public HairSetCollection HairCollection; // 0x28
	[HeaderAttribute] // RVA: 0x7A240 Offset: 0x79640 VA: 0x18007A240
	public GameObjectRef Head; // 0x30
	public GameObjectRef Torso; // 0x38
	public GameObjectRef Legs; // 0x40
	public GameObjectRef Feet; // 0x48
	public GameObjectRef Hands; // 0x50
	[HeaderAttribute] // RVA: 0x7A450 Offset: 0x79850 VA: 0x18007A450
	public GameObjectRef CensoredTorso; // 0x58
	public GameObjectRef CensoredLegs; // 0x60
	[HeaderAttribute] // RVA: 0x7A5D0 Offset: 0x799D0 VA: 0x18007A5D0
	public Material HeadMaterial; // 0x68
	public Material BodyMaterial; // 0x70
	public Material EyeMaterial; // 0x78

	// Methods

	// RVA: 0x5B7F50 Offset: 0x5B7350 VA: 0x1805B7F50
	internal Color GetSkinColor(float skinNumber) { }

	// RVA: 0x4C0870 Offset: 0x4BFC70 VA: 0x1804C0870
	public void .ctor() { }

}

