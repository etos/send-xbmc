using System;
using System.IO;
using System.Net;                      //for access xbox webserver
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;					// for reg key

namespace SendXBMC
{
    public partial class frmSendXBMC : Form
    {
        //pub vars
        public static string strUsername = "guest";
        public static string strPassword = "guest";

        //priv vars
        private const string MenuName = "*\\shell\\SendXBMC";
        private const string Command = "*\\shell\\SendXBMC\\command";
        private const string xboxip = "*\\shell\\SendXBMC\\xboxip";
        private const string askdeets = "*\\shell\\SendXBMC\\askdeets";


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main( string[] args )
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            if (args.Length > 0)
            {
                //######### get data from registry #########

                string strXboxIP = "0.0.0.0";
                bool boolAskDetails = false;

                RegistryKey regaskdeets = null;
                RegistryKey regip = null;
                try
                {
                    regip = Registry.ClassesRoot.OpenSubKey(xboxip);
                    if (regip != null)
                    {
                        strXboxIP = Convert.ToString(regip.GetValue(""));
                    }

                    regaskdeets = Registry.ClassesRoot.OpenSubKey(askdeets);
                    if (regaskdeets != null)
                    {
                        boolAskDetails = Convert.ToBoolean(regaskdeets.GetValue(""));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    if (regaskdeets != null)
                        regaskdeets.Close();
                    if (regip != null)
                        regip.Close();
                }


                //######### get any authentication details #########

                if (boolAskDetails == true)
                {
                    Application.Run(new frmPrompt());
                }


                //######### contact xbox with data to play #########

                try
                {
                    string strFile = args[0].ToString();

                    if ((strFile.Substring(0, 1) != "\\") && (strFile.Substring(1, 1) != "\\"))  //if file on local machine
                    {
                        strFile = strFile.Replace('\\', '/');
                        strFile = strFile.Replace("+", "%2b");
                        strFile = strFile.Remove(1, 1);
                        string myHost = System.Net.Dns.GetHostName();

                        if (boolAskDetails == false)
                        {
                            GetURL("http://" + strXboxIP + "/xbmcCmds/xbmcHttp?command=playfile&parameter=smb://" + myHost + "/" + strFile);
                        }
                        else
                        {
                            GetURL("http://" + strXboxIP + "/xbmcCmds/xbmcHttp?command=playfile&parameter=smb://" 
                                + strUsername + ":" + strPassword + "@" + myHost + "/" + strFile);
                        }
                    }
                    else if (strFile.Substring(1, 1) != ":")  //if file on network
                    {
                        strFile = strFile.Replace('\\', '/');
                        strFile = strFile.Replace("+", "%2b");
                        strFile = strFile.Remove(0, 2);

                        if (boolAskDetails == false)
                        {
                            GetURL("http://" + strXboxIP + "/xbmcCmds/xbmcHttp?command=playfile&parameter=smb://" + strFile);
                        }
                        else
                        {
                            GetURL("http://" + strXboxIP + "/xbmcCmds/xbmcHttp?command=playfile&parameter=smb://"
                                + strUsername + ":" + strPassword + "@" + strFile);
                        }
                        
                    }

                }
                catch (Exception ex)
                {
                    /*  DO NOTHING  (coss some errors dealing with xbox webserver, but video plays anyway)
                     *
                     * 
                    MessageBox.Show("An Error has occurred, if xbox is not playing video: \n\n" + 
                        "- Check your XBOX IP is set correctly \n- Check XBOX is still on / not crashed etc", 
                        "Doh!! An Error.... Run!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                     * 
                     */
                }

                //exit program - UI not wanted if args were passed to app
                Application.ExitThread();
                Application.Exit();
            }
            else
            {
                //close app early.. call was from context so UI not required

                Application.Run(new frmSendXBMC());
            }






        }


