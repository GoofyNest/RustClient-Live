public struct RuntimeTypeHandle : ISerializable // TypeDefIndex: 391
{
	private IntPtr value; 

public IntPtr Value { get; }


internal void .ctor(IntPtr val) { }

internal void .ctor(RuntimeType type) { }

private void .ctor(SerializationInfo info, StreamingContext context) { }

public IntPtr get_Value() { }

public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[ReliabilityContractAttribute] 
public override bool Equals(object obj) { }

public override int GetHashCode() { }

internal static TypeAttributes GetAttributes(RuntimeType type) { }

private static int GetMetadataToken(RuntimeType type) { }

internal static int GetToken(RuntimeType type) { }

private static Type GetGenericTypeDefinition_impl(RuntimeType type) { }

internal static Type GetGenericTypeDefinition(RuntimeType type) { }

internal static bool HasElementType(RuntimeType type) { }

internal static bool HasInstantiation(RuntimeType type) { }

internal static bool IsArray(RuntimeType type) { }

internal static bool IsByRef(RuntimeType type) { }

internal static bool IsComObject(RuntimeType type) { }

internal static bool IsInstanceOfType(RuntimeType type, object o) { }

internal static bool IsPointer(RuntimeType type) { }

internal static bool IsPrimitive(RuntimeType type) { }

internal static bool HasReferences(RuntimeType type) { }

internal static bool IsComObject(RuntimeType type, bool isGenericCOM) { }

internal static bool IsContextful(RuntimeType type) { }

internal static bool IsEquivalentTo(RuntimeType rtType1, RuntimeType rtType2) { }

internal static bool IsSzArray(RuntimeType type) { }

internal static bool IsInterface(RuntimeType type) { }

internal static int GetArrayRank(RuntimeType type) { }

internal static RuntimeAssembly GetAssembly(RuntimeType type) { }

internal static RuntimeType GetElementType(RuntimeType type) { }

internal static RuntimeModule GetModule(RuntimeType type) { }

internal static bool IsGenericVariable(RuntimeType type) { }

internal static RuntimeType GetBaseType(RuntimeType type) { }

internal static bool CanCastTo(RuntimeType type, RuntimeType target) { }

private static bool type_is_assignable_from(Type a, Type b) { }

internal static bool IsGenericTypeDefinition(RuntimeType type) { }

internal static IntPtr GetGenericParameterInfo(RuntimeType type) { }

}

