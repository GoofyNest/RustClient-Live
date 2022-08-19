public class PetCommandList : PrefabAttribute // TypeDefIndex: 9432
{	// Fields
	public List<PetCommandList.PetCommandDesc> Commands; // 0x98

	// Methods

	// RVA: 0x94B820 Offset: 0x94AC20 VA: 0x18094B820 Slot: 7
	protected override Type GetIndexedType() { }

	// RVA: 0x58DBE0 Offset: 0x58CFE0 VA: 0x18058DBE0
	public List<PetCommandList.PetCommandDesc> GetCommandDescriptions() { }

	// RVA: 0x94B880 Offset: 0x94AC80 VA: 0x18094B880
	public void .ctor() { }

}

public struct PetCommandList.PetCommandDesc // TypeDefIndex: 9433
{	// Fields
	public PetCommandType CommandType; // 0x0
	public Translate.Phrase Title; // 0x8
	public Translate.Phrase Description; // 0x10
	public Sprite Icon; // 0x18
	public int CommandIndex; // 0x20
	public bool Raycast; // 0x24
	public int CommandWheelOrder; // 0x28

}

