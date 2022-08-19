public class MeshRendererLookup // TypeDefIndex: 9166
{	// Fields
	public MeshRendererLookup.LookupGroup src; // 0x10
	public MeshRendererLookup.LookupGroup dst; // 0x18

	// Methods

	// RVA: 0x965330 Offset: 0x964730 VA: 0x180965330
	public void Apply() { }

	// RVA: 0x9653B0 Offset: 0x9647B0 VA: 0x1809653B0
	public void Clear() { }

	// RVA: 0x9652A0 Offset: 0x9646A0 VA: 0x1809652A0
	public void Add(MeshRendererInstance instance) { }

	// RVA: 0x965400 Offset: 0x964800 VA: 0x180965400
	public MeshRendererLookup.LookupEntry Get(int index) { }

	// RVA: 0x965460 Offset: 0x964860 VA: 0x180965460
	public void .ctor() { }

}

public class MeshRendererLookup.LookupGroup // TypeDefIndex: 9167
{	// Fields
	public List<MeshRendererLookup.LookupEntry> data; // 0x10

	// Methods

	// RVA: 0x9537A0 Offset: 0x952BA0 VA: 0x1809537A0
	public void Clear() { }

	// RVA: 0x9536C0 Offset: 0x952AC0 VA: 0x1809536C0
	public void Add(MeshRendererInstance instance) { }

	// RVA: 0x9537F0 Offset: 0x952BF0 VA: 0x1809537F0
	public MeshRendererLookup.LookupEntry Get(int index) { }

	// RVA: 0x953930 Offset: 0x952D30 VA: 0x180953930
	public void .ctor() { }

}

public struct MeshRendererLookup.LookupEntry // TypeDefIndex: 9168
{	// Fields
	public Renderer renderer; // 0x0

	// Methods

	// RVA: 0xFA7D0 Offset: 0xF9BD0 VA: 0x1800FA7D0
	public void .ctor(MeshRendererInstance instance) { }

}

