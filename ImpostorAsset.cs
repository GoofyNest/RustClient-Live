public class ImpostorAsset : ScriptableObject // TypeDefIndex: 10677
{	public ImpostorAsset.TextureEntry[] textures; // 0x18
	public Vector2 size; // 0x20
	public Vector2 pivot; // 0x28
	public Mesh mesh; // 0x30


	public Texture2D FindTexture(string name) { }

	public void .ctor() { }

}

public class ImpostorAsset.TextureEntry // TypeDefIndex: 10678
{	public string name; // 0x10
	public Texture2D texture; // 0x18


	public void .ctor(string name, Texture2D texture) { }

}

