public abstract class EZSoftBoneColliderBase : MonoBehaviour // TypeDefIndex: 7178
{
	public static ListHashSet<EZSoftBoneColliderBase> EnabledColliders;


	protected virtual void OnEnable() { }

	protected virtual void OnDisable() { }

	public abstract void Collide(ref Vector3 position, float spacing);

	protected void .ctor() { }

	private static void .cctor() { }

}

