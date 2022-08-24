internal enum HebrewNumberParsingState // TypeDefIndex: 707
{
	public int value__; 
	public const HebrewNumberParsingState InvalidHebrewNumber = 0;
	public const HebrewNumberParsingState NotHebrewDigit = 1;
	public const HebrewNumberParsingState FoundEndOfHebrewNumber = 2;
	public const HebrewNumberParsingState ContinueParsing = 3;

}

