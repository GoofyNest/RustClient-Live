public class ColliderInfo : MonoBehaviour // TypeDefIndex: 9836
{	public const ColliderInfo.Flags FlagsNone = 0;
	public const ColliderInfo.Flags FlagsEverything = -1;
	public const ColliderInfo.Flags FlagsDefault = 15;
	[InspectorFlagsAttribute] // RVA: 0x70A20 Offset: 0x6FE20 VA: 0x180070A20
	public ColliderInfo.Flags flags; // 0x18


	public bool HasFlag(ColliderInfo.Flags f) { }

	public void SetFlag(ColliderInfo.Flags f, bool b) { }

	public bool Filter(HitTest info) { }

	public void .ctor() { }

}

public enum ColliderInfo.Flags // TypeDefIndex: 9837
{	public int value__; // 0x0
	public const ColliderInfo.Flags Usable = 1;
	public const ColliderInfo.Flags Shootable = 2;
	public const ColliderInfo.Flags Melee = 4;
	public const ColliderInfo.Flags Opaque = 8;
	public const ColliderInfo.Flags Airflow = 16;

}

