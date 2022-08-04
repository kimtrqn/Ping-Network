using System.Net.NetworkInformation;
using System.Text;

//Pinging Google DNS Server 4.2.2.2;

Ping pingSender = new Ping();

PingOptions options = new PingOptions();


options.DontFragment = true;

string data = "Learn to Code";
byte[] buffer = Encoding.ASCII.GetBytes(data);
int timeout = 120;
string address = "4.2.2.2";

PingReply reply = pingSender.Send(address, timeout, buffer, options);


