public class ConditionalSocketSettings // TypeDefIndex: 12095
{	// Fields
	public bool restrictOnLocation; // 0x10
	public ConditionalSocketSettings.LocationCondition locationRestriction; // 0x14
	public bool restrictOnWheel; // 0x18
	public ModularVehicleSocket.SocketWheelType wheelRestriction; // 0x1C

	// Properties
	public bool HasSocketRestrictions { get; }

	// Methods

	// RVA: 0x4B8330 Offset: 0x4B7730 VA: 0x1804B8330
	public bool get_HasSocketRestrictions() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public enum ConditionalSocketSettings.LocationCondition // TypeDefIndex: 12096
{	// Fields
	public int value__; // 0x0
	public const ConditionalSocketSettings.LocationCondition Middle = 0;
	public const ConditionalSocketSettings.LocationCondition Front = 1;
	public const ConditionalSocketSettings.LocationCondition Back = 2;
	public const ConditionalSocketSettings.LocationCondition NotMiddle = 3;
	public const ConditionalSocketSettings.LocationCondition NotFront = 4;
	public const ConditionalSocketSettings.LocationCondition NotBack = 5;

}

