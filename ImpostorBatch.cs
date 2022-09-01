public class ImpostorBatch // TypeDefIndex: 10691
{
	[CompilerGeneratedAttribute] 
	private Mesh <Mesh>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Material <Material>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private ComputeBuffer <PositionBuffer>k__BackingField; 
	public NativeList<Vector4> Positions; 
	[CompilerGeneratedAttribute] 
	private ComputeBuffer <ArgsBuffer>k__BackingField; 
	private NativeList<uint> args; 
	[CompilerGeneratedAttribute] 
	private bool <IsDirty>k__BackingField; 
	private Queue<int> recycle; 

	public Mesh Mesh { get; set; }
	public Material Material { get; set; }
	public ComputeBuffer PositionBuffer { get; set; }
	public ComputeBuffer ArgsBuffer { get; set; }
	public bool IsDirty { get; set; }
	public int Count { get; }
	public bool Visible { get; }


	[CompilerGeneratedAttribute] 
	private void set_Mesh(Mesh value) { }

	[CompilerGeneratedAttribute] 
	public Mesh get_Mesh() { }

	[CompilerGeneratedAttribute] 
	private void set_Material(Material value) { }

	[CompilerGeneratedAttribute] 
	public Material get_Material() { }

	[CompilerGeneratedAttribute] 
	private void set_PositionBuffer(ComputeBuffer value) { }

	[CompilerGeneratedAttribute] 
	public ComputeBuffer get_PositionBuffer() { }

	[CompilerGeneratedAttribute] 
	private void set_ArgsBuffer(ComputeBuffer value) { }

	[CompilerGeneratedAttribute] 
	public ComputeBuffer get_ArgsBuffer() { }

	[CompilerGeneratedAttribute] 
	public bool get_IsDirty() { }

	[CompilerGeneratedAttribute] 
	public void set_IsDirty(bool value) { }

	public int get_Count() { }

	public bool get_Visible() { }

	private ComputeBuffer SafeRelease(ComputeBuffer buffer) { }

	public void Initialize(Mesh mesh, Material material) { }

	public void Release() { }

	public void AddInstance(ImpostorInstanceData data) { }

	public void RemoveInstance(ImpostorInstanceData data) { }

	public void UpdateBuffers() { }

	public void .ctor() { }

}

