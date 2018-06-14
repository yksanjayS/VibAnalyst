using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Iadeptmain.GlobalClasess;
using Iadeptmain.GlobalClasses;
using Iadeptmain.Classes;
using System.IO;
using System.Data.Odbc;
using Iadeptmain.Images;
using trial6;
using DevExpress.XtraSplashScreen;
using System.Management;
using System.IO.Ports;


namespace Iadeptmain.Mainforms
{
    public partial class frmupdownload : DevExpress.XtraEditors.XtraForm
    {
        public delegate void ShowStatusMessageHandler();
        frmupdownload objupdown = null;
        frmUpload upload = null;
        frmdownload download = null;
        frmIAdeptMain _objMain;
        ShowStatusMessageHandler m_objToShowString = null;
        private string m_sMessage = null;
        string SerialKeyForImpaq = null;
        private SerialPort m_objSerialPort = null;
        public string check = null;
        public frmupdownload()
        {
            InitializeComponent();
             m_objRAPI = new RAPI();
            if (m_objRAPI.DevicePresent)
            {
                m_objRAPI.Connect();
                if (PublicClass.currentInstrument == "Impaq-Benstone" || PublicClass.currentInstrument == "FieldPaq2")
                {
                    //serialKey = GetSrialKeyForImpaq();
                    GetSrialKeyForImpaq();
                    if (PublicClass.InstrumentSerial == SerialKeyForImpaq)
                    {
                        check = "true";
                        if (PublicClass.currentInstrument == "Impaq-Benstone")
                        {
                            pictureBox2.Image = ImageResources.elite2;
                        }
                        else
                        { pictureBox2.Image = ImageResources.fieldpaqnew; }
                    }
                    else
                    { check = "false"; }
                }
            }
            else
            {
                if (PublicClass.currentInstrument == "Impaq-Benstone")
                {
                    //GetSrialKeyForImpaq();
                    if (PublicClass.InstrumentSerial == SerialKeyForImpaq)
                    {
                        check = "true";
                        if (PublicClass.currentInstrument == "Impaq-Benstone")
                        {
                            pictureBox2.Image = ImageResources.elite2;
                        }
                        else
                        { pictureBox2.Image = ImageResources.fieldpaqnew; }
                    }
                    else
                    { check = "true"; }
                }
                if (PublicClass.currentInstrument == "SKF/DI")
                {
                    ConnectwithINST();
                    if (DiStatus == true)
                    {
                        check = "true";
                        pictureBox2.Image = ImageResources.fieldpac;
                    }
                    else { check = "true"; }
                }
                else if (PublicClass.currentInstrument == "Kohtect-C911")
                {
                    ConnectwithC911();

                    if (DiStatus == true)
                    {
                        check = "true";
                        pictureBox2.Image = ImageResources.kohtect;

                        /////////////////////////This code is for verify serial key from database and instrumet/////////////////////////////////

                        //bool keyCheck = checkSerialKeyForInstrument(PublicClass.currentInstrument);
                        //if (keyCheck == true)
                        //{
                        //    check = "true";
                        //    pictureBox2.Image = ImageResources.kohtect;
                        //}
                        //else
                        //{
                        //    check = "false";
                        //    //MessageBox.Show("You are connected unautherized Instrument..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //    return;
                        //}
                        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                    }
                    else
                    {
                        //check = "false";
                        //MessageBox.Show("Please connect Instrument..","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        return;
                        //check = "true";
                        //PublicClass.checkpathstatus.Add("C:");
                        //PublicClass.checkpathstatus.Add("D:");
                    }
                }
                else
                { check = "true"; }
            }
        }

        bool DiStatus = false;
        private void ConnectwithINST()
        {
            DiStatus = false;
            byte[] arrFiveByte = { 0x05 };
            int BaudRR = 115200;
            try
            {
                string sComPortName = null;
                string[] sComPortName1 = SerialPort.GetPortNames();
                if (sComPortName1.Length > 1)
                {
                    sComPortName = sComPortName1[sComPortName1.Length - 1];
                }
                else
                {
                    sComPortName = sComPortName1[0];
                }
                if (!string.IsNullOrEmpty(sComPortName))
                {
                    m_objSerialPort = new SerialPort("COM1", BaudRR, Parity.None, 8, StopBits.One);
                    m_objSerialPort.Open();
                    m_objSerialPort.DtrEnable = true;
                    m_objSerialPort.RtsEnable = true;
                    m_objSerialPort.Write(arrFiveByte, 0, arrFiveByte.Length);
                    m_objSerialPort.Close();
                    DiStatus = true;
                }
            }
            catch
            { DiStatus = false; }
        }

