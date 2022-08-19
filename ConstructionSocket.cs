public class ConstructionSocket : Socket_Base // TypeDefIndex: 9060
{	// Fields
	public ConstructionSocket.Type socketType; // 0xE8
	public int rotationDegrees; // 0xEC
	public int rotationOffset; // 0xF0
	public bool restrictPlacementRotation; // 0xF4
	public bool restrictPlacementAngle; // 0xF5
	public float faceAngle; // 0xF8
	public float angleAllowed; // 0xFC
	[RangeAttribute] // RVA: 0x71260 Offset: 0x70660 VA: 0x180071260
	public float support; // 0x100

	// Methods

	// RVA: 0x50DEA0 Offset: 0x50D2A0 VA: 0x18050DEA0
	private void OnDrawGizmos() { }

	// RVA: 0x50DDE0 Offset: 0x50D1E0 VA: 0x18050DDE0
	private void OnDrawGizmosSelected() { }

	// RVA: 0x50E310 Offset: 0x50D710 VA: 0x18050E310 Slot: 8
	public override bool TestTarget(Construction.Target target) { }

	// RVA: 0x50DCE0 Offset: 0x50D0E0 VA: 0x18050DCE0 Slot: 9
	public override bool IsCompatible(Socket_Base socket) { }

	// RVA: 0x50C820 Offset: 0x50BC20 VA: 0x18050C820 Slot: 10
	public override bool CanConnect(Vector3 position, Quaternion rotation, Socket_Base socket, Vector3 socketPosition, Quaternion socketRotation) { }

	// RVA: 0x50E150 Offset: 0x50D550 VA: 0x18050E150
	public bool TestRestrictedAngles(Vector3 suggestedPos, Quaternion suggestedAng, Construction.Target target) { }

	// RVA: 0x50CDE0 Offset: 0x50C1E0 VA: 0x18050CDE0 Slot: 11
	public override Construction.Placement DoPlacement(Construction.Target target) { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 13
	protected virtual bool CanConnectToEntity(Construction.Target target) { }

	// RVA: 0x50E3C0 Offset: 0x50D7C0 VA: 0x18050E3C0
	public void .ctor() { }

}

public enum ConstructionSocket.Type // TypeDefIndex: 9061
{	// Fields
	public int value__; // 0x0
	public const ConstructionSocket.Type None = 0;
	public const ConstructionSocket.Type Foundation = 1;
	public const ConstructionSocket.Type Floor = 2;
	public const ConstructionSocket.Type Misc = 3;
	public const ConstructionSocket.Type Doorway = 4;
	public const ConstructionSocket.Type Wall = 5;
	public const ConstructionSocket.Type Block = 6;
	public const ConstructionSocket.Type Ramp = 7;
	public const ConstructionSocket.Type StairsTriangle = 8;
	public const ConstructionSocket.Type Stairs = 9;
	public const ConstructionSocket.Type FloorFrameTriangle = 10;
	public const ConstructionSocket.Type Window = 11;
	public const ConstructionSocket.Type Shutters = 12;
	public const ConstructionSocket.Type WallFrame = 13;
	public const ConstructionSocket.Type FloorFrame = 14;
	public const ConstructionSocket.Type WindowDressing = 15;
	public const ConstructionSocket.Type DoorDressing = 16;
	public const ConstructionSocket.Type Elevator = 17;
	public const ConstructionSocket.Type DoubleDoorDressing = 18;

}

public class ConstructionSocket_Elevator : ConstructionSocket // TypeDefIndex: 9062
{	// Fields
	public int MaxFloor; // 0x108

	// Methods

	// RVA: 0x50D7D0 Offset: 0x50CBD0 VA: 0x18050D7D0 Slot: 13
	protected override bool CanConnectToEntity(Construction.Target target) { }

	// RVA: 0x50D9F0 Offset: 0x50CDF0 VA: 0x18050D9F0 Slot: 10
	public override bool CanConnect(Vector3 position, Quaternion rotation, Socket_Base socket, Vector3 socketPosition, Quaternion socketRotation) { }

	// RVA: 0x50DCB0 Offset: 0x50D0B0 VA: 0x18050DCB0
	public void .ctor() { }

}

