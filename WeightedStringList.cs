public class WeightedStringList // TypeDefIndex: 6214
{	public List<WeightedStringList.Container> Objects; // 0x10
	private float _total; // 0x18

	private float Total { get; }


	private float get_Total() { }

	public string Get(float f) { }

	public string GetRandom() { }

	public void .ctor() { }

}

public struct WeightedStringList.Container // TypeDefIndex: 6215
{	public float Weight; // 0x0
	public string Object; // 0x8

}

private sealed class WeightedStringList.<>c // TypeDefIndex: 6216
{	public static readonly WeightedStringList.<>c <>9; // 0x0
	public static Func<WeightedStringList.Container, float> <>9__3_0; // 0x8


	private static void .cctor() { }

	public void .ctor() { }

	internal float <get_Total>b__3_0(WeightedStringList.Container x) { }

}

