internal static class MeshUtilities // TypeDefIndex: 11888
{
	private static Dictionary<PrimitiveType, Mesh> s_Primitives; 
	private static Dictionary<Type, PrimitiveType> s_ColliderPrimitives; 


	private static void .cctor() { }

	internal static Mesh GetColliderMesh(Collider collider) { }

	internal static Mesh GetPrimitive(PrimitiveType primitiveType) { }

	private static Mesh GetBuiltinMesh(PrimitiveType primitiveType) { }

}

