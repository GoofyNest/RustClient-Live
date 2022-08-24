public struct VertexAttributeDescriptor : IEquatable<VertexAttributeDescriptor> // TypeDefIndex: 3823
{
	[DebuggerBrowsableAttribute] 
	[CompilerGeneratedAttribute] 
	private VertexAttribute <attribute>k__BackingField; 
	[DebuggerBrowsableAttribute] 
	[CompilerGeneratedAttribute] 
	private VertexAttributeFormat <format>k__BackingField; 
	[CompilerGeneratedAttribute] 
	[DebuggerBrowsableAttribute] 
	private int <dimension>k__BackingField; 
	[CompilerGeneratedAttribute] 
	[DebuggerBrowsableAttribute] 
	private int <stream>k__BackingField; 

	public VertexAttribute attribute { get; set; }
	public VertexAttributeFormat format { get; set; }
	public int dimension { get; set; }
	public int stream { get; set; }


	[CompilerGeneratedAttribute] 
	public VertexAttribute get_attribute() { }

	[CompilerGeneratedAttribute] 
	public void set_attribute(VertexAttribute value) { }

	[CompilerGeneratedAttribute] 
	public VertexAttributeFormat get_format() { }

	[CompilerGeneratedAttribute] 
	public void set_format(VertexAttributeFormat value) { }

	[CompilerGeneratedAttribute] 
	public int get_dimension() { }

	[CompilerGeneratedAttribute] 
	public void set_dimension(int value) { }

	[CompilerGeneratedAttribute] 
	public int get_stream() { }

	[CompilerGeneratedAttribute] 
	public void set_stream(int value) { }

	public void .ctor(VertexAttribute attribute = 0, VertexAttributeFormat format = 0, int dimension = 3, int stream = 0) { }

	public override string ToString() { }

	public override int GetHashCode() { }

	public override bool Equals(object other) { }

	public bool Equals(VertexAttributeDescriptor other) { }

}

