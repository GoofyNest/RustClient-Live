public class FloatConditions // TypeDefIndex: 11365
{	// Fields
	public FloatConditions.Condition[] conditions; // 0x10

	// Methods

	// RVA: 0x790EA0 Offset: 0x7902A0 VA: 0x180790EA0
	public bool AllTrue(float val) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public struct FloatConditions.Condition // TypeDefIndex: 11366
{	// Fields
	public FloatConditions.Condition.Types type; // 0x0
	public float value; // 0x4

	// Methods

	// RVA: 0xF51E0 Offset: 0xF45E0 VA: 0x1800F51E0
	public bool Test(float val) { }

}

public enum FloatConditions.Condition.Types // TypeDefIndex: 11367
{	// Fields
	public int value__; // 0x0
	public const FloatConditions.Condition.Types Equal = 0;
	public const FloatConditions.Condition.Types NotEqual = 1;
	public const FloatConditions.Condition.Types Higher = 2;
	public const FloatConditions.Condition.Types Lower = 3;

}

