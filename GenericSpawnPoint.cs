public class GenericSpawnPoint : BaseSpawnPoint // TypeDefIndex: 9998
{	// Fields
	public bool dropToGround; // 0x18
	public bool randomRot; // 0x19
	[RangeAttribute] // RVA: 0xACCB0 Offset: 0xAC0B0 VA: 0x1800ACCB0
	public float randomRotSnapDegrees; // 0x1C
	public GameObjectRef spawnEffect; // 0x20
	public UnityEvent OnObjectSpawnedEvent; // 0x28
	public UnityEvent OnObjectRetiredEvent; // 0x30

	// Methods

	// RVA: 0xC77F00 Offset: 0xC77300 VA: 0x180C77F00
	public Quaternion GetRandomRotation() { }

	// RVA: 0xC78020 Offset: 0xC77420 VA: 0x180C78020
	public void .ctor() { }

}

