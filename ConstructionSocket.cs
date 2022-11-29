public class ConstructionSocket : Socket_Base // TypeDefIndex: 10787
{
	public ConstructionSocket.Type socketType; 
	public int rotationDegrees; 
	public int rotationOffset; 
	public bool restrictPlacementRotation; 
	public bool restrictPlacementAngle; 
	public float faceAngle; 
	public float angleAllowed; 
	[RangeAttribute] 
	public float support; 


	private void OnDrawGizmos() { }

	private void OnDrawGizmosSelected() { }

	public override bool TestTarget(Construction.Target target) { }

	public override bool IsCompatible(Socket_Base socket) { }

	public override bool CanConnect(Vector3 position, Quaternion rotation, Socket_Base socket, Vector3 socketPosition, Quaternion socketRotation) { }

	public bool TestRestrictedAngles(Vector3 suggestedPos, Quaternion suggestedAng, Construction.Target target) { }

	public override Construction.Placement DoPlacement(Construction.Target target) { }

	protected virtual bool CanConnectToEntity(Construction.Target target) { }

	public void .ctor() { }

}

public enum ConstructionSocket.Type // TypeDefIndex: 10788
{
	public int value__; 
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

public class ConstructionSocket_Elevator : ConstructionSocket // TypeDefIndex: 10789
{
	public int MaxFloor; 


	protected override bool CanConnectToEntity(Construction.Target target) { }

	public override bool CanConnect(Vector3 position, Quaternion rotation, Socket_Base socket, Vector3 socketPosition, Quaternion socketRotation) { }

	public void .ctor() { }

}

