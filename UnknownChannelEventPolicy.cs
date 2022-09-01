public enum UnknownChannelEventPolicy // TypeDefIndex: 7608
{
	public int value__; 
	public const UnknownChannelEventPolicy Abort = 0;
	public const UnknownChannelEventPolicy SkipStatusByte = 1;
	public const UnknownChannelEventPolicy SkipStatusByteAndOneDataByte = 2;
	public const UnknownChannelEventPolicy SkipStatusByteAndTwoDataBytes = 3;
	public const UnknownChannelEventPolicy UseCallback = 4;

}

