public struct RuntimeMethodHandle : ISerializable // TypeDefIndex: 390
{
	private IntPtr value; 

	public IntPtr Value { get; }


	internal void .ctor(IntPtr v) { }

	private void .ctor(SerializationInfo info, StreamingContext context) { }

	public IntPtr get_Value() { }

	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[ReliabilityContractAttribute] 
	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	internal static string ConstructInstantiation(RuntimeMethodInfo method, TypeNameFormatFlags format) { }

	internal bool IsNullHandle() { }

}

