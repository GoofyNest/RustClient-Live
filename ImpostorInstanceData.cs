public class ImpostorInstanceData // TypeDefIndex: 12438
{
	[CompilerGeneratedAttribute]
	private Renderer <Renderer>k__BackingField;
	[CompilerGeneratedAttribute]
	private Mesh <Mesh>k__BackingField;
	[CompilerGeneratedAttribute]
	private Material <Material>k__BackingField;
	public ImpostorBatch Batch;
	public int BatchIndex;
	private int hash;
	private Vector4 positionAndScale;

	public Renderer Renderer { get; set; }
	public Mesh Mesh { get; set; }
	public Material Material { get; set; }


	[CompilerGeneratedAttribute]
	private void set_Renderer(Renderer value) { }

	[CompilerGeneratedAttribute]
	public Renderer get_Renderer() { }

	[CompilerGeneratedAttribute]
	private void set_Mesh(Mesh value) { }

	[CompilerGeneratedAttribute]
	public Mesh get_Mesh() { }

	[CompilerGeneratedAttribute]
	private void set_Material(Material value) { }

	[CompilerGeneratedAttribute]
	public Material get_Material() { }

	public void .ctor(Renderer renderer, Mesh mesh, Material material) { }

	public void .ctor(Vector3 position, Vector3 scale, Mesh mesh, Material material) { }

	private int GenerateHashCode() { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	public Vector4 PositionAndScale() { }

	public void Update() { }

}

