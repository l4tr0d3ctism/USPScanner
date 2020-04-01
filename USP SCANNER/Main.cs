using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Management;
using System.IO;
using System.Security.AccessControl;
using System.Diagnostics;
using Microsoft.Win32;

namespace USP_SCANNER
{
    public partial class USPScanfrm : Form
    {
        string progfolder = null;
        string SVCPID = null;
        string SVCPRCN = null;
        string SVCN = null;
        public USPScanfrm()
        {
            InitializeComponent();
        }

        public static string GetProcessname(int processId)
        {
            string MethodResult = "";
            try
            {
                string Query = "SELECT Name FROM Win32_Process WHERE ProcessId = " + processId;

                using (ManagementObjectSearcher mos = new ManagementObjectSearcher(Query))
                {
                    using (ManagementObjectCollection moc = mos.Get())
                    {
                        string processname = (from mo in moc.Cast<ManagementObject>() select mo["Name"]).First().ToString();

                        MethodResult = processname;
                    }
                }
            }
            catch
            {

            }
            return MethodResult;
        }
        private void BtnScan_Click(object sender, EventArgs e)
        {
            string PathN = null;
            string SVCStm = null;
            string svcpa = null;
            string SVCpathVul = null;
            int unicode = 34;
            int CHRN;
            char character = (char)unicode;
            string text = character.ToString();
            ManagementClass service_class = new ManagementClass("Win32_Service");

            ManagementObjectCollection Service_objects_collection = service_class.GetInstances();
            listView1.Items.Clear();
            foreach (ManagementObject service in Service_objects_collection)
            {
                try
                {
                    SVCN = (service["Name"].ToString());
                    PathN = (service["pathname"].ToString());
                    SVCStm = (service["StartMode"].ToString());
                    SVCPID = (service["Processid"].ToString());

                    if (!PathN.ToLower().Contains(character)&& !PathN.ToLower().Contains(@"c:\windows\") &&!service["StartMode"].ToString().Contains("Manual"))
                    {
                        SVCPRCN = GetProcessname(int.Parse(SVCPID));
                        CHRN = ((PathN.ToLower()).LastIndexOf(SVCPRCN.ToLower()));
                        progfolder = PathN.Substring(0, CHRN);
                        svcpa = (HasWritePermission(progfolder)).ToString();
                        SVCpathVul = PathN.Substring(0, CHRN);
                        int vul = SVCpathVul.LastIndexOf(" ");
                       
                        if (vul >= 0)
                        {
                            
                            SVCpathVul = "Yes";
                            FileVersionInfo.GetVersionInfo(Path.Combine(progfolder, SVCPRCN));
                            FileVersionInfo myFileVersionInfo = FileVersionInfo.GetVersionInfo(progfolder + "\\" + SVCPRCN);
                            string filever = (myFileVersionInfo.FileDescription + myFileVersionInfo.FileVersion);
                            string[] row = { SVCN, PathN, SVCStm, svcpa, SVCpathVul, filever };
                            var listViewItem = new ListViewItem(row);
                            listView1.Items.Add(listViewItem);
                            listViewItem.BackColor = System.Drawing.Color.IndianRed;
                            listViewItem.ForeColor = System.Drawing.Color.White;
                            listViewItem.Checked = true;
                            POCRep.Enabled = true;
                        }
                        else
                        {
                            
                            SVCpathVul = "No";
                            FileVersionInfo.GetVersionInfo(Path.Combine(progfolder, SVCPRCN));
                            FileVersionInfo myFileVersionInfo = FileVersionInfo.GetVersionInfo(progfolder + "\\" + SVCPRCN);
                            string filever = (myFileVersionInfo.FileDescription + myFileVersionInfo.FileVersion);
                            string[] row = { SVCN, PathN, SVCStm, svcpa, SVCpathVul, filever };
                            var listViewItem = new ListViewItem(row);
                            listView1.Items.Add(listViewItem);
                            listViewItem.BackColor = System.Drawing.Color.Green;
                            listViewItem.ForeColor = System.Drawing.Color.White;
                            POCRep.Enabled = true;
                        }
                    }
                }
                catch
                {

                }
            }
        }


        public static bool HasWritePermission(string dir)
        {
            bool Allow = false;
            bool Deny = false;
            DirectorySecurity acl = null;
            try
            {
                acl = Directory.GetAccessControl(dir);
            }
            catch (System.IO.DirectoryNotFoundException)
            {
                throw new Exception("DirectoryNotFoundException");
            }
            if (acl == null)
                return false;
            AuthorizationRuleCollection arc = acl.GetAccessRules(true, true, typeof(System.Security.Principal.SecurityIdentifier));
            if (arc == null)
                return false;
            foreach (FileSystemAccessRule rule in arc)
            {
                if ((FileSystemRights.Write & rule.FileSystemRights) != FileSystemRights.Write)
                    continue;
                if (rule.AccessControlType == AccessControlType.Allow)
                    Allow = true;
                else if (rule.AccessControlType == AccessControlType.Deny)
                    Deny = true;
            }
            return Allow && !Deny;
        }

        private void POCRep_Click(object sender, EventArgs e)
        {
            string POC = (
"# Exploit Title:" + "<<your Filename and version>>" + " Unquoted Service Path" + "\r\n" +
"# Discovery by:" + " <<Your Name>>" + "\r\n" +
"# Discovery Date:" + " <<DATE>> " + "\r\n" +
"# Vendor Homepage:" + "<<software website Address" + "\r\n" +
"# Software Link:" + "<<Software Download Link>>" + "\r\n" +
"# Tested Version:" + "<<software Version>>" + "\r\n" +
"# Vulnerability Type: Unquoted Service Path" + "\r\n" +
"# Tested on OS:" + "\r\n" +
"\r\n" +
"# Step to discover Unquoted Service Path: " + "\r\n" +
"\r\n" +
"Enter the following command in CMD and copy the result here" + "\r\n" +
"wmic service get name, displayname, pathname, startmode | findstr /i Auto | findstr /i /v " + @"C:\Windows" + "| findstr /i /v \"\"\"" +
"\r\n" +
"\r\n" +
"Enter the following command in CMD and copy the result here" + "\r\n" +
"sc qc " + "<<Service Name>>" +
"\r\n" +
"\r\n" +
"# Exploit:" + "\r\n" +
"# A successful attempt would require the local user to be able to insert their code in the system " + "\r\n" +
"# root path undetected by the OS or other security applications where it could potentially be " + "\r\n" +
"# executed during application startup or reboot. If successful, the local user's code would " + "\r\n" +
"# execute with the elevated privileges of the application." + "\r\n");
            if (File.Exists(Environment.CurrentDirectory + "\\POC.txt"))
            {
                System.IO.File.WriteAllText(Environment.CurrentDirectory + "\\poc.txt", POC);
                Process.Start(Environment.CurrentDirectory);
            }
            else
            {
                System.IO.File.WriteAllText(Environment.CurrentDirectory + "\\poc.txt", POC);
                Process.Start(Environment.CurrentDirectory);
            }

            
        }


        private void USPScanfrm_Load(object sender, EventArgs e)
        {

        }
        public static string getregval(string subk)
        {
            string reg = null;
            RegistryKey key = Registry.LocalMachine.OpenSubKey(subk);
            if (key != null)
            {
                 reg = (key.GetValue("ImagePath").ToString());
            }
            return reg;
        }
        public void setregv(string keyn)
        {
 
            string keys = "SYSTEM\\CurrentControlSet\\Services\\";
            string userRootandkey= "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\";
            Registry.SetValue(userRootandkey + keyn, "ImagePath","\"" + getregval(keys + keyn) + "\"");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                //   setregv("Seed4.Me Service");
                for (int c = 0; c < (listView1.Items.Count); c++)
                {
                    if (listView1.Items[c].Checked)
                    {
                        setregv((listView1.Items[c].ToString()).ToLower().Replace("listviewitem: {", "").Replace("}", ""));
                    }
                }
                // MessageBox.Show( );
            }catch(Exception ex)
            {
                MessageBox.Show("Run Program as Administrator privilege","Error");
            }

        }
    }
}