public class ResourceEntity : BaseEntity // TypeDefIndex: 9675
{	// Fields
	[FormerlySerializedAsAttribute] // RVA: 0x83E00 Offset: 0x83200 VA: 0x180083E00
	public float startHealth; // 0x168
	[FormerlySerializedAsAttribute] // RVA: 0x83E60 Offset: 0x83260 VA: 0x180083E60
	public ProtectionProperties baseProtection; // 0x170
	protected float health; // 0x178
	protected bool isKilled; // 0x17C

	// Methods

	// RVA: 0x4C0760 Offset: 0x4BFB60 VA: 0x1804C0760 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x4C06A0 Offset: 0x4BFAA0 VA: 0x1804C06A0 Slot: 28
	public override void InitShared() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 116
	public override void OnAttacked(HitInfo info) { }

	// RVA: 0x4C0690 Offset: 0x4BFA90 VA: 0x1804C0690 Slot: 113
	public override float BoundsPadding() { }

	// RVA: 0x4C07B0 Offset: 0x4BFBB0 VA: 0x1804C07B0
	public void .ctor() { }

}

