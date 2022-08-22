public class ConditionalSocketSettings // TypeDefIndex: 12095
{	public bool restrictOnLocation; // 0x10
	public ConditionalSocketSettings.LocationCondition locationRestriction; // 0x14
	public bool restrictOnWheel; // 0x18
	public ModularVehicleSocket.SocketWheelType wheelRestriction; // 0x1C

	public bool HasSocketRestrictions { get; }


	public bool get_HasSocketRestrictions() { }

	public void .ctor() { }

}

public enum ConditionalSocketSettings.LocationCondition // TypeDefIndex: 12096
{	public int value__; // 0x0
	public const ConditionalSocketSettings.LocationCondition Middle = 0;
	public const ConditionalSocketSettings.LocationCondition Front = 1;
	public const ConditionalSocketSettings.LocationCondition Back = 2;
	public const ConditionalSocketSettings.LocationCondition NotMiddle = 3;
	public const ConditionalSocketSettings.LocationCondition NotFront = 4;
	public const ConditionalSocketSettings.LocationCondition NotBack = 5;

}

