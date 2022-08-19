public class ImpostorAsset : ScriptableObject // TypeDefIndex: 10677
{	// Fields
	public ImpostorAsset.TextureEntry[] textures; // 0x18
	public Vector2 size; // 0x20
	public Vector2 pivot; // 0x28
	public Mesh mesh; // 0x30

	// Methods

	// RVA: 0x80D310 Offset: 0x80C710 VA: 0x18080D310
	public Texture2D FindTexture(string name) { }

	// RVA: 0x4C0870 Offset: 0x4BFC70 VA: 0x1804C0870
	public void .ctor() { }

}

public class ImpostorAsset.TextureEntry // TypeDefIndex: 10678
{	// Fields
	public string name; // 0x10
	public Texture2D texture; // 0x18

	// Methods

	// RVA: 0x53C500 Offset: 0x53B900 VA: 0x18053C500
	public void .ctor(string name, Texture2D texture) { }

}

