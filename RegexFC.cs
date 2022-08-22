internal sealed class RegexFC // TypeDefIndex: 2614
{	internal RegexCharClass _cc; // 0x10
	internal bool _nullable; // 0x18
	internal bool _caseInsensitive; // 0x19


	internal void .ctor(bool nullable) { }

	internal void .ctor(char ch, bool not, bool nullable, bool caseInsensitive) { }

	internal void .ctor(string charClass, bool nullable, bool caseInsensitive) { }

	internal bool AddFC(RegexFC fc, bool concatenate) { }

	internal string GetFirstChars(CultureInfo culture) { }

	internal bool IsCaseInsensitive() { }

}

