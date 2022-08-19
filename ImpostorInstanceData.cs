public class ImpostorInstanceData // TypeDefIndex: 10679
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Renderer <Renderer>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Mesh <Mesh>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Material <Material>k__BackingField; // 0x20
	public ImpostorBatch Batch; // 0x28
	public int BatchIndex; // 0x30
	private int hash; // 0x34
	private Vector4 positionAndScale; // 0x38

	// Properties
	public Renderer Renderer { get; set; }
	public Mesh Mesh { get; set; }
	public Material Material { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B94C0 Offset: 0x4B88C0 VA: 0x1804B94C0
	private void set_Renderer(Renderer value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public Renderer get_Renderer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4D0180 Offset: 0x4CF580 VA: 0x1804D0180
	private void set_Mesh(Mesh value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public Mesh get_Mesh() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497E30 Offset: 0x497230 VA: 0x180497E30
	private void set_Material(Material value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	public Material get_Material() { }

	// RVA: 0x80E010 Offset: 0x80D410 VA: 0x18080E010
	public void .ctor(Renderer renderer, Mesh mesh, Material material) { }

	// RVA: 0x80DEC0 Offset: 0x80D2C0 VA: 0x18080DEC0
	public void .ctor(Vector3 position, Vector3 scale, Mesh mesh, Material material) { }

	// RVA: 0x80DC80 Offset: 0x80D080 VA: 0x18080DC80
	private int GenerateHashCode() { }

	// RVA: 0x80DB60 Offset: 0x80CF60 VA: 0x18080DB60 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x5FC780 Offset: 0x5FBB80 VA: 0x1805FC780 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x80DCE0 Offset: 0x80D0E0 VA: 0x18080DCE0
	public Vector4 PositionAndScale() { }

	// RVA: 0x80DE20 Offset: 0x80D220 VA: 0x18080DE20
	public void Update() { }

}

