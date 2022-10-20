public class FloatConditions // TypeDefIndex: 13117
{
	public FloatConditions.Condition[] conditions; 


	public bool AllTrue(float val) { }

	public void .ctor() { }

}

public struct FloatConditions.Condition // TypeDefIndex: 13118
{
	public FloatConditions.Condition.Types type; 
	public float value; 


	public bool Test(float val) { }

}

public enum FloatConditions.Condition.Types // TypeDefIndex: 13119
{
	public int value__; 
	public const FloatConditions.Condition.Types Equal = 0;
	public const FloatConditions.Condition.Types NotEqual = 1;
	public const FloatConditions.Condition.Types Higher = 2;
	public const FloatConditions.Condition.Types Lower = 3;

}

