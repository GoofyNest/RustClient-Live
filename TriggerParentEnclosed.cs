public class TriggerParentEnclosed : TriggerParent // TypeDefIndex: 10037
{
	public float Padding; 
	[TooltipAttribute] 
	public TriggerParentEnclosed.TriggerMode intersectionMode; 
	public bool CheckBoundsOnUnparent; 


	public void .ctor() { }

}

public enum TriggerParentEnclosed.TriggerMode // TypeDefIndex: 10038
{
	public int value__; 
	public const TriggerParentEnclosed.TriggerMode TriggerPoint = 0;
	public const TriggerParentEnclosed.TriggerMode PivotPoint = 1;

}

