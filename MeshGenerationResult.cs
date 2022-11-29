public struct MeshGenerationResult : IEquatable<MeshGenerationResult> // TypeDefIndex: 4164
{
	[CompilerGeneratedAttribute] 
	[DebuggerBrowsableAttribute] 
	private readonly MeshId <MeshId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	[DebuggerBrowsableAttribute] 
	private readonly Mesh <Mesh>k__BackingField; 
	[CompilerGeneratedAttribute] 
	[DebuggerBrowsableAttribute] 
	private readonly MeshCollider <MeshCollider>k__BackingField; 
	[CompilerGeneratedAttribute] 
	[DebuggerBrowsableAttribute] 
	private readonly MeshGenerationStatus <Status>k__BackingField; 
	[CompilerGeneratedAttribute] 
	[DebuggerBrowsableAttribute] 
	private readonly MeshVertexAttributes <Attributes>k__BackingField; 

	public MeshId MeshId { get; }
	public Mesh Mesh { get; }
	public MeshCollider MeshCollider { get; }
	public MeshGenerationStatus Status { get; }
	public MeshVertexAttributes Attributes { get; }


	[CompilerGeneratedAttribute] 
	public MeshId get_MeshId() { }

	[CompilerGeneratedAttribute] 
	public Mesh get_Mesh() { }

	[CompilerGeneratedAttribute] 
	public MeshCollider get_MeshCollider() { }

	[CompilerGeneratedAttribute] 
	public MeshGenerationStatus get_Status() { }

	[CompilerGeneratedAttribute] 
	public MeshVertexAttributes get_Attributes() { }

	public override bool Equals(object obj) { }

	public bool Equals(MeshGenerationResult other) { }

	public override int GetHashCode() { }

}