        public frmSendXBMC()
        {            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //######### get data from registry #########
            string strXboxIP = "0.0.0.0";
            bool boolAskDetails = false;

            RegistryKey regaskdeets = null;
            RegistryKey regip = null;
            try
            {
                regip = Registry.ClassesRoot.OpenSubKey(xboxip);
                if (regip != null)
                {
                    txtIP.Text = Convert.ToString(regip.GetValue(""));
                }

                regaskdeets = Registry.ClassesRoot.OpenSubKey(askdeets);
                if (regaskdeets != null)
                {
                    chkAksDeets.Checked = Convert.ToBoolean(regaskdeets.GetValue(""));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (regaskdeets != null)
                    regaskdeets.Close();
                if (regip != null)
                    regip.Close();
            }
        }

        private void btnContextAdd_Click(object sender, EventArgs e)
        {
            ContextMenu("yes");
        }

        private void btnContextRem_Click(object sender, EventArgs e)
        {
            ContextMenu("no");
        }


        public void ContextMenu(string option)
        {
            if (option == "yes")
            {
                RegistryKey regmenu = null;
                RegistryKey regcmd = null;
                RegistryKey regip = null;
                RegistryKey regdeets = null;
                try
                {
                    regmenu = Registry.ClassesRoot.CreateSubKey(MenuName);
                    if (regmenu != null)
                        regmenu.SetValue("", "Send to XBMC");

                    regcmd = Registry.ClassesRoot.CreateSubKey(Command);
                    if (regcmd != null)
                        regcmd.SetValue("", "\"" + Application.ExecutablePath + "\"" + " " + "\"%1\"");

                    regip = Registry.ClassesRoot.CreateSubKey(xboxip);
                    if (regip != null)
                        regip.SetValue("", "0.0.0.0");

                    regdeets = Registry.ClassesRoot.CreateSubKey(askdeets);
                    if (regdeets != null)
                        regdeets.SetValue("", "False");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.ToString());
                }
                finally
                {
                    if (regmenu != null)
                        regmenu.Close();
                    if (regcmd != null)
                        regcmd.Close();
                    if (regip != null)
                        regip.Close();
                    if (regdeets != null)
                        regdeets.Close();
                }
            }
            else
            {
                try
                {
                    RegistryKey reg = Registry.ClassesRoot.OpenSubKey(Command);
                    if (reg != null)
                    {
                        reg.Close();
                        Registry.ClassesRoot.DeleteSubKey(Command);
                    }

                    reg = Registry.ClassesRoot.OpenSubKey(xboxip);
                    if (reg != null)
                    {
                        reg.Close();
                        Registry.ClassesRoot.DeleteSubKey(xboxip);
                    }

                    reg = Registry.ClassesRoot.OpenSubKey(askdeets);
                    if (reg != null)
                    {
                        reg.Close();
                        Registry.ClassesRoot.DeleteSubKey(askdeets);
                    }

                    reg = Registry.ClassesRoot.OpenSubKey(MenuName);
                    if (reg != null)
                    {
                        reg.Close();
                        Registry.ClassesRoot.DeleteSubKey(MenuName);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.ToString());
                }
            }

        }

        private void btnSetIP_Click(object sender, EventArgs e)
        {
            RegistryKey regip = null;
            try
            {
                regip = Registry.ClassesRoot.CreateSubKey(xboxip);
                regip.SetValue("", this.txtIP.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.ToString());
            }
            finally
            {
                if (regip != null)
                regip.Close();
            }
        }

        //gets URL, but intentionally does nothing with output coss its not required
        public static void GetURL( string strURL )
        {
            WebRequest myWebRequest = WebRequest.Create(strURL);
            WebResponse myWebResponse = myWebRequest.GetResponse();
            Stream ReceiveStream = myWebResponse.GetResponseStream();
            myWebResponse.Close();

        }

        private void chkAksDeets_CheckedChanged(object sender, EventArgs e)
        {
            RegistryKey regaskdeets = null;
            try
            {
                regaskdeets = Registry.ClassesRoot.CreateSubKey(askdeets);
                regaskdeets.SetValue("", chkAksDeets.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.ToString());
            }
            finally
            {
                if (regaskdeets != null)
                    regaskdeets.Close();
            }
        }

        //gets URL, but intentionally does nothing with output coss its not required
        public static void SetAuth(string strUsr, string strPass)
        {
            strUsername = strUsr;
            strPassword = strPass;
        }
    }
 }
