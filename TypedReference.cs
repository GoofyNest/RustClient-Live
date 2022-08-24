public struct TypedReference // TypeDefIndex: 323
{
	private RuntimeTypeHandle type; 
	private IntPtr Value; 
	private IntPtr Type; 

internal bool IsNull { get; }


	[CLSCompliantAttribute] 
public static TypedReference MakeTypedReference(object target, FieldInfo[] flds) { }

private static TypedReference MakeTypedReferenceInternal(object target, FieldInfo[] fields) { }

public override int GetHashCode() { }

public override bool Equals(object o) { }

internal bool get_IsNull() { }

	[CLSCompliantAttribute] 
public static void SetTypedReference(TypedReference target, object value) { }

}

