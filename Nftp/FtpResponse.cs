namespace Nftp;

public class FtpResponse
{

	internal FtpResponse(string response)
	{
		var sub_resps = response.Split();
		ResponseCode = uint.Parse(sub_resps[0]);
		Message = string.Join(' ', sub_resps[1..]);
	}
	public uint ResponseCode { get; init; }
	public string Message { get; init; }
}
