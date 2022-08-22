public class PetCommandList : PrefabAttribute // TypeDefIndex: 9432
{	public List<PetCommandList.PetCommandDesc> Commands; // 0x98


	protected override Type GetIndexedType() { }

	public List<PetCommandList.PetCommandDesc> GetCommandDescriptions() { }

	public void .ctor() { }

}

public struct PetCommandList.PetCommandDesc // TypeDefIndex: 9433
{	public PetCommandType CommandType; // 0x0
	public Translate.Phrase Title; // 0x8
	public Translate.Phrase Description; // 0x10
	public Sprite Icon; // 0x18
	public int CommandIndex; // 0x20
	public bool Raycast; // 0x24
	public int CommandWheelOrder; // 0x28

}

