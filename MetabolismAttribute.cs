public class MetabolismAttribute // TypeDefIndex: 9564
{	public float startMin; // 0x10
	public float startMax; // 0x14
	public float min; // 0x18
	public float max; // 0x1C
	public float value; // 0x20
	internal float lastValue; // 0x24
	internal float lastGreatFraction; // 0x28
	private const float greatInterval = 0,1;

	public float greatFraction { get; }


	public float get_greatFraction() { }

	public void Reset() { }

	public float Fraction() { }

	public float InverseFraction() { }

	public void Add(float val) { }

	public void Subtract(float val) { }

	public void Increase(float fTarget) { }

	public void MoveTowards(float fTarget, float fRate) { }

	public bool HasChanged() { }

	public bool HasGreatlyChanged() { }

	public void SetValue(float newValue) { }

	public void .ctor() { }

}

public enum MetabolismAttribute.Type // TypeDefIndex: 9565
{	public int value__; // 0x0
	public const MetabolismAttribute.Type Calories = 0;
	public const MetabolismAttribute.Type Hydration = 1;
	public const MetabolismAttribute.Type Heartrate = 2;
	public const MetabolismAttribute.Type Poison = 3;
	public const MetabolismAttribute.Type Radiation = 4;
	public const MetabolismAttribute.Type Bleeding = 5;
	public const MetabolismAttribute.Type Health = 6;
	public const MetabolismAttribute.Type HealthOverTime = 7;

}

