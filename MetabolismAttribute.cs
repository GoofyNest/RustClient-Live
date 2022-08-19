public class MetabolismAttribute // TypeDefIndex: 9564
{	// Fields
	public float startMin; // 0x10
	public float startMax; // 0x14
	public float min; // 0x18
	public float max; // 0x1C
	public float value; // 0x20
	internal float lastValue; // 0x24
	internal float lastGreatFraction; // 0x28
	private const float greatInterval = 0,1;

	// Properties
	public float greatFraction { get; }

	// Methods

	// RVA: 0x966530 Offset: 0x965930 VA: 0x180966530
	public float get_greatFraction() { }

	// RVA: 0x9663D0 Offset: 0x9657D0 VA: 0x1809663D0
	public void Reset() { }

	// RVA: 0x966110 Offset: 0x965510 VA: 0x180966110
	public float Fraction() { }

	// RVA: 0x966300 Offset: 0x965700 VA: 0x180966300
	public float InverseFraction() { }

	// RVA: 0x966060 Offset: 0x965460 VA: 0x180966060
	public void Add(float val) { }

	// RVA: 0x966480 Offset: 0x965880 VA: 0x180966480
	public void Subtract(float val) { }

	// RVA: 0x966260 Offset: 0x965660 VA: 0x180966260
	public void Increase(float fTarget) { }

	// RVA: 0x966320 Offset: 0x965720 VA: 0x180966320
	public void MoveTowards(float fTarget, float fRate) { }

	// RVA: 0x9661A0 Offset: 0x9655A0 VA: 0x1809661A0
	public bool HasChanged() { }

	// RVA: 0x9661C0 Offset: 0x9655C0 VA: 0x1809661C0
	public bool HasGreatlyChanged() { }

	// RVA: 0x966470 Offset: 0x965870 VA: 0x180966470
	public void SetValue(float newValue) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public enum MetabolismAttribute.Type // TypeDefIndex: 9565
{	// Fields
	public int value__; // 0x0
	public const MetabolismAttribute.Type Calories = 0;
	public const MetabolismAttribute.Type Hydration = 1;
	public const MetabolismAttribute.Type Heartrate = 2;
	public const MetabolismAttribute.Type Poison = 3;
	public const MetabolismAttribute.Type Radiation = 4;
	public const MetabolismAttribute.Type Bleeding = 5;
	public const MetabolismAttribute.Type Health = 6;
	public const MetabolismAttribute.Type HealthOverTime = 7;

}

