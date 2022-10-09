public static class RaycastHitEx // TypeDefIndex: 13088
{

	[ExtensionAttribute] 
	public static Transform GetTransform(RaycastHit hit) { }

	[ExtensionAttribute] 
	public static Rigidbody GetRigidbody(RaycastHit hit) { }

	[ExtensionAttribute] 
	public static Collider GetCollider(RaycastHit hit) { }

	[ExtensionAttribute] 
	public static BaseEntity GetEntity(RaycastHit hit) { }

	[ExtensionAttribute] 
	public static bool IsOnLayer(RaycastHit hit, Layer rustLayer) { }

	[ExtensionAttribute] 
	public static bool IsOnLayer(RaycastHit hit, int layer) { }

}