        private void ConnectwithC911()
        {
            try
            {
                PublicClass.checkpathstatus = new List<string>();
                DriveInfo[] allDrives = DriveInfo.GetDrives();
                foreach (DriveInfo d in allDrives)
                {
                    if (d.IsReady && d.DriveType != DriveType.Fixed)
                    {
                        DiStatus = true;
                        string aa = d.Name;
                        string[] aa1 = aa.Split(new string[] { "\\" }, StringSplitOptions.RemoveEmptyEntries);
                        PublicClass.checkpathstatus.Add(aa1[0]);
                    }
                }
            }
            catch { DiStatus = false; }
        }


        bool bInstSelected = true;
        public bool IsInstrument
        {
            get
            {
                return bInstSelected;
            }
            set
            {
                bInstSelected = value;
            }
        }
        string sPathtoCopy = null;
        public string PathToUpLoad
        {
            get
            {
                return sPathtoCopy;
            }
            set
            {
                sPathtoCopy = value;
            }
        }

        public frmIAdeptMain MainForm
        {
            get
            {
                return _objMain;
            }

            set
            {
                _objMain = value;

            }
        }

        private string getSerialNo()
        {
            try
            {
                byte[] objbyte = new byte[32];
                byte[] objbytein = new byte[0];
                if (m_objRAPI.DevicePresent)
                {
                    m_objRAPI.Connect();
                    try
                    {
                        if (m_objRAPI.DeviceFileExists(@"\Windows\DI460RapiDLL.dll"))
                        {
                            m_objRAPI.DeleteDeviceFile(@"\Windows\DI460RapiDLL.dll");
                        }
                        m_objRAPI.CopyFileToDevice(AppDomain.CurrentDomain.BaseDirectory + "DI460RapiDLL.dll", @"\Windows\DI460RapiDLL.dll");
                    }
                    catch { }
                    m_objRAPI.Invoke(@"\Windows\DI460RapiDLL.dll", "DIGetSerialNumber", objbytein, out objbyte);
                    SerialKeyForImpaq = Encoding.ASCII.GetString(objbyte);
                    SerialKeyForImpaq = SerialKeyForImpaq.Trim('\0');
                }
            }
            catch { }
            return SerialKeyForImpaq;
        }
        //string serialKey = null;
        private string GetSrialKeyForImpaq()
        {
            try
            {
                string serialKey = null; string pathh = null;
                if (PublicClass.currentInstrument == "FieldPaq2")
                {
                    pathh = "\\Storage Card\\FieldpaqII\\App\\FieldpaqIIApp.ini";
                }
                else
                {
                    pathh = "\\Storage Card\\impaqElite\\App\\ImpaqEliteApp.ini";
                }
                string txtxfilepath = Path.GetTempPath() + @"serial.txt";
                try
                {
                    if (File.Exists(txtxfilepath))
                    {
                        File.WriteAllText(txtxfilepath, String.Empty);
                    }
                    else { }
                }
                catch { }
                m_objRAPI.CopyFileFromDevice(txtxfilepath, pathh, true);
                string[] lines = File.ReadAllLines(txtxfilepath);
                serialKey = lines[1];
                string[] serialKeyNew = serialKey.Split(new string[] { "=" }, StringSplitOptions.RemoveEmptyEntries);
                SerialKeyForImpaq = serialKeyNew[1];
                SerialKeyForImpaq = SerialKeyForImpaq.Trim();
            }
            catch { }
            return SerialKeyForImpaq;
        }
        //private string GetSrialKeyForImpaq()
        //{
        //    try
        //    {
        //        if (serialKey != null)
        //        {
        //            return serialKey;
        //        }
        //        string pathh = null;
        //        if (m_objRAPI.DevicePresent)
        //        {
        //            if (PublicClass.currentInstrument == "FieldPaq2")
        //            {
        //                pathh = "\\Storage Card\\FieldpaqII\\App\\FieldpaqIIApp.ini";
        //            }
        //            else
        //            {
        //                pathh = "\\Storage Card\\impaqElite\\App\\ImpaqEliteApp.ini";
        //            }
        //            string txtxfilepath = Path.GetTempPath() + @"serial.txt";
        //            try
        //            {
        //                if (File.Exists(txtxfilepath))
        //                {
        //                    File.WriteAllText(txtxfilepath, String.Empty);
        //                    //File.Delete(txtxfilepath);

