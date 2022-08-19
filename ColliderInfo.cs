public class ColliderInfo : MonoBehaviour // TypeDefIndex: 9836
{	// Fields
	public const ColliderInfo.Flags FlagsNone = 0;
	public const ColliderInfo.Flags FlagsEverything = -1;
	public const ColliderInfo.Flags FlagsDefault = 15;
	[InspectorFlagsAttribute] // RVA: 0x70A20 Offset: 0x6FE20 VA: 0x180070A20
	public ColliderInfo.Flags flags; // 0x18

	// Methods

	// RVA: 0x596110 Offset: 0x595510 VA: 0x180596110
	public bool HasFlag(ColliderInfo.Flags f) { }

	// RVA: 0x596120 Offset: 0x595520 VA: 0x180596120
	public void SetFlag(ColliderInfo.Flags f, bool b) { }

	// RVA: 0x5960C0 Offset: 0x5954C0 VA: 0x1805960C0
	public bool Filter(HitTest info) { }

	// RVA: 0x596140 Offset: 0x595540 VA: 0x180596140
	public void .ctor() { }

}

public enum ColliderInfo.Flags // TypeDefIndex: 9837
{	// Fields
	public int value__; // 0x0
	public const ColliderInfo.Flags Usable = 1;
	public const ColliderInfo.Flags Shootable = 2;
	public const ColliderInfo.Flags Melee = 4;
	public const ColliderInfo.Flags Opaque = 8;
	public const ColliderInfo.Flags Airflow = 16;

}

