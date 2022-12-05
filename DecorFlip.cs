public class DecorFlip : DecorComponent // TypeDefIndex: 12082
{
	public DecorFlip.AxisType FlipAxis;


	public override void Apply(ref Vector3 pos, ref Quaternion rot, ref Vector3 scale) { }

	public void .ctor() { }

}

public enum DecorFlip.AxisType // TypeDefIndex: 12083
{
	public int value__;
	public const DecorFlip.AxisType X = 0;
	public const DecorFlip.AxisType Y = 1;
	public const DecorFlip.AxisType Z = 2;

}