        //                }
        //                m_objRAPI.CopyFileFromDevice(txtxfilepath, pathh, true);
        //            }
        //            catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
        //            //m_objRAPI.CopyFileFromDevice(txtxfilepath, pathh, true);
        //            string[] lines = File.ReadAllLines(txtxfilepath);

        //            serialKey = lines[1];
        //            string[] serialKeyNew = serialKey.Split(new string[] { "=" }, StringSplitOptions.RemoveEmptyEntries);
        //            SerialKeyForImpaq = serialKeyNew[1];
        //            SerialKeyForImpaq = SerialKeyForImpaq.Trim();
        //        }
        //        else { SerialKeyForImpaq = PublicClass.InstrumentSerial; }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message.ToString());
        //    }
        //    return SerialKeyForImpaq;
        //}

        //private string[] getSerialKeyforKohtect()
        //{
        //    try
        //    {
        //        string[] SerialKeyForKohtect = new string[3];
        //        string serialKey = null; string pathh = null;
        //        try {
        //            m_objRAPI.CopyFileFromDevice(txtxfilepath, pathh, true);
        //            string[] lines = File.ReadAllLines(txtxfilepath);
        //            serialKey = lines[1];
        //            string[] serialKeyNew = serialKey.Split(new string[] { "=" }, StringSplitOptions.RemoveEmptyEntries);
        //            SerialKeyForImpaq = serialKeyNew[1];
        //            SerialKeyForImpaq = SerialKeyForImpaq.Trim();
        //        }
        //        catch { }
        //        if (PublicClass.currentInstrument == "Kohtect-C911")
        //        {
        //            pathh = "\\Storage Card\\FieldpaqII\\App\\FieldpaqIIApp.ini";
        //        }
        //        else
        //        {
        //            pathh = "\\Storage Card\\impaqElite\\App\\ImpaqEliteApp.ini";
        //        }
        //        string txtxfilepath = Path.GetTempPath() + @"serial.txt";
        //        try
        //        {
        //            if (File.Exists(txtxfilepath))
        //            {
        //                File.WriteAllText(txtxfilepath, String.Empty);
        //            }
        //            else { }
        //        }
        //        catch { }

        //    }
        //    catch { }
        //    return SerialKeyForKohtect;
        //}

        internal void ShowMessage(string sMessage)
        {
            try
            {
                m_sMessage = sMessage;
                // this.Invoke(m_objToShowString);
            }
            catch (Exception ex)
            {
            }
        }

