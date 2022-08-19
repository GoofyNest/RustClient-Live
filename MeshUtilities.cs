internal static class MeshUtilities // TypeDefIndex: 11860
{	// Fields
	private static Dictionary<PrimitiveType, Mesh> s_Primitives; // 0x0
	private static Dictionary<Type, PrimitiveType> s_ColliderPrimitives; // 0x8

	// Methods

	// RVA: 0x1014200 Offset: 0x1013600 VA: 0x181014200
	private static void .cctor() { }

	// RVA: 0x1013D60 Offset: 0x1013160 VA: 0x181013D60
	internal static Mesh GetColliderMesh(Collider collider) { }

	// RVA: 0x1014090 Offset: 0x1013490 VA: 0x181014090
	internal static Mesh GetPrimitive(PrimitiveType primitiveType) { }

	// RVA: 0x1013CC0 Offset: 0x10130C0 VA: 0x181013CC0
	private static Mesh GetBuiltinMesh(PrimitiveType primitiveType) { }

}

