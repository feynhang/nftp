using System.Net;
using System.Net.Sockets;

namespace Nftp;

public class FtpCommand(string name, string argument)
{
	public string CommandName { get; init; } = name;
	public string Argument { get; init; } = argument;
}
