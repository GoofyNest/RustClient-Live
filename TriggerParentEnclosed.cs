public class TriggerParentEnclosed : TriggerParent // TypeDefIndex: 10037
{	// Fields
	public float Padding; // 0x48
	[TooltipAttribute] // RVA: 0xB0560 Offset: 0xAF960 VA: 0x1800B0560
	public TriggerParentEnclosed.TriggerMode intersectionMode; // 0x4C
	public bool CheckBoundsOnUnparent; // 0x50

	// Methods

	// RVA: 0xA00E70 Offset: 0xA00270 VA: 0x180A00E70
	public void .ctor() { }

}

public enum TriggerParentEnclosed.TriggerMode // TypeDefIndex: 10038
{	// Fields
	public int value__; // 0x0
	public const TriggerParentEnclosed.TriggerMode TriggerPoint = 0;
	public const TriggerParentEnclosed.TriggerMode PivotPoint = 1;

}

