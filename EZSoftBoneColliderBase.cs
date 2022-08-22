public abstract class EZSoftBoneColliderBase : MonoBehaviour // TypeDefIndex: 7134
{	public static ListHashSet<EZSoftBoneColliderBase> EnabledColliders; // 0x2B0AC80


	protected virtual void OnEnable() { }

	protected virtual void OnDisable() { }

	public abstract void Collide(ref Vector3 position, float spacing);

	protected void .ctor() { }

	private static void .cctor() { }

}

