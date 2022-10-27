namespace HostsFileModifier
{
    public class Controller
    {
        const string hostsFilePath = @"C:\Windows\System32\drivers\etc\hosts";
        //const string hostsFilePath = @"C:\Users\micha\Documents\drivers\etc\hosts";

        public string addAddressToHostsFile(string address, string ip)
        {

            string[] hostsFileText = File.ReadAllLines(hostsFilePath);
            List<string> hostsFileContents = new List<string>(hostsFileText);
            hostsFileContents.Add($"{ip} {address}");

            try {
                File.WriteAllLines(hostsFilePath, hostsFileContents.ToArray());
                return "success";
            } catch {
                return "error";
            }
        }
    }
}
