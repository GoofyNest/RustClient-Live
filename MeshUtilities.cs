internal static class MeshUtilities // TypeDefIndex: 11860
{	private static Dictionary<PrimitiveType, Mesh> s_Primitives; // 0x0
	private static Dictionary<Type, PrimitiveType> s_ColliderPrimitives; // 0x8


	private static void .cctor() { }

	internal static Mesh GetColliderMesh(Collider collider) { }

	internal static Mesh GetPrimitive(PrimitiveType primitiveType) { }

	private static Mesh GetBuiltinMesh(PrimitiveType primitiveType) { }

}

