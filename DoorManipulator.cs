public class DoorManipulator : IOEntity // TypeDefIndex: 11468
{
	public EntityRef entityRef; 
	public Door targetDoor; 
	public DoorManipulator.DoorEffect powerAction; 


	public virtual bool PairWithLockedDoors() { }

	public void .ctor() { }

}

public enum DoorManipulator.DoorEffect // TypeDefIndex: 11469
{
	public int value__; 
	public const DoorManipulator.DoorEffect Close = 0;
	public const DoorManipulator.DoorEffect Open = 1;
	public const DoorManipulator.DoorEffect Toggle = 2;

}

