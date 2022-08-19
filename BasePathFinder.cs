public class BasePathFinder // TypeDefIndex: 8966
{	// Fields
	private static Vector3[] preferedTopologySamples; // 0x0
	private static Vector3[] topologySamples; // 0x8
	private Vector3 chosenPosition; // 0x10
	private const float halfPI = 0,01745329;

	// Methods

	// RVA: 0xA30C90 Offset: 0xA30090 VA: 0x180A30C90 Slot: 4
	public virtual Vector3 GetRandomPatrolPoint() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 5
	public virtual AIMovePoint GetBestRoamPoint(Vector3 anchorPos, Vector3 currentPos, Vector3 currentDirection, float anchorClampDistance, float lookupMaxRange = 20) { }

	// RVA: 0xA30A30 Offset: 0xA2FE30 VA: 0x180A30A30
	public void DebugDraw() { }

	// RVA: 0xA30D00 Offset: 0xA30100 VA: 0x180A30D00 Slot: 6
	public virtual Vector3 GetRandomPositionAround(Vector3 position, float minDistFrom = 0, float maxDistFrom = 2) { }

	// RVA: 0xA30BA0 Offset: 0xA2FFA0 VA: 0x180A30BA0
	public static Vector3 GetPointOnCircle(Vector3 center, float radius, float degrees) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xA30F00 Offset: 0xA30300 VA: 0x180A30F00
	private static void .cctor() { }

}

