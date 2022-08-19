public class DecorFlip : DecorComponent // TypeDefIndex: 10323
{	// Fields
	public DecorFlip.AxisType FlipAxis; // 0xA0

	// Methods

	// RVA: 0x8E8010 Offset: 0x8E7410 VA: 0x1808E8010 Slot: 8
	public override void Apply(ref Vector3 pos, ref Quaternion rot, ref Vector3 scale) { }

	// RVA: 0x8E81F0 Offset: 0x8E75F0 VA: 0x1808E81F0
	public void .ctor() { }

}

public enum DecorFlip.AxisType // TypeDefIndex: 10324
{	// Fields
	public int value__; // 0x0
	public const DecorFlip.AxisType X = 0;
	public const DecorFlip.AxisType Y = 1;
	public const DecorFlip.AxisType Z = 2;

}

