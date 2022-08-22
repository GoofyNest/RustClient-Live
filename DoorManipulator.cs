public class DoorManipulator : IOEntity // TypeDefIndex: 9795
{	public EntityRef entityRef; // 0x288
	public Door targetDoor; // 0x298
	public DoorManipulator.DoorEffect powerAction; // 0x2A0


	public virtual bool PairWithLockedDoors() { }

	public void .ctor() { }

}

public enum DoorManipulator.DoorEffect // TypeDefIndex: 9796
{	public int value__; // 0x0
	public const DoorManipulator.DoorEffect Close = 0;
	public const DoorManipulator.DoorEffect Open = 1;
	public const DoorManipulator.DoorEffect Toggle = 2;

}

