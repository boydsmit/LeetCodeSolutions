namespace LeetCodeTasks.Strings
{
    /*
     * TASK: 1108
     *
     * Given a valid (IPv4) IP address, return a defanged version of that IP address.
     *
     *A defanged IP address replaces every period "." with "[.]".
     */
    
    public class DefangingAIPAddress
    {
        public string DefangIPaddr(string address) {
            return address.Replace(".", "[.]");
        }
    }
}