public class MeshRendererLookup // TypeDefIndex: 9166
{	public MeshRendererLookup.LookupGroup src; // 0x10
	public MeshRendererLookup.LookupGroup dst; // 0x18


	public void Apply() { }

	public void Clear() { }

	public void Add(MeshRendererInstance instance) { }

	public MeshRendererLookup.LookupEntry Get(int index) { }

	public void .ctor() { }

}

public class MeshRendererLookup.LookupGroup // TypeDefIndex: 9167
{	public List<MeshRendererLookup.LookupEntry> data; // 0x10


	public void Clear() { }

	public void Add(MeshRendererInstance instance) { }

	public MeshRendererLookup.LookupEntry Get(int index) { }

	public void .ctor() { }

}

public struct MeshRendererLookup.LookupEntry // TypeDefIndex: 9168
{	public Renderer renderer; // 0x0


	public void .ctor(MeshRendererInstance instance) { }

}

