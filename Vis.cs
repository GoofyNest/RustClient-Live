public static class Vis // TypeDefIndex: 10053
{	// Fields
	private static int colCount; // 0x0
	private static Collider[] colBuffer; // 0x8

	// Methods

	// RVA: 0x7DD660 Offset: 0x7DCA60 VA: 0x1807DD660
	private static void Buffer(Vector3 position, float radius, int layerMask = -1, QueryTriggerInteraction triggerInteraction = 2) { }

	// RVA: 0x7DD0C0 Offset: 0x7DC4C0 VA: 0x1807DD0C0
	public static bool AnyColliders(Vector3 position, float radius, int layerMask = -1, QueryTriggerInteraction triggerInteraction = 1) { }

	// RVA: -1 Offset: -1
	public static void Colliders<T>(Vector3 position, float radius, List<T> list, int layerMask = -1, QueryTriggerInteraction triggerInteraction = 2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5F2910 Offset: 0x5F1D10 VA: 0x1805F2910
	|-Vis.Colliders<object>
	|-Vis.Colliders<Collider>
	*/

	// RVA: -1 Offset: -1
	public static void Components<T>(Vector3 position, float radius, List<T> list, int layerMask = -1, QueryTriggerInteraction triggerInteraction = 2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5F2D50 Offset: 0x5F2150 VA: 0x1805F2D50
	|-Vis.Components<object>
	|-Vis.Components<Rigidbody>
	|-Vis.Components<WaterVolume>
	*/

	// RVA: -1 Offset: -1
	public static void Entities<T>(Vector3 position, float radius, List<T> list, int layerMask = -1, QueryTriggerInteraction triggerInteraction = 2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5F3460 Offset: 0x5F2860 VA: 0x1805F3460
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

	// RVA: -1 Offset: -1
	public static void EntityComponents<T>(Vector3 position, float radius, List<T> list, int layerMask = -1, QueryTriggerInteraction triggerInteraction = 2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5F3690 Offset: 0x5F2A90 VA: 0x1805F3690
	|-Vis.EntityComponents<object>
	*/

	// RVA: 0x7DD3C0 Offset: 0x7DC7C0 VA: 0x1807DD3C0
	private static void Buffer(OBB bounds, int layerMask = -1, QueryTriggerInteraction triggerInteraction = 2) { }

	// RVA: -1 Offset: -1
	public static void Colliders<T>(OBB bounds, List<T> list, int layerMask = -1, QueryTriggerInteraction triggerInteraction = 2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5F26E0 Offset: 0x5F1AE0 VA: 0x1805F26E0
	|-Vis.Colliders<object>
	*/

	// RVA: -1 Offset: -1
	public static void Components<T>(OBB bounds, List<T> list, int layerMask = -1, QueryTriggerInteraction triggerInteraction = 2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5F2B40 Offset: 0x5F1F40 VA: 0x1805F2B40
	|-Vis.Components<object>
	*/

	// RVA: -1 Offset: -1
	public static void Entities<T>(OBB bounds, List<T> list, int layerMask = -1, QueryTriggerInteraction triggerInteraction = 2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5F2F40 Offset: 0x5F2340 VA: 0x1805F2F40
	|-Vis.Entities<object>
	*/

	// RVA: -1 Offset: -1
	public static void EntityComponents<T>(OBB bounds, List<T> list, int layerMask = -1, QueryTriggerInteraction triggerInteraction = 2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5F38D0 Offset: 0x5F2CD0 VA: 0x1805F38D0
	|-Vis.EntityComponents<object>
	*/

	// RVA: 0x7DD170 Offset: 0x7DC570 VA: 0x1807DD170
	private static void Buffer(Vector3 startPosition, Vector3 endPosition, float radius, int layerMask = -1, QueryTriggerInteraction triggerInteraction = 2) { }

	// RVA: -1 Offset: -1
	public static void Entities<T>(Vector3 startPosition, Vector3 endPosition, float radius, List<T> list, int layerMask = -1, QueryTriggerInteraction triggerInteraction = 2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5F31C0 Offset: 0x5F25C0 VA: 0x1805F31C0
	|-Vis.Entities<object>
	*/

	// RVA: 0x7DD8B0 Offset: 0x7DCCB0 VA: 0x1807DD8B0
	private static void .cctor() { }

}

public class Vis : ConsoleSystem // TypeDefIndex: 11969
{	// Fields
	[ClientVar] // RVA: 0xC1AF0 Offset: 0xC0EF0 VA: 0x1800C1AF0
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

	// Methods

	// RVA: 0x36C210 Offset: 0x36B610 VA: 0x18036C210
	public void .ctor() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private static void .cctor() { }

}

