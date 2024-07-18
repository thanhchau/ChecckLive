using System.IO;
using System.Net.NetworkInformation;
using static System.Net.WebRequestMethods;
using System.Text;
using System.Xml.Linq;
using static System.Windows.Forms.LinkLabel;

namespace CheckMachineLine
{
    public partial class Form1 : Form
    {
        private static HttpClient client = new HttpClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ips = textBox1.Text;
            if (isValidConnection(ips))
            {
                listBox1.Items.Add(ips);
            }
            else
            {
                MessageBox.Show(ips + " is not reachable");
            }



            //textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /* string ips = textBox1.Text.Trim();
             string strCmdText = "putty -ssh -l root -pw thanhchau3 -m C:\\command.txt 192.168.139.129";
             System.Diagnostics.Process.Start("CMD.exe", strCmdText);*/

            textBox1.Enabled = false;
            txtPwd.Enabled = false;
            txtuser.Enabled = false;
            button2.Enabled = false;
            txtDb.Enabled = false;
            
            timer1.Interval = 5000;
            timer1.Start();

        }

        private bool isValidConnection(string url)
        {
            string p = @"\\" + url + @"\Pictures";
            Func<bool> func = () => Directory.Exists(p);
            Task<bool> task = new Task<bool>(func);
            task.Start();
            if (task.Wait(1000))
            {
                return task.Result;
            }
            else
            {
                // Didn't get an answer back in time be pessimistic and assume it didn't exist
                return false;
            }
        }
        private bool isServerAlive(string url)
        {
            bool result = false;
            try
            {
                Ping p1 = new Ping();

                PingReply PR = p1.Send(url,500);

                if (PR.Status == IPStatus.Success)
                {
                    result = true;
                }

            }
            catch
            {
                return result = false;
            }

            return result;
        }
        private bool isSSHaccess(string url)
        {
            bool rs = false;

            return rs;
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {   int i=0; 
            foreach (string item in listBox1.Items)
            {
                i++;
                string machineName = "may" + i.ToString();
                if (isServerAlive(item))
                {
                    if (!isValidConnection(item))
                    {
                        if (txtLog.Text.Length == 5000)
                        {
                            txtLog.Text = "";
                        }
                        txtLog.AppendText("Turn on SMB " + item + " at " + DateTime.Now.ToString() + "  \r\n");
                        System.Diagnostics.Process process = new System.Diagnostics.Process();
                        process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                        process.StartInfo.FileName = "cmd.exe";
                        //process.StartInfo.Arguments = "/C putty -ssh -l " + txtuser.Text.Trim() + " -pw " + txtPwd.Text.Trim() + " -m command.txt " + item;
                        process.StartInfo.Arguments = "/C plink -batch -ssh -l " + txtuser.Text.Trim() + " -pw " + txtPwd.Text.Trim() + " -m command.txt " + item;
                        process.Start();
                        


                    }
                    int status = 1;
                    await Task.Run(() => sendDatatoServer(machineName, status));

                }
                else
                {
                    if (txtLog.Text.Length == 5000)
                    {
                        txtLog.Text = "";
                    }
                    txtLog.AppendText("Server" + item + " not Turn on\r\n");
                    int status = 0;
                    await Task.Run(() => sendDatatoServer(machineName, status));

                }
                
                var date = DateTime.Today.Date.ToShortDateString().Substring(0,1);
                /*if (date == "1")
                {
                    
                    string path = @"E:\alldata\" + machineName + @"\" + DateTime.Now.Year.ToString() + @"\" + DateTime.Today.AddMonths(-3).Month.ToString().PadLeft(2,'0');
                    DeleteDir(path);
                }
                else { 
                }*/
                if (date != "1" )
                {
                    string path = @"E:\alldata\" + machineName + @"\" + DateTime.Now.Year.ToString() + @"\" + DateTime.Now.Month.ToString().PadLeft(2, '0') + @"\" + DateTime.Today.AddDays(-1).Day.ToString().PadLeft(2, '0') + @"\export";
                    DeleteFile(path);
                }
                
            }



        }

        private void DeleteFile(string path)
        {
            var files = Directory.GetFiles( path,"*.tif");
            if(files.Length > 0)
            {
                Parallel.ForEach(files, (f) => System.IO.File.Delete(f));
            }
        }
        private void DeleteDir(string path)
        {
            try
            {
                var dir = new DirectoryInfo(path);
                if (dir.Exists)
                {
                    dir.Delete(true);
                }
            }catch(Exception ex)
            {
                Console.Write(ex.ToString());
            }
            
        }

        async Task sendDatatoServer(string machineName, int status)
        {
            try
            {
                //mockup api https://661e254198427bbbef038972.mockapi.io/machine
                var url = txtDb.Text;
                var data = new Machine() { machineName = machineName, status = status };
                var jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(data);
                var requestContent = new StringContent(jsonData, Encoding.Unicode, "application/json");
                var response = await client.PostAsync(url, requestContent);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
           
        }


        private void txtLog_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
