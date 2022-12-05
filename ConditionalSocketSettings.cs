public class ConditionalSocketSettings // TypeDefIndex: 13915
{
	public bool restrictOnLocation;
	public ConditionalSocketSettings.LocationCondition locationRestriction;
	public bool restrictOnWheel;
	public ModularVehicleSocket.SocketWheelType wheelRestriction;

	public bool HasSocketRestrictions { get; }


	public bool get_HasSocketRestrictions() { }

	public void .ctor() { }

}

public enum ConditionalSocketSettings.LocationCondition // TypeDefIndex: 13916
{
	public int value__;
	public const ConditionalSocketSettings.LocationCondition Middle = 0;
	public const ConditionalSocketSettings.LocationCondition Front = 1;
	public const ConditionalSocketSettings.LocationCondition Back = 2;
	public const ConditionalSocketSettings.LocationCondition NotMiddle = 3;
	public const ConditionalSocketSettings.LocationCondition NotFront = 4;
	public const ConditionalSocketSettings.LocationCondition NotBack = 5;

}

