public class LocalPositionAnimation : MonoBehaviour, IClientComponent // TypeDefIndex: 9198
{	// Fields
	public Vector3 centerPosition; // 0x18
	public bool worldSpace; // 0x24
	public float scaleX; // 0x28
	public float timeScaleX; // 0x2C
	public AnimationCurve movementX; // 0x30
	public float scaleY; // 0x38
	public float timeScaleY; // 0x3C
	public AnimationCurve movementY; // 0x40
	public float scaleZ; // 0x48
	public float timeScaleZ; // 0x4C
	public AnimationCurve movementZ; // 0x50
	private const float maxDistSq = 10000;

	// Methods

	// RVA: 0x4FAC80 Offset: 0x4FA080 VA: 0x1804FAC80
	protected void Update() { }

	// RVA: 0x4FB070 Offset: 0x4FA470 VA: 0x1804FB070
	public void .ctor() { }

}

