public class ResourceEntity : BaseEntity // TypeDefIndex: 9675
{
	[FormerlySerializedAsAttribute] 
	public float startHealth; 
	[FormerlySerializedAsAttribute] 
	public ProtectionProperties baseProtection; 
	protected float health; 
	protected bool isKilled; 


public override void Load(BaseNetworkable.LoadInfo info) { }

public override void InitShared() { }

public override void OnAttacked(HitInfo info) { }

public override float BoundsPadding() { }

public void .ctor() { }

}

