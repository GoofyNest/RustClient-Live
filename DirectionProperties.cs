public class DirectionProperties : PrefabAttribute // TypeDefIndex: 10796
{
	private const float radius = 200;
	public Bounds bounds;
	public ProtectionProperties extraProtection;


	protected override Type GetIndexedType() { }

	public bool IsWeakspot(Transform tx, HitInfo info) { }

	private bool CheckWeakpointRoof(BaseEntity hitEntity) { }

	private bool IsWeakspotVisible(BaseEntity hitEntity, Vector3 playerEyes, Vector3 weakspotPos) { }

	public void .ctor() { }

}

