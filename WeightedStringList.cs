public class WeightedStringList // TypeDefIndex: 6214
{	// Fields
	public List<WeightedStringList.Container> Objects; // 0x10
	private float _total; // 0x18

	// Properties
	private float Total { get; }

	// Methods

	// RVA: 0x14F5F70 Offset: 0x14F5370 VA: 0x1814F5F70
	private float get_Total() { }

	// RVA: 0x14F5CE0 Offset: 0x14F50E0 VA: 0x1814F5CE0
	public string Get(float f) { }

	// RVA: 0x14F5CB0 Offset: 0x14F50B0 VA: 0x1814F5CB0
	public string GetRandom() { }

	// RVA: 0x14F5F00 Offset: 0x14F5300 VA: 0x1814F5F00
	public void .ctor() { }

}

public struct WeightedStringList.Container // TypeDefIndex: 6215
{	// Fields
	public float Weight; // 0x0
	public string Object; // 0x8

}

private sealed class WeightedStringList.<>c // TypeDefIndex: 6216
{	// Fields
	public static readonly WeightedStringList.<>c <>9; // 0x0
	public static Func<WeightedStringList.Container, float> <>9__3_0; // 0x8

	// Methods

	// RVA: 0x14F4550 Offset: 0x14F3950 VA: 0x1814F4550
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x14F3EE0 Offset: 0x14F32E0 VA: 0x1814F3EE0
	internal float <get_Total>b__3_0(WeightedStringList.Container x) { }

}

