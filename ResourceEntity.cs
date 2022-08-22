public class ResourceEntity : BaseEntity // TypeDefIndex: 9675
{	[FormerlySerializedAsAttribute] // RVA: 0x83E00 Offset: 0x83200 VA: 0x180083E00
	public float startHealth; // 0x168
	[FormerlySerializedAsAttribute] // RVA: 0x83E60 Offset: 0x83260 VA: 0x180083E60
	public ProtectionProperties baseProtection; // 0x170
	protected float health; // 0x178
	protected bool isKilled; // 0x17C


	public override void Load(BaseNetworkable.LoadInfo info) { }

	public override void InitShared() { }

	public override void OnAttacked(HitInfo info) { }

	public override float BoundsPadding() { }

	public void .ctor() { }

}

