public struct IntPtr : ISerializable // TypeDefIndex: 369
{
	private void* m_value; 
	public static readonly IntPtr Zero; 

	public static int Size { get; }


	[ReliabilityContractAttribute] 
	public void .ctor(int value) { }

	[ReliabilityContractAttribute] 
	public void .ctor(long value) { }

	[ReliabilityContractAttribute] 
	[CLSCompliantAttribute] 
	public void .ctor(void* value) { }

	private void .ctor(SerializationInfo info, StreamingContext context) { }

	[ReliabilityContractAttribute] 
	public static int get_Size() { }

	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	[ReliabilityContractAttribute] 
	public long ToInt64() { }

	[CLSCompliantAttribute] 
	[ReliabilityContractAttribute] 
	public void* ToPointer() { }

	public override string ToString() { }

	public string ToString(string format) { }

	[ReliabilityContractAttribute] 
	public static bool op_Equality(IntPtr value1, IntPtr value2) { }

	[ReliabilityContractAttribute] 
	public static bool op_Inequality(IntPtr value1, IntPtr value2) { }

	[ReliabilityContractAttribute] 
	public static IntPtr op_Explicit(int value) { }

	[ReliabilityContractAttribute] 
	public static IntPtr op_Explicit(long value) { }

	[CLSCompliantAttribute] 
	[ReliabilityContractAttribute] 
	public static IntPtr op_Explicit(void* value) { }

	public static int op_Explicit(IntPtr value) { }

	public static long op_Explicit(IntPtr value) { }

	[CLSCompliantAttribute] 
	public static void* op_Explicit(IntPtr value) { }

	[ReliabilityContractAttribute] 
	public static IntPtr Add(IntPtr pointer, int offset) { }

	[ReliabilityContractAttribute] 
	internal bool IsNull() { }

}

