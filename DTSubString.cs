internal struct DTSubString // TypeDefIndex: 233
{	internal string s; // 0x0
	internal int index; // 0x8
	internal int length; // 0xC
	internal DTSubStringType type; // 0x10
	internal int value; // 0x14

	internal char Item { get; }


	internal char get_Item(int relativeIndex) { }

}

