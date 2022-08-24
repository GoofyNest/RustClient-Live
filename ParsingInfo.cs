internal struct ParsingInfo // TypeDefIndex: 239
{
	internal Calendar calendar; 
	internal int dayOfWeek; 
	internal DateTimeParse.TM timeMark; 
	internal bool fUseHour12; 
	internal bool fUseTwoDigitYear; 
	internal bool fAllowInnerWhite; 
	internal bool fAllowTrailingWhite; 
	internal bool fCustomNumberParser; 
	internal DateTimeParse.MatchNumberDelegate parseNumberDelegate; 


	internal void Init() { }

}

