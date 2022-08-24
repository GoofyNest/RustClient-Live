public struct RuntimeFieldHandle : ISerializable // TypeDefIndex: 389
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

private static void SetValueInternal(FieldInfo fi, object obj, object value) { }

internal static void SetValue(RtFieldInfo field, object obj, object value, RuntimeType fieldType, FieldAttributes fieldAttr, RuntimeType declaringType, ref bool domainInitialized) { }

internal static void SetValueDirect(RtFieldInfo field, RuntimeType fieldType, void* pTypedRef, object value, RuntimeType contextType) { }

}

