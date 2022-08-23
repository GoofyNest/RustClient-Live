public static class Vis // TypeDefIndex: 10053
{	private static int colCount; // 0x0
	private static Collider[] colBuffer; // 0x8


	private static void Buffer(Vector3 position, float radius, int layerMask = -1, QueryTriggerInteraction triggerInteraction = 2) { }

	public static bool AnyColliders(Vector3 position, float radius, int layerMask = -1, QueryTriggerInteraction triggerInteraction = 1) { }

	public static void Colliders<T>(Vector3 position, float radius, List<T> list, int layerMask = -1, QueryTriggerInteraction triggerInteraction = 2) { }
	/* GenericInstMethod :
	|
	|-Vis.Colliders<object>
	|-Vis.Colliders<Collider>
	*/

	public static void Components<T>(Vector3 position, float radius, List<T> list, int layerMask = -1, QueryTriggerInteraction triggerInteraction = 2) { }
	/* GenericInstMethod :
	|
	|-Vis.Components<object>
	|-Vis.Components<Rigidbody>
	|-Vis.Components<WaterVolume>
	*/

	public static void Entities<T>(Vector3 position, float radius, List<T> list, int layerMask = -1, QueryTriggerInteraction triggerInteraction = 2) { }
	/* GenericInstMethod :
	|
	|-Vis.Entities<BaseEntity>
	|-Vis.Entities<BasePlayer>
	|-Vis.Entities<BaseVehicle>
	|-Vis.Entities<BuildingBlock>
	|-Vis.Entities<CollectableEasterEgg>
	|-Vis.Entities<DroppedItem>
	|-Vis.Entities<GraveyardFence>
	|-Vis.Entities<IOEntity>
	|-Vis.Entities<SleepingBag>
	|-Vis.Entities<object>
	*/

	public static void EntityComponents<T>(Vector3 position, float radius, List<T> list, int layerMask = -1, QueryTriggerInteraction triggerInteraction = 2) { }
	/* GenericInstMethod :
	|
	|-Vis.EntityComponents<object>
	*/

	private static void Buffer(OBB bounds, int layerMask = -1, QueryTriggerInteraction triggerInteraction = 2) { }

	public static void Colliders<T>(OBB bounds, List<T> list, int layerMask = -1, QueryTriggerInteraction triggerInteraction = 2) { }
	/* GenericInstMethod :
	|
	|-Vis.Colliders<object>
	*/

	public static void Components<T>(OBB bounds, List<T> list, int layerMask = -1, QueryTriggerInteraction triggerInteraction = 2) { }
	/* GenericInstMethod :
	|
	|-Vis.Components<object>
	*/

	public static void Entities<T>(OBB bounds, List<T> list, int layerMask = -1, QueryTriggerInteraction triggerInteraction = 2) { }
	/* GenericInstMethod :
	|
	|-Vis.Entities<object>
	*/

	public static void EntityComponents<T>(OBB bounds, List<T> list, int layerMask = -1, QueryTriggerInteraction triggerInteraction = 2) { }
	/* GenericInstMethod :
	|
	|-Vis.EntityComponents<object>
	*/

	private static void Buffer(Vector3 startPosition, Vector3 endPosition, float radius, int layerMask = -1, QueryTriggerInteraction triggerInteraction = 2) { }

	public static void Entities<T>(Vector3 startPosition, Vector3 endPosition, float radius, List<T> list, int layerMask = -1, QueryTriggerInteraction triggerInteraction = 2) { }
	/* GenericInstMethod :
	|
	|-Vis.Entities<object>
	*/

	private static void .cctor() { }

}

public class Vis : ConsoleSystem // TypeDefIndex: 11969
{	[ClientVar] // RVA: 0xC1AF0 Offset: 0xC0EF0 VA: 0x1800C1AF0
	[HelpAttribute] // RVA: 0xC1AF0 Offset: 0xC0EF0 VA: 0x1800C1AF0
	public static bool lerp; // 0x0
	[ServerVar] // RVA: 0xC1CA0 Offset: 0xC10A0 VA: 0x1800C1CA0
	[HelpAttribute] // RVA: 0xC1CA0 Offset: 0xC10A0 VA: 0x1800C1CA0
	public static bool damage; // 0x1
	[ServerVar] // RVA: 0xC1D80 Offset: 0xC1180 VA: 0x1800C1D80
	[ClientVar] // RVA: 0xC1D80 Offset: 0xC1180 VA: 0x1800C1D80
	[HelpAttribute] // RVA: 0xC1D80 Offset: 0xC1180 VA: 0x1800C1D80
	public static bool attack; // 0x2
	[ServerVar] // RVA: 0xC1EE0 Offset: 0xC12E0 VA: 0x1800C1EE0
	[ClientVar] // RVA: 0xC1EE0 Offset: 0xC12E0 VA: 0x1800C1EE0
	[HelpAttribute] // RVA: 0xC1EE0 Offset: 0xC12E0 VA: 0x1800C1EE0
	public static bool protection; // 0x3
	[ServerVar] // RVA: 0xC33A0 Offset: 0xC27A0 VA: 0x1800C33A0
	[HelpAttribute] // RVA: 0xC33A0 Offset: 0xC27A0 VA: 0x1800C33A0
	public static bool weakspots; // 0x4
	[ServerVar] // RVA: 0xC3470 Offset: 0xC2870 VA: 0x1800C3470
	[HelpAttribute] // RVA: 0xC3470 Offset: 0xC2870 VA: 0x1800C3470
	public static bool triggers; // 0x5
	[ServerVar] // RVA: 0xC3620 Offset: 0xC2A20 VA: 0x1800C3620
	[HelpAttribute] // RVA: 0xC3620 Offset: 0xC2A20 VA: 0x1800C3620
	public static bool hitboxes; // 0x6
	[ServerVar] // RVA: 0xC37D0 Offset: 0xC2BD0 VA: 0x1800C37D0
	[HelpAttribute] // RVA: 0xC37D0 Offset: 0xC2BD0 VA: 0x1800C37D0
	public static bool lineofsight; // 0x7
	[ServerVar] // RVA: 0xC3930 Offset: 0xC2D30 VA: 0x1800C3930
	[HelpAttribute] // RVA: 0xC3930 Offset: 0xC2D30 VA: 0x1800C3930
	public static bool sense; // 0x8


	public void .ctor() { }

	private static void .cctor() { }

}