        private void btnupload_Click(object sender, EventArgs e)
        {
            _objMain.lblStatus.Caption = "Status: Uploading Route";

            bool chk = checkSerialKeyForInstrument(PublicClass.currentInstrument);
            if (PublicClass.currentInstrument == "Impaq-Benstone")
            {
                chk = true;
            }
            if (chk)
            {
                //objupdown = new frmupdownload();
                upload = new frmUpload();
                string text1 = null;
                string CurrentInstName = PublicClass.currentInstrument;
                try
                {
                    if (PublicClass.routename != null)
                    {
                        upload.SelectedRouteName = PublicClass.routename;
                        upload.ShowDialog();
                        IsInstrument = upload.IsInstrumentSelected;
                        if (CurrentInstName == "Kohtect-C911")
                        {
                            try
                            {
                                if (IsInstrument == false)
                                {
                                    PathToUpLoad = upload.PCPath;
                                    PublicClass.Path = PathToUpLoad;
                                }
                                else
                                {
                                    PathToUpLoad = upload.textBox1.Text;
                                    PublicClass.Path = PathToUpLoad;
                                }
                                if (upload.IsCancelClicked == false)
                                {
                                    SplashScreenManager.ShowForm(typeof(WaitForm3));
                                    bool testbool = false;
                                    string[] splitpath = PublicClass.Path.Split(new string[] { "\\" }, StringSplitOptions.RemoveEmptyEntries);
                                    DirectoryInfo obj = new DirectoryInfo(splitpath[0]);
                                    DirectoryInfo[] folders = obj.GetDirectories();
                                    if (folders.Length > 0)
                                    {
                                        for (int a = 0; a < folders.Length; a++)
                                        {
                                            if (PublicClass.routename == folders[a].ToString())
                                            {
                                                DialogResult Drslt = MessageBox.Show("Route Name Already Exist." + "\n" + "Do you want to Overrite?", "Route Transfer", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                                                if (Drslt == DialogResult.Yes)
                                                {
                                                    testbool = true;
                                                    DirectoryInfo dir = new DirectoryInfo(PublicClass.Path);
                                                    foreach (FileInfo files in dir.GetFiles())
                                                    {
                                                        files.Delete();
                                                    }
                                                    foreach (DirectoryInfo dirs in dir.GetDirectories())
                                                    {
                                                        dirs.Delete(true);
                                                    }
                                                    Directory.Delete(PublicClass.Path);
                                                }
                                            }
                                            else { testbool = true; }
                                        }
                                    }
                                    else { testbool = true; }
                                    if (testbool == true)
                                    {
                                        clsdb.Main = _objMain;
                                        clsdb.C911uploaddata(PublicClass.routename, PublicClass.Path);
                                        if (clsdb.check == "true")
                                        {
                                            _objMain.lblStatus.Caption = "Status: Uploading Route Successfully In Instrument";
                                            MessageBox.Show("Route Create Sucessfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            _objMain.ribbonControl1.Enabled = true;
                                            this.Enabled = true;
                                            this.Close();
                                        }
                                        else
                                        {
                                            MessageBox.Show("No point In Route", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                            _objMain.ribbonControl1.Enabled = true;
                                            this.Enabled = true;
                                            this.Close();
                                        }
                                    }
                                    SplashScreenManager.CloseForm();
                                }
                            }
                            catch { SplashScreenManager.CloseForm(); }
                        }
                        else if (CurrentInstName == "SKF/DI")
                        {
                            try
                            {
                                if (IsInstrument == false)
                                {
                                    PathToUpLoad = upload.PCPath;
                                    PublicClass.Path = PathToUpLoad;
                                }
                                else
                                {
                                    string path = Path.GetTempPath();
                                    text1 = upload.textBox1.Text;
                                    PathToUpLoad = path + PublicClass.routename + ".dat";
                                }
                                if (upload.IsCancelClicked == false)
                                {
                                    clsdb.Main = _objMain;
                                    _objMain.ribbonControl1.Enabled = false;
                                    this.Enabled = false;
                                    if (text1 == null)
                                    {
                                        clsdb.UsbSelected = true;
                                        clsdb.DIuploaddata(PublicClass.routename);
                                        if (clsdb.check == "true")
                                        {
                                            _objMain.lblStatus.Caption = "Status: Uploading Route Successfully In Instrument";
                                            MessageBox.Show("Route Create Sucessfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            SplashScreenManager.CloseForm();
                                            _objMain.ribbonControl1.Enabled = true;
                                            this.Enabled = true;
                                            this.Close();
                                        }
                                        else
                                        {
                                            MessageBox.Show("No point In Route", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                            SplashScreenManager.CloseForm();
                                            _objMain.ribbonControl1.Enabled = true;
                                            this.Enabled = true;
                                            this.Close();
                                        }
                                    }
                                    else
                                    {
                                        clsdb.DIuploaddata(PublicClass.routename);
                                        if (clsdb.check == "true")
                                        {
                                            _objMain.lblStatus.Caption = "Status: Uploading Route Successfully In Instrument";
                                            MessageBox.Show("Route Create Sucessfully In Instrument", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            //SplashScreenManager.CloseForm();
                                            _objMain.ribbonControl1.Enabled = true;
                                            this.Enabled = true;
                                            this.Close();
                                        }
                                        else
                                        {
                                            MessageBox.Show("No point In Route", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                            //SplashScreenManager.CloseForm();
                                            _objMain.ribbonControl1.Enabled = true;
                                            this.Enabled = true;
                                            this.Close();
                                        }
                                    }
                                }
                                else
                                {
                                    _objMain.lblStatus.Caption = "Status: Error";
                                    MessageBox.Show("Route not Created", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Enabled = true;
                                    _objMain.ribbonControl1.Enabled = true;
                                    this.Close();
                                }
                                SplashScreenManager.CloseForm();
                            }
                            catch { SplashScreenManager.CloseForm(); }
                        }
                        else
                        {
                            if (IsInstrument == false)
                            {
                                PathToUpLoad = upload.PCPath;
                            }
                            else
                            {
                                if (m_objRAPI.DevicePresent)
                                {
                                    m_objRAPI.Connect();
                                    string path = Path.GetTempPath();
                                    text1 = upload.textBox1.Text;
                                    PathToUpLoad = path + PublicClass.routename + ".sdf";
                                }
                                else
                                {
                                    SplashScreenManager.CloseForm();
                                    MessageBox.Show(this, "Device Not Connected....", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    return;
                                }
                            }
                            if (upload.IsCancelClicked == false)
                            {
                                _objMain.ribbonControl1.Enabled = false;
                                this.Enabled = false;
                                bool sStatus = CheckDemoSdf();
                                if (sStatus == true)
                                {
                                    if (text1 != null)
                                    {
                                        getRouteInformation(PublicClass.routename);
                                        UploadData _objupload = new UploadData();
                                        _objupload.Main = _objMain;
                                        _objupload.UploadValuesToBenstone();
                                        _objMain.lblStatus.Caption = "Status: Uploading Route";
                                        StartTheThread();
                                        _objMain.lblStatus.Caption = "Status: Uploading Route Successfully In Instrument";
                                        MessageBox.Show("Route Create Sucessfully In Instrument", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        _objMain.ribbonControl1.Enabled = true;
                                        this.Enabled = true;
                                    }
                                    else
                                    {
                                        getRouteInformation(PublicClass.routename);
                                        UploadData _objupload = new UploadData();
                                        _objupload.Main = _objMain;
                                        _objupload.UploadValuesToBenstone();
                                        _objMain.lblStatus.Caption = "Status: Uploading Route Successfully";
                                        MessageBox.Show("Route Create Sucessfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        _objMain.ribbonControl1.Enabled = true;
                                        this.Enabled = true;
                                    }
                                }
                                else
                                {
                                    _objMain.lblStatus.Caption = "Status: Error";
                                    MessageBox.Show("Route not Created", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Enabled = true;
                                    _objMain.ribbonControl1.Enabled = true;
                                    this.Close();
                                }
                            }
                            if (PublicClass.routename != null)
                            {
                                this.Close();
                            }
                            SplashScreenManager.CloseForm();
                        }
                    }
                }
                catch { SplashScreenManager.CloseForm(); }
            }
            else
            {
                //MessageBox.Show("please connect correct instrumnet !","Error", MessageBoxIcon.Error,MessageBoxButtons.OK);
            }
        }

        RAPI m_objRAPI ;//= new RAPI();
        private void StartTheThread()
        {
            try
            {
                try
                {
                    m_objRAPI.Connect();
                    if (m_objRAPI.DevicePresent)
                    {
                        if (PublicClass.currentInstrument == "Impaq-Benstone")
                        {
                            m_objRAPI.CopyFileToDevice(PathToUpLoad, @"\Storage Card\ImpaqElite" + CValues.SCONSTDCD + PublicClass.routename + CValues.SCONSTDBF, true);
                        }
                        else
                        { m_objRAPI.CopyFileToDevice(PathToUpLoad, @"\Storage Card\FieldpaqII" + CValues.SCONSTDCD + PublicClass.routename + CValues.SCONSTDBF, true); }
                    }
                }
                catch (Exception ex)
                {
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message, ex.StackTrace);
            }
        }

        OdbcCommand objCommand = null;
        OdbcDataReader objdataReader = null;
        private void getRouteInformation(string sRouteName)
        {
            string Uptime = null;
            string DnTime = null;
            string UpDn = null;
            OdbcDataReader objReader = null;
            try
            {
                _objMain.lblStatus.Caption = "Generating Route Information";
                DataTable dt = new DataTable();
                dt = DbClass.getdata(CommandType.Text, "select rdd.ID,rdd.Route_Name,rdd.Route_Level,rdd.DatabaseName,rdd.Date,rd1.Type_ID from route.route_data rdd inner join route.route_data1 rd1 on rdd.ID=rd1.ID where rdd.Route_Name='" + PublicClass.routename + "' order by ID asc");

                foreach (DataRow dr in dt.Rows)
                {
                    string id = Convert.ToString(dr["id"]);
                    string routename = Convert.ToString(dr["Route_Name"]);
                    string routelevel = Convert.ToString(dr["Route_Level"]);
                    string routelevelid = Convert.ToString(dr["Type_Id"]);
                    string databasename = Convert.ToString(dr["DatabaseName"]);
                    string date = Convert.ToString(dr["date"]);
                }

                string currdatabase = "use " + PublicClass.databasename;

            }
            catch (Exception ex)
            {
            }
        }

        string versionoption = "Elite";
        bool status = false;
        public bool CheckDemoSdf()
        {
            string[] sfilepath = PathToUpLoad.Split(new string[] { "\\" }, StringSplitOptions.RemoveEmptyEntries);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < sfilepath.Length - 1; i++)
            {
                sb.Append(Convert.ToString(sfilepath[i] + "\\"));
            }
            string filepath = Convert.ToString(sb);
            PublicClass.finalpath = Convert.ToString(PathToUpLoad).Trim();
            try
            {
                CreateSdfFile objsdfCrt = new CreateSdfFile();
                if (Directory.Exists(filepath))
                {
                    if (File.Exists(PathToUpLoad))
                    {
                        File.Delete(PathToUpLoad);
                    }
                    objsdfCrt.MainForm = _objMain;
                    objsdfCrt.CreateDatabaseInSdfFormat(versionoption);

                    status = true;
                }
                else
                {
                    Directory.CreateDirectory(filepath);
                    status = true;
                }
                //CreateSdfFile objsdfCrt = new CreateSdfFile();
                //if (Directory.Exists(filepath))
                //{
                //    if (File.Exists(PathToUpLoad))
                //    {
                //        File.Delete(PathToUpLoad);
                //    }
                //    objsdfCrt.MainForm = _objMain;
                //    objsdfCrt.CreateDatabaseInSdfFormat(versionoption);
                //    try
                //    {
                //        File.Copy("c:\\demo.sdf", PathToUpLoad);
                //    }
                //    catch
                //    { }
                //    status = true;
                //}
                //else
                //{
                //    Directory.CreateDirectory(filepath);
                //    status = true;
                //}
            }
            catch (Exception ex)
            {
                status = false;
            }
            return status;
        }

        ClsSdftodb clsdb = new ClsSdftodb();
        private void btndownload_Click(object sender, EventArgs e)
        {
            _objMain.lblStatus.Caption = "Status: Start to Download Data From Instrument";
            download = new frmdownload();
            string CurrentInstName = PublicClass.currentInstrument;
            try
            {
                if (CurrentInstName == "SKF/DI")
                {
                    clsdb.Main = _objMain;
                    clsdb.callconnection();
                    this.Close();
                }
                else if (CurrentInstName == "Kohtect-C911")
                {
                    clsdb.Main = _objMain;
                    clsdb.C911callconnection();
                    this.Close();
                }
                else
                {
                    UploadData down = new UploadData();
                    down.Main = _objMain;
                    down.CallCheckConnections();
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show(this, "Error in Download", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool checkSerialKeyForInstrument(string Instrumentname)
        {
            bool status = false;
            try
            {
                if (PublicClass.currentInstrument == "Impaq-Benstone")
                {
                    string key = GetSrialKeyForImpaq();
                    if (key != null)
                    {
                        status = true;
                    }
                }
                else if (PublicClass.currentInstrument == "Kohtect-C911")
                {
                    DriveInfo[] allDrives = DriveInfo.GetDrives();
                    foreach (DriveInfo d in allDrives)
                    {
                        if (d.IsReady && d.DriveType != DriveType.Fixed)
                        {
                            if (d.VolumeLabel == "C911_2MB" || d.VolumeLabel == "C911_2GB")
                            {
                                string aa = d.Name;
                                string fileName = "License File.pdf";

                                if (d.VolumeLabel == "C911_2MB")
                                {
                                    string path = aa + fileName;
                                    string lines = File.ReadAllText(path);
                                    string data = GetTextFromPDF(path);
                                    string[] serialKeyNew = data.Split(new string[] { "\n", ":" }, StringSplitOptions.RemoveEmptyEntries);
                                    string companyName = Convert.ToString(serialKeyNew[1]);
                                    DataTable dt = DbClass.getdata(CommandType.Text, "Select * FROM route.tbllicense where InstrumentName ='" + Instrumentname + "' and CompanyName ='" + companyName + "'");
                                    foreach (DataRow dr in dt.Rows)
                                    {
                                        if (Convert.ToString(dr["LicenseKey"]) == Convert.ToString(serialKeyNew[5]))
                                        {
                                            PublicClass.InstrumentSerial = Convert.ToString(dr["LicenseKey"]);
                                            status = true;
                                        }
                                    }
                                    string text = System.IO.File.ReadAllText(path);
                                }
                                if (d.VolumeLabel == "C911_2GB")
                                {
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return status;
        }

        private string GetTextFromPDF(string path)
        {
            StringBuilder text = new StringBuilder();
            using (iTextSharp.text.pdf.PdfReader reader = new iTextSharp.text.pdf.PdfReader(path))
            {
                for (int i = 1; i <= reader.NumberOfPages; i++)
                {
                    text.Append(iTextSharp.text.pdf.parser.PdfTextExtractor.GetTextFromPage(reader, i));
                }
            }

            return text.ToString();
        }
    }
}