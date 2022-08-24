internal sealed class RegexFC // TypeDefIndex: 2614
{
	internal RegexCharClass _cc; 
	internal bool _nullable; 
	internal bool _caseInsensitive; 


	internal void .ctor(bool nullable) { }

	internal void .ctor(char ch, bool not, bool nullable, bool caseInsensitive) { }

	internal void .ctor(string charClass, bool nullable, bool caseInsensitive) { }

	internal bool AddFC(RegexFC fc, bool concatenate) { }

	internal string GetFirstChars(CultureInfo culture) { }

	internal bool IsCaseInsensitive() { }

}

