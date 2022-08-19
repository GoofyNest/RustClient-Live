public abstract class EZSoftBoneColliderBase : MonoBehaviour // TypeDefIndex: 7134
{	// Fields
	public static ListHashSet<EZSoftBoneColliderBase> EnabledColliders; // 0x2B0AC80

	// Methods

	// RVA: 0x2289ED0 Offset: 0x22892D0 VA: 0x182289ED0 Slot: 4
	protected virtual void OnEnable() { }

	// RVA: 0x2289E50 Offset: 0x2289250 VA: 0x182289E50 Slot: 5
	protected virtual void OnDisable() { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void Collide(ref Vector3 position, float spacing);

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	protected void .ctor() { }

	// RVA: 0x2289FA0 Offset: 0x22893A0 VA: 0x182289FA0
	private static void .cctor() { }

}

