﻿using Iadeptmain.GlobalClasses;
using Iadeptmain.Mainforms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iadeptmain.Classes
{
    public class clsC911
    {
        frmIAdeptMain _objMain;
        ResizeArray_Interface _ResizeArray = new ResizeArray_Control();
        public static string connval = "";
        public string sPathtosave = null;
        public string PCPath
        {
            get
            {
                return sPathtosave;
            }
            set
            {
                sPathtosave = value;
            }
        }
        public frmIAdeptMain Main
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

        double[] XData = null;
        double[] YData = null;
        string[] PhaseChnl1 = null;
        double[] PhaseChnl2 = null;
        double[] RealVal = null;
        double[] ImageVal = null;
        double[] YData_A = null;
        double[] YData_V = null;
        double[] YData_S = null;

        double[] XData2 = null;
        double[] YData2 = null;
        double[] YData_A2 = null;
        double[] YData_V2 = null;
        double[] YData_S2 = null;

        float RMS_A = 0;
        float RMS_V = 0;
        float RMS_S = 0;
        bool Is2Channel = false;
        public bool _Is2Channel
        {
            get
            {
                return Is2Channel;
            }
        }

        float RMS = 0;
        public float _RMS
        {
            get
            {
                return RMS;
            }
            set
            {
                RMS = value;
            }
        }

        float RMS2 = 0;
        public float _RMS2
        {
            get
            {
                return RMS2;
            }
            set
            {
                RMS2 = value;
            }
        }

        float P_P = 0;
        public float _P_P
        {
            get
            {
                return P_P;
            }
            set
            {
                P_P = value;
            }
        }

        float P_P2 = 0;
        public float _P_P2
        {
            get
            {
                return P_P2;
            }
            set
            {
                P_P2 = value;
            }
        }
        double dF = 0;
        public double _dF
        {
            get
            {
                return dF;
            }
            set
            {
                dF = value;
            }
        }

        int Window = 0;
        public int _Window
        {
            get
            {
                return Window;
            }
            set
            {
                Window = value;
            }
        }

        int Window2 = 0;
        public int _Window2
        {
            get
            {
                return Window2;
            }
            set
            {
                Window2 = value;
            }
        }

        int pwr2 = 0;
        public int _pwr2
        {
            get
            {
                return pwr2;
            }
            set
            {
                pwr2 = value;
            }
        }

        int Measurement = 0;
        public int _Measurement
        {
            get
            {
                return Measurement;
            }
            set
            {
                Measurement = value;
            }
        }

        int Measurement2 = 0;
        public int _Measurement2
        {
            get
            {
                return Measurement2;
            }
            set
            {
                Measurement2 = value;
            }
        }

        int ChnlA = 0;
        public int _ChnlA
        {
            get
            {
                return ChnlA;
            }
            set
            {
                ChnlA = value;
            }
        }

        int ChnlB = 0;
        public int _ChnlB
        {
            get
            {
                return ChnlB;
            }
            set
            {
                ChnlB = value;
            }
        }



        int Trig = 0;
        public int _Trig
        {
            get
            {
                return Trig;
            }
            set
            {
                Trig = value;
            }
        }

        int Avgm = 0;
        public int _Avgm
        {
            get
            {
                return Avgm;
            }
            set
            {
                Avgm = value;
            }
        }


        int Navg = 0;
        public int _Navg
        {
            get
            {
                return Navg;
            }
            set
            {
                Navg = value;
            }
        }

        int EPC = 0;
        public int _EPC
        {
            get
            {
                return EPC;
            }
            set
            {
                EPC = value;
            }
        }

        enum ampmode { Mode_A, Mode_V, Mode_S, Mode_E };
        int Ampmode = 0;
        public int _Ampmode
        {
            get
            {
                return Ampmode;
            }
            set
            {
                Ampmode = value;
            }
        }

        int Ampmode2 = 0;
        public int _Ampmode2
        {
            get
            {
                return Ampmode2;
            }
            set
            {
                Ampmode2 = value;
            }
        }

        int Amphpf = 0;
        public int _Amphpf
        {
            get
            {
                return Amphpf;
            }
            set
            {
                Amphpf = value;
            }
        }

        int Amphpf2 = 0;
        public int _Amphpf2
        {
            get
            {
                return Amphpf2;
            }
            set
            {
                Amphpf2 = value;
            }
        }

        enum ampenvcr { KTu_2, KTu_4, KTu_8, KTu_16, KTu_32 };
        int Ampenvcr = 0;
        public int _Ampenvcr
        {
            get
            {
                return Ampenvcr;
            }
            set
            {
                Ampenvcr = value;
            }
        }

        int Ampenvcr2 = 0;
        public int _Ampenvcr2
        {
            get
            {
                return Ampenvcr2;
            }
            set
            {
                Ampenvcr2 = value;
            }
        }

        float Sens = 0;
        public float _Sens
        {
            get
            {
                return Sens;
            }
            set
            {
                Sens = value;
            }
        }

        float Sens2 = 0;
        public float _Sens2
        {
            get
            {
                return Sens2;
            }
            set
            {
                Sens2 = value;
            }
        }

        ulong SerialN = 0;
        public ulong _SerialN
        {
            get
            {
                return SerialN;
            }
            set
            {
                SerialN = value;
            }
        }

        int Revision = 0;
        public int _Revision
        {
            get
            {
                return Revision;
            }
            set
            {
                Revision = value;
            }
        }

        public string[] sSplittedValue = null; public string filedate = null;
        public void datatransfer(string Dbname, string filepath)
        {
            try
            {
                sSplittedValue = filepath.Split(new char[] { '\\', '.' });
                filedate = File.GetCreationTime(filepath).ToString();
                string name = "DefaultPlant";
                InsertItemsInDataBase("Plant", null, name + "|" + "Plant");
                InsertItemsInDataBase("Area", facid, "Area" + "|" + "Area");
                InsertItemsInDataBase("Train", facid, "Train" + "|" + "Train");
                InsertItemsInDataBase("Machine", facid, "Machine" + "|" + "Machine");
                InsertItemsInDataBase("Point", facid, sSplittedValue[sSplittedValue.Length - 2] + "|" + "Point");
                MDConvertPointType(NewID);
                GenerateNewRouteFromFile(filepath, filedate);
            }
            catch { }
        }
        //public void datatransfer(string Dbname, string filepath,string fullpath)
        //{
        //    try
        //    {
        //        sSplittedValue = filepath.Split(new char[] { '\\', '.', ',' });
        //        filedate = File.GetCreationTime(filepath).ToString();
        //        //filedate = File.GetCreationTime(fullpath+"\\"+filepath).ToString();
        //        string name = "DefaultPlant";
        //        InsertItemsInDataBase("Plant", null, name + "|" + "Plant");
        //        InsertItemsInDataBase("Area", facid, "Area" + "|" + "Area");
        //        InsertItemsInDataBase("Train", facid, "Train" + "|" + "Train");
        //        InsertItemsInDataBase("Machine", facid, "Machine" + "|" + "Machine");
        //        for (int p = 0; p < sSplittedValue.Length; p++)
        //        {
        //            filepath = sSplittedValue[p];
        //            InsertItemsInDataBase("Point", facid, filepath + "|" + "Point");                    
        //            string mergepath = fullpath + "\\" + filepath + ".fft";
        //            GenerateNewRouteFromFile(mergepath, filedate);
        //            MDConvertPointType(NewID);
        //            p++;
        //        }
        //    }
        //    catch { }
        //}

        public void datatransfer(string Dbname, string areaname, string trainname, string machinename, string filepath)
        {
            try
            {
                string name = "DefaultPlant";
                InsertItemsInDataBase("Plant", null, name + "|" + "Plant");
                InsertItemsInDataBase("Area", facid, areaname + "|" + "Area");
                InsertItemsInDataBase("Train", facid, trainname + "|" + "Train");
                InsertItemsInDataBase("Machine", facid, machinename + "|" + "Machine");
                if (filepath != null)
                {
                    GenerateNewRouteFromFile(filepath);
                }
            }
            catch { }
        }

        public string facid = null; public string NewID = null;
        public void InsertItemsInDataBase(string sNodeType, string sParentID, string sDescription)
        {
            try
            {
                if (sNodeType != "" && sParentID != "" && sDescription != "")
                {
                    string[] sSplittedValue = sDescription.Split(new char[] { '|' });
                    string sFactoryName = sSplittedValue[0];
                    string sFactoryDescription = sSplittedValue[1];
                    if (sNodeType == "Plant")
                    {
                        try
                        {
                            string facName = sFactoryName;
                            int hyPreviousID = 0;
                            int hyNextId = 0;
                            DbClass.executequery(CommandType.Text, "Insert into factory_info(Name,Description,DateCreated,PreviousID,NextID) values('" + facName + "','Plant','" + PublicClass.GetDatetime() + "','" + hyPreviousID + "','" + hyNextId + "')");
                            DataTable dtfacfinal = DbClass.getdata(CommandType.Text, "Select max(factory_id) from factory_info ");
                            hyPreviousID = (Convert.ToInt32(PublicClass.DefVal(Convert.ToString(dtfacfinal.Rows[0][0]), "0"))) - 1;
                            hyNextId = (Convert.ToInt32(PublicClass.DefVal(Convert.ToString(dtfacfinal.Rows[0][0]), "0"))) + 1;
                            DbClass.executequery(CommandType.Text, "Update factory_info set PreviousID = '" + hyPreviousID + "',NextID='" + hyNextId + "' where factory_id = '" + Convert.ToString(dtfacfinal.Rows[0][0]) + "'");
                            facid = Convert.ToString(dtfacfinal.Rows[0][0]);
                        }
                        catch
                        { }
                    }
                    else if (sNodeType == "Area")
                    {
                        string AreaName = sFactoryName;
                        string facid1 = facid;
                        int PreviousID = 0;
                        int NextId = 0;
                        DbClass.executequery(CommandType.Text, "Insert into area_info(Name,Description,FactoryID,PreviousID,NextID,DateCreated) values('" + AreaName + "','Area','" + facid1 + "','" + PreviousID + "','" + NextId + "','" + PublicClass.GetDatetime() + "')");
                        DataTable dtareafinal = DbClass.getdata(CommandType.Text, "Select max(Area_ID) from area_info ");
                        PreviousID = (Convert.ToInt32(PublicClass.DefVal(Convert.ToString(dtareafinal.Rows[0][0]), "0"))) - 1;
                        NextId = (Convert.ToInt32(PublicClass.DefVal(Convert.ToString(dtareafinal.Rows[0][0]), "0"))) + 1;
                        DbClass.executequery(CommandType.Text, "Update area_info set PreviousID = '" + PreviousID + "',NextID='" + NextId + "' where Area_ID = '" + Convert.ToString(dtareafinal.Rows[0][0]) + "'");
                        facid = Convert.ToString(dtareafinal.Rows[0][0]);
                    }
                    else if (sNodeType == "Train")
                    {
                        string AreaName = sFactoryName;
                        string facid2 = facid;
                        int PreviousID = 0;
                        int NextId = 0;
                        DbClass.executequery(CommandType.Text, "Insert into train_info(Name,Description,PreviousID,NextID,Area_ID,Date) values('" + AreaName + "','Train','" + PreviousID + "','" + NextId + "','" + facid2 + "','" + PublicClass.GetDatetime() + "')");
                        DataTable dtTrainfinal = DbClass.getdata(CommandType.Text, "Select max(Train_ID) from train_info ");
                        PreviousID = (Convert.ToInt32(PublicClass.DefVal(Convert.ToString(dtTrainfinal.Rows[0][0]), "0"))) - 1;
                        NextId = (Convert.ToInt32(PublicClass.DefVal(Convert.ToString(dtTrainfinal.Rows[0][0]), "0"))) + 1;
                        DbClass.executequery(CommandType.Text, "Update train_info set PreviousID = '" + PreviousID + "',NextID='" + NextId + "' where Train_ID = '" + Convert.ToString(dtTrainfinal.Rows[0][0]) + "'");
                        facid = Convert.ToString(dtTrainfinal.Rows[0][0]);
                    }
                    else if (sNodeType == "Machine")
                    {
                        string AreaName = sFactoryName;
                        string facid3 = facid;
                        int PreviousID = 0;
                        int NextId = 0;
                        DbClass.executequery(CommandType.Text, "Insert into machine_info(Name,Description,PreviousID,NextID,TrainID,DateCreated,RPM_Driven,PulseRev) values('" + sFactoryName + "','Machine','" + PreviousID + "','" + NextId + "','" + facid3 + "','" + PublicClass.GetDatetime() + "','1800','1')");
                        DataTable dtmacfinal = DbClass.getdata(CommandType.Text, "Select max(Machine_ID) from machine_info ");
                        PreviousID = (Convert.ToInt32(PublicClass.DefVal(Convert.ToString(dtmacfinal.Rows[0][0]), "0"))) - 1;
                        NextId = (Convert.ToInt32(PublicClass.DefVal(Convert.ToString(dtmacfinal.Rows[0][0]), "0"))) + 1;
                        DbClass.executequery(CommandType.Text, "Update machine_info set PreviousID = '" + PreviousID + "',NextID='" + NextId + "' where Machine_ID = '" + Convert.ToString(dtmacfinal.Rows[0][0]) + "'");
                        facid = Convert.ToString(dtmacfinal.Rows[0][0]);
                    }
                    else if (sNodeType == "Point")
                    {
                        string prID = facid;
                        int PreviousID = 0;
                        int NextId = 0;
                        DbClass.executequery(CommandType.Text, "Insert into point(PointName,PointDesc,DataCreated,PreviousID,NextID,Machine_ID,DataSchedule,PointStatus,PointSchedule) values('" + sFactoryName + "','Point','" + PublicClass.GetDatetime() + "','" + PreviousID + "','" + NextId + "','" + prID + "','7','0','1')");
                        DataTable dtpointfinal = DbClass.getdata(CommandType.Text, "Select max(Point_ID) from point ");
                        PreviousID = (Convert.ToInt32(PublicClass.DefVal(Convert.ToString(dtpointfinal.Rows[0][0]), "0"))) - 1;
                        NextId = (Convert.ToInt32(PublicClass.DefVal(Convert.ToString(dtpointfinal.Rows[0][0]), "0"))) + 1;
                        DbClass.executequery(CommandType.Text, "Update point set PreviousID = '" + PreviousID + "',NextID='" + NextId + "',PointType_ID='0' where Point_ID = '" + Convert.ToString(dtpointfinal.Rows[0][0]) + "'");
                        NewID = Convert.ToString(dtpointfinal.Rows[0][0]);
                    }
                }
            }
            catch { }
        }

        public void GenerateNewRouteFromFile(string FilePath)
        {
            try
            {
                using (FileStream objInput = new FileStream(FilePath, FileMode.Open, FileAccess.Read))
                {
                    byte[] MainArr = new byte[(int)objInput.Length];
                    int contents = objInput.Read(MainArr, 0, (int)objInput.Length);
                    ExtractOffDataDiForUsb(MainArr);
                }
            }
            catch { }
        }

        public string untypeid = null;
        public void MDConvertPointType(string pointid)
        {
            try
            {
                string instname = PublicClass.currentInstrument;
                DataTable dtpoint = DbClass.getdata(CommandType.Text, "select max(ID)typepoint_id from Type_point");
                foreach (DataRow drsen in dtpoint.Rows)
                {
                    untypeid = Convert.ToString(PublicClass.DefVal(Convert.ToString(drsen["typepoint_id"]), "0")) + 1;
                    string AlarmID = "0";
                    string sdID = "0";
                    string perID = "0";
                    string PointTypeName = Convert.ToString(sSplittedValue[sSplittedValue.Length - 2] + "-" + untypeid);
                    DbClass.executequery(CommandType.Text, "Insert into type_point(Point_Name,Type_ID,Instrumentname,Alarm_ID,STDDeviationAlarm_ID,Percentage_AlarmID,Band_ID) values('" + PointTypeName + "','1','" + instname + "','" + AlarmID + "','" + sdID + "','" + perID + "','0')");

                    DataTable dt1 = DbClass.getdata(CommandType.Text, "select distinct ID from type_point where Point_name='" + PointTypeName + "'");
                    foreach (DataRow dr1 in dt1.Rows)
                    {
                        untypeid = (Convert.ToString(dr1["ID"]));
                    }
                }
                try
                {
                    int envno = 0, resolutionNO = 0, fminNO = 0, fmaxNO = 0;
                    int channel1 = _ChnlA;
                    int channel2 = _ChnlB;
                    int ampch1 = _Ampmode;
                    int ampch2 = _Ampmode2;
                    int env = _Ampenvcr;
                    if (env == 2)
                    {
                        envno = 0;
                    }
                    else if (env == 4)
                    {
                        envno = 1;
                    }
                    else if (env == 8)
                    {
                        envno = 2;
                    }
                    else if (env == 16)
                    {
                        envno = 3;
                    }
                    else if (env == 32)
                    {
                        envno = 4;
                    }
                    int windowtype = _Window;
                    int resolution = Number_Of_Spectrum;
                    if (resolution == 100)
                    { resolutionNO = 0; }
                    if (resolution == 200)
                    { resolutionNO = 1; }
                    if (resolution == 400)
                    { resolutionNO = 2; }
                    if (resolution == 800)
                    { resolutionNO = 3; }
                    if (resolution == 1600)
                    { resolutionNO = 4; }
                    if (resolution == 3200)
                    { resolutionNO = 5; }
                    if (resolution == 6400)
                    { resolutionNO = 6; }

                    int fmin = _Amphpf;
                    if (fmin == 2)
                    {
                        fminNO = 0;
                    }
                    else if (fmin == 10)
                    { fminNO = 1; }

                    decimal fmax = Convert.ToInt32(HighestFrequency);
                    fmaxNO = Convert.ToInt32(Math.Round(fmax));
                    List<int> list = new List<int> { 125, 200, 300, 400, 500, 600, 700, 800, 900, 1000, 2000, 3000, 4000, 5000, 6000, 7000, 8000, 9000, 10000, 11000, 12000, 13000, 14000, 15000, 16000, 17000, 18000, 19000, 20000, 21000, 22000, 23000, 24000, 25000, 26000, 27000, 28000, 29000, 30000, 31000, 32000, 33000, 34000, 35000, 36000, 37000 };
                    int number = fmaxNO;//1000;//fmaxNO
                    int closest = list.Aggregate((x, y) => Math.Abs(x - number) < Math.Abs(y - number) ? x : y);
                    int i = list.IndexOf(closest);
                    fmaxNO = i;

                    int start = _Trig;
                    int averagingMode = _Avgm;
                    int averagingnumber = 2;//_Navg;

                    try
                    {
                        DbClass.executequery(CommandType.Text, "insert Into c911_measurement(type_id,Channel1,SelectRadio1,EV_Frequency,Channel2,SelectRadio2,Spectrum_LineNo,Window_Type,Fmin,Fmax,Trigger_Mode,Avg_Mode,N,Comments) values('" + untypeid + "','" + channel1 + "','" + _Ampmode + "','" + envno + "', '" + channel2 + "','" + _Ampmode + "', '" + resolutionNO + "','" + windowtype + "','" + fminNO + "','" + fmaxNO + "','" + start + "','" + averagingMode + "','" + averagingnumber + "','')");
                        DbClass.executequery(CommandType.Text, "update point set pointtype_id='" + untypeid + "' where point_id='" + NewID + "'");
                        if (directdownload == false)
                        {
                            DbClass.executequery(CommandType.Text, "update point_data set Point_Type='" + untypeid + "' where point_id='" + NewID + "'");
                        }
                    }
                    catch { }
                }
                catch { }
            }
            catch { }

        }

        public void MDConvertPointType(string pointid, string filename)
        {
            try
            {
                string instname = PublicClass.currentInstrument;
                DataTable dtpoint = DbClass.getdata(CommandType.Text, "select max(ID)typepoint_id from Type_point");
                foreach (DataRow drsen in dtpoint.Rows)
                {
                    untypeid = Convert.ToString(PublicClass.DefVal(Convert.ToString(drsen["typepoint_id"]), "0")) + 1;
                    string AlarmID = "0";
                    string sdID = "0";
                    string perID = "0";
                    string PointTypeName = Convert.ToString(filename + "-" + untypeid);
                    DbClass.executequery(CommandType.Text, "Insert into type_point(Point_Name,Type_ID,Instrumentname,Alarm_ID,STDDeviationAlarm_ID,Percentage_AlarmID,Band_ID) values('" + PointTypeName + "','1','" + instname + "','" + AlarmID + "','" + sdID + "','" + perID + "','0')");

                    DataTable dt1 = DbClass.getdata(CommandType.Text, "select distinct ID from type_point where Point_name='" + PointTypeName + "'");
                    foreach (DataRow dr1 in dt1.Rows)
                    {
                        untypeid = (Convert.ToString(dr1["ID"]));
                    }
                }
                try
                {
                    DbClass.executequery(CommandType.Text, "insert Into c911_measurement(type_id,Channel1,SelectRadio1,EV_Frequency,Channel2,SelectRadio2,Spectrum_LineNo,Window_Type,Fmin,Fmax,Trigger_Mode,Avg_Mode,N,Comments) values('" + untypeid + "','" + ChnlA + "','" + Measurement + "','" + Ampenvcr + "', '" + ChnlB + "','" + Measurement2 + "', '" + Number_Of_Spectrum + "','" + Window + "','" + dF + "','" + HighestFrequency + "','" + Trig + "','" + Avgm + "','" + Navg + "','')");
                    DbClass.executequery(CommandType.Text, "update point set pointtype_id='" + untypeid + "' where point_id='" + NewID + "'");
                }
                catch { }
            }
            catch { }

        }




        public void GenerateNewRouteFromFile(string FilePath, string filedate)
        {
            try
            {
                using (FileStream objInput = new FileStream(FilePath, FileMode.Open, FileAccess.Read))
                {
                    byte[] MainArr = new byte[(int)objInput.Length];
                    int contents = objInput.Read(MainArr, 0, (int)objInput.Length);
                    if (Directory.Exists("c:\\vvtemp\\"))
                    {
                        Directory.Delete("c:\\vvtemp\\", true);
                    }
                    ExtractData(MainArr);
                    string[] arrFilePath = FilePath.ToString().Split(new string[] { "\\", ".fft" }, StringSplitOptions.RemoveEmptyEntries);

                    //CalculateAllData();
                    //string Value_Y = Retrive_YxValue(MainArr, 248);
                    READFFTFILE();

                }
            }
            catch { }
        }

        public bool directdownload = false;
        public string v_point_id = null, v_point_name = null, v_Point_Type = null;
        public void READFFTFILE()
        {
            StringBuilder DataXY = new StringBuilder();
            StringBuilder DataXY2 = new StringBuilder();
            StringBuilder DataX = new StringBuilder();
            StringBuilder DataY = new StringBuilder();
            StringBuilder DataX2 = new StringBuilder();
            StringBuilder DataY2 = new StringBuilder();
            ArrayList arlNewTime = new ArrayList();
            string XYFinalData = null; double overallVal = 0.0;
            string ValueX = ""; string ValueY = "";
            string XY2FinalData = null;
            string ValueX2 = ""; string ValueY2 = "";
            string[] sarrXTData = new string[0];
            try
            {
                if (sSplittedValue[sSplittedValue.Length - 1] == "fft")
                {
                    DataXY.Append("0|0,");
                    DataX.Append("0");
                    DataX.Append("|");
                    DataY.Append("0");
                    DataY.Append("|");
                    for (int i = 1; i < XData.Length; i++)
                    {
                        DataXY.Append(Convert.ToString(XData[i]));
                        DataXY.Append("|");
                        DataX.Append(Convert.ToString(XData[i]));
                        DataX.Append("|");
                        DataXY.Append(Convert.ToString(YData[i]));
                        DataXY.Append(",");
                        DataY.Append(Convert.ToString(YData[i]));
                        DataY.Append("|");
                    }
                    XYFinalData = Convert.ToString(DataXY);
                    ValueX = Convert.ToString(DataX);
                    ValueY = Convert.ToString(DataY);

                    //////////////////////////////////Changes by Vimal for Channel2 data for Y-axis//////////////////////////
                    if (Is2Channel)
                    {
                        DataXY2.Append("0|0,");
                        DataX2.Append("0");
                        DataX2.Append("|");
                        DataY2.Append("0");
                        DataY2.Append("|");
                        for (int i = 1; i < XData.Length; i++)
                        {
                            DataXY2.Append(Convert.ToString(XData[i]));
                            DataXY2.Append("|");
                            DataX2.Append(Convert.ToString(XData[i]));
                            DataX2.Append("|");
                            DataXY2.Append(Convert.ToString(YData2[i]));
                            DataXY2.Append(",");
                            DataY2.Append(Convert.ToString(YData2[i]));
                            DataY2.Append("|");
                        }
                    }
                    XY2FinalData = Convert.ToString(DataXY2);
                    ValueX2 = Convert.ToString(DataX2);
                    ValueY2 = Convert.ToString(DataY2);
                    /////////////////////////////////////////////////////////////////////////////////////////////////////////


                    try
                    {
                        if (directdownload == false)
                        {
                            v_point_id = NewID;
                            v_point_name = sSplittedValue[sSplittedValue.Length - 2];
                            v_Point_Type = untypeid;
                        }
                        string v_measure_time = Convert.ToDateTime(filedate).ToString("yyyy-MM-dd HH:mm:ss");
                        string v_accel_ch1 = "0";
                        string v_accel_a = "0";
                        string v_accel_h = "0";
                        string v_accel_v = "0";
                        string v_vel_ch1 = "0";
                        string v_vel_a = "0";
                        string v_vel_h = "0";
                        string v_vel_v = "0";
                        string v_displ_ch1 = "0";
                        string v_displ_a = "0";
                        string v_displ_h = "0";
                        string v_displ_v = "0";
                        string v_crest_factor_ch1 = "0";
                        string v_crest_factor_a = "0";
                        string v_crest_factor_h = "0";
                        string v_crest_factor_v = "0";
                        string v_bearing_ch1 = "0";
                        string v_bearing_a = "0";
                        string v_bearing_h = "0";
                        string v_bearing_v = "0";
                        string v_ordertrace_ch1_real = "0";
                        string v_ordertrace_ch1_image = "0";
                        string v_ordertrace_a_real = "0";
                        string v_ordertrace_a_image = "0";
                        string v_ordertrace_h_real = "0";
                        string v_ordertrace_h_image = "0";
                        string v_ordertrace_v_real = "0";
                        string v_ordertrace_v_image = "0";
                        string v_ordertrace_rpm = "0";

                        string v_time_a_X = "0|"; string v_time_a_Y = "";
                        string v_time_h_X = "0|"; string v_time_h_Y = "";
                        string v_time_v_X = "0|"; string v_time_v_Y = "";
                        string v_time_CH1_X = "0|"; string v_time_CH1_Y = "";

                        string v_power_a_X = "0|"; string v_power_a_Y = "";
                        string v_power_h_X = "0|"; string v_power_h_Y = "";
                        string v_power_v_X = "0|"; string v_power_v_Y = "";
                        string v_power_Ch1_X = "0|"; string v_power_Ch1_Y = "";

                        try
                        {
                            if (directdownload == true)
                            {
                                DataTable dt4 = DbClass.getdata(CommandType.Text, "select mea.* from point pt inner join type_point tp on pt.PointType_ID=tp.id left join c911_measurement mea on mea.type_id=tp.ID where pt.point_ID='" + v_point_id + "'");
                                if (dt4.Rows.Count > 0)
                                {
                                    string channel1 = Convert.ToString(dt4.Rows[0]["Channel1"]);
                                    string selectratio = Convert.ToString(dt4.Rows[0]["SelectRadio1"]);
                                    string channel2 = Convert.ToString(dt4.Rows[0]["Channel2"]);
                                    string selectratio2 = Convert.ToString(dt4.Rows[0]["SelectRadio2"]);
                                    if (Is2Channel)
                                    {
                                        if (channel2 == "0" || channel2 == "1" || channel2 == "2")
                                        {
                                            if (selectratio2 == "0")
                                            {
                                                v_accel_v = Convert.ToString(RMS2);
                                                v_power_v_X = Convert.ToString(DataX2);
                                                v_power_v_Y = Convert.ToString(DataY2);
                                            }
                                            else if (selectratio2 == "1")
                                            {
                                                v_vel_v = Convert.ToString(RMS2);
                                                v_power_v_X = Convert.ToString(DataX2);
                                                v_power_v_Y = Convert.ToString(DataY2);
                                            }
                                            else if (selectratio2 == "2")
                                            {
                                                v_displ_v = Convert.ToString(RMS2);
                                                v_power_v_X = Convert.ToString(DataX2);
                                                v_power_v_Y = Convert.ToString(DataY2);
                                            }
                                        }
                                    }
                                    if (channel1 == "0" || channel1 == "1" || channel1 == "2")
                                    {
                                        if (selectratio == "0")
                                        {
                                            v_accel_h = Convert.ToString(RMS);
                                        }
                                        else if (selectratio == "1")
                                        {
                                            v_vel_h = Convert.ToString(RMS);
                                        }
                                        else if (selectratio == "2")
                                        {
                                            v_displ_h = Convert.ToString(RMS);
                                        }
                                        else
                                        {
                                            v_crest_factor_h = Convert.ToString(RMS);
                                        }
                                        v_power_h_X = Convert.ToString(DataX);
                                        v_power_h_Y = Convert.ToString(DataY);
                                        DbClass.executequery(CommandType.Text, "insert into point_data (Point_ID,Point_name, Point_Type,  Measure_time,  accel_a,  accel_h,    accel_v,accel_ch1, vel_a,        vel_h, vel_v, vel_ch1,      displ_a,   displ_h,    displ_v, displ_ch1,crest_factor_a,    crest_factor_h,    crest_factor_v,   crest_factor_ch1 ,          bearing_a,       bearing_h,  bearing_v,  bearing_ch1,        ordertrace_a_real,   ordertrace_h_real,  ordertrace_v_real ,ordertrace_ch1_real ,     ordertrace_a_image,   ordertrace_h_image,    ordertrace_v_image, ordertrace_ch1_image,   ordertrace_rpm,    TimeA_X,     timeH_X,     timeV_X,timeCH1_X,       PA_X, PH_X,    PV_X,  PCH1_X,    P1A_X, P1H_X,  P1V_X,   P1CH1_X,   P2A_X,   P2H_X,   P2V_X,  P2CH1_X,     P21A_X,  P21H_X,  P21V_X,  P21CH1_X,  P3A_X,  P3H_X, P3V_X,  P3CH1_X,   P31A_X,   P31H_X,  P31V_X,  P31CH1_X,   CEPA_X,    CEPH_X,  CEPV_X, CEPCH1_X,    DEMA_X,   DEMH_X, DEMV_X, DEMCH1_X,      timeA_Y,        timeH_Y,     timeV_Y,    timeCH1_Y,     PA_Y,     PH_Y,    PV_Y,    PCH1_Y,P1A_Y,P1H_Y,P1V_Y,P1CH1_Y,P2A_Y,P2H_Y,P2V_Y,P2CH1_Y,P21A_Y,P21H_Y,P21V_Y,P21CH1_Y,P3A_Y,P3H_Y,P3V_Y,P3CH1_Y,P31A_Y,P31H_Y,P31V_Y,P31CH1_Y,CEPA_Y,CEPH_Y,CEPV_Y,CEPCH1_Y,DEMA_Y,DEMH_Y,DEMV_Y,DEMCH1_Y ,            temperature,    Process,   auto_measure,   record_status,    Notes1, Notes2,  IDateTime,   Manual) values       ( '" + v_point_id + "' ,'" + v_point_name + "','" + v_Point_Type + "', '" + v_measure_time + "' , '" + v_accel_a + "' ,'" + v_accel_h + "','" + v_accel_v + "' ,'" + v_accel_ch1 + "' , '" + v_vel_a + "'   ,'" + v_vel_h + "' ,'" + v_vel_v + "'  ,'" + v_vel_ch1 + "' ,'" + v_displ_a + "' ,  '" + v_displ_h + "' , '" + v_displ_v + "' ,'" + v_displ_ch1 + "'  ,'" + v_crest_factor_a + "', '" + v_crest_factor_h + "'  ,'" + v_crest_factor_v + "' , '" + v_crest_factor_ch1 + "',  '" + v_bearing_a + "' ,'" + v_bearing_h + "', '" + v_bearing_v + "',  '" + v_bearing_ch1 + "'  ,'" + v_ordertrace_a_real + "'  ,'" + v_ordertrace_h_real + "' ,'" + v_ordertrace_v_real + "',  '" + v_ordertrace_ch1_real + "'  ,   '" + v_ordertrace_a_image + "','" + v_ordertrace_h_image + "','" + v_ordertrace_v_image + "','" + v_ordertrace_ch1_image + "', '" + v_ordertrace_rpm + "'  ,  '" + v_time_a_X + "', '" + v_time_h_X + "', '" + v_time_v_X + "' ,'0|' ,'" + v_power_a_X + "','" + v_power_h_X + "' ,'" + v_power_v_X + "','0|' ,'0|','0|' ,'0|' ,'0|' ,'0|' ,'0|' ,'0|'  ,'0|'   ,'0|' ,'0|' ,'0|' ,'0|' ,'0|' ,'0|' ,'0|' ,'0|'  ,'0|' ,'0|' ,'0|' ,'0|'  ,'0|' ,'0|' ,'0|' ,'0|' , '0|' ,'0|' ,'0|' , '0|'   ,  '" + v_time_a_Y + "', '" + v_time_h_Y + "', '" + v_time_v_Y + "' ,'0|' ,'" + v_power_a_Y + "','" + v_power_h_Y + "' ,'" + v_power_v_Y + "','0|' ,'0|' ,'0|'  ,'0|'  ,'0|'   ,'0|' ,'0|' ,'0|' ,'0|'  ,'0|' ,'0|' ,'0|' ,'0|' ,'0|' ,'0|' ,'0|' ,'0|'  ,'0|' ,'0|' ,'0|' ,'0|'  ,'0|' ,'0|' ,'0|' ,'0|' ,'0|' ,'0|' ,'0|' , '0|'    ,  '0','0','0','0' ,'' ,'',  '" + PublicClass.GetDatetime() + "' , ' ') ");
                                    }
                                }
                            }
                            else
                            {
                                try
                                {
                                    string channel1 = _ChnlA.ToString();
                                    string selectratio = _Ampmode.ToString();
                                    string channel2 = _ChnlB.ToString();
                                    string selectratio2 = _Ampmode2.ToString();
                                    if (Is2Channel)
                                    {
                                        if (channel2 == "0" || channel2 == "1" || channel2 == "2")
                                        {
                                            if (selectratio2 == "0")
                                            {
                                                v_accel_v = Convert.ToString(RMS2);
                                                v_power_v_X = Convert.ToString(DataX2);
                                                v_power_v_Y = Convert.ToString(DataY2);
                                            }
                                            else if (selectratio2 == "1")
                                            {
                                                v_vel_v = Convert.ToString(RMS2);
                                                v_power_v_X = Convert.ToString(DataX2);
                                                v_power_v_Y = Convert.ToString(DataY2);
                                            }
                                            else if (selectratio2 == "2")
                                            {
                                                v_displ_v = Convert.ToString(RMS2);
                                                v_power_v_X = Convert.ToString(DataX2);
                                                v_power_v_Y = Convert.ToString(DataY2);
                                            }
                                        }
                                    }
                                    if (channel1 == "0" || channel1 == "1" || channel1 == "2")
                                    {
                                        if (selectratio == "0")
                                        {
                                            v_accel_h = Convert.ToString(RMS);
                                        }
                                        else if (selectratio == "1")
                                        {
                                            v_vel_h = Convert.ToString(RMS);
                                        }
                                        else if (selectratio == "2")
                                        {
                                            v_displ_h = Convert.ToString(RMS);
                                        }
                                        else
                                        {
                                            v_crest_factor_h = Convert.ToString(RMS);
                                        }
                                        v_power_h_X = Convert.ToString(DataX);
                                        v_power_h_Y = Convert.ToString(DataY);
                                        DbClass.executequery(CommandType.Text, "insert into point_data (Point_ID,Point_name, Point_Type,  Measure_time,  accel_a,  accel_h,    accel_v,accel_ch1, vel_a,        vel_h, vel_v, vel_ch1,      displ_a,   displ_h,    displ_v, displ_ch1,crest_factor_a,    crest_factor_h,    crest_factor_v,   crest_factor_ch1 ,          bearing_a,       bearing_h,  bearing_v,  bearing_ch1,        ordertrace_a_real,   ordertrace_h_real,  ordertrace_v_real ,ordertrace_ch1_real ,     ordertrace_a_image,   ordertrace_h_image,    ordertrace_v_image, ordertrace_ch1_image,   ordertrace_rpm,    TimeA_X,     timeH_X,     timeV_X,timeCH1_X,       PA_X, PH_X,    PV_X,  PCH1_X,    P1A_X, P1H_X,  P1V_X,   P1CH1_X,   P2A_X,   P2H_X,   P2V_X,  P2CH1_X,     P21A_X,  P21H_X,  P21V_X,  P21CH1_X,  P3A_X,  P3H_X, P3V_X,  P3CH1_X,   P31A_X,   P31H_X,  P31V_X,  P31CH1_X,   CEPA_X,    CEPH_X,  CEPV_X, CEPCH1_X,    DEMA_X,   DEMH_X, DEMV_X, DEMCH1_X,      timeA_Y,        timeH_Y,     timeV_Y,    timeCH1_Y,     PA_Y,     PH_Y,    PV_Y,    PCH1_Y,P1A_Y,P1H_Y,P1V_Y,P1CH1_Y,P2A_Y,P2H_Y,P2V_Y,P2CH1_Y,P21A_Y,P21H_Y,P21V_Y,P21CH1_Y,P3A_Y,P3H_Y,P3V_Y,P3CH1_Y,P31A_Y,P31H_Y,P31V_Y,P31CH1_Y,CEPA_Y,CEPH_Y,CEPV_Y,CEPCH1_Y,DEMA_Y,DEMH_Y,DEMV_Y,DEMCH1_Y ,            temperature,    Process,   auto_measure,   record_status,    Notes1, Notes2,  IDateTime,   Manual) values       ( '" + v_point_id + "' ,'" + v_point_name + "','" + v_Point_Type + "', '" + v_measure_time + "' , '" + v_accel_a + "' ,'" + v_accel_h + "','" + v_accel_v + "' ,'" + v_accel_ch1 + "' , '" + v_vel_a + "'   ,'" + v_vel_h + "' ,'" + v_vel_v + "'  ,'" + v_vel_ch1 + "' ,'" + v_displ_a + "' ,  '" + v_displ_h + "' , '" + v_displ_v + "' ,'" + v_displ_ch1 + "'  ,'" + v_crest_factor_a + "', '" + v_crest_factor_h + "'  ,'" + v_crest_factor_v + "' , '" + v_crest_factor_ch1 + "',  '" + v_bearing_a + "' ,'" + v_bearing_h + "', '" + v_bearing_v + "',  '" + v_bearing_ch1 + "'  ,'" + v_ordertrace_a_real + "'  ,'" + v_ordertrace_h_real + "' ,'" + v_ordertrace_v_real + "',  '" + v_ordertrace_ch1_real + "'  ,   '" + v_ordertrace_a_image + "','" + v_ordertrace_h_image + "','" + v_ordertrace_v_image + "','" + v_ordertrace_ch1_image + "', '" + v_ordertrace_rpm + "'  ,  '" + v_time_a_X + "', '" + v_time_h_X + "', '" + v_time_v_X + "' ,'0|' ,'" + v_power_a_X + "','" + v_power_h_X + "' ,'" + v_power_v_X + "','0|' ,'0|','0|' ,'0|' ,'0|' ,'0|' ,'0|' ,'0|'  ,'0|'   ,'0|' ,'0|' ,'0|' ,'0|' ,'0|' ,'0|' ,'0|' ,'0|'  ,'0|' ,'0|' ,'0|' ,'0|'  ,'0|' ,'0|' ,'0|' ,'0|' , '0|' ,'0|' ,'0|' , '0|'   ,  '" + v_time_a_Y + "', '" + v_time_h_Y + "', '" + v_time_v_Y + "' ,'0|' ,'" + v_power_a_Y + "','" + v_power_h_Y + "' ,'" + v_power_v_Y + "','0|' ,'0|' ,'0|'  ,'0|'  ,'0|'   ,'0|' ,'0|' ,'0|' ,'0|'  ,'0|' ,'0|' ,'0|' ,'0|' ,'0|' ,'0|' ,'0|' ,'0|'  ,'0|' ,'0|' ,'0|' ,'0|'  ,'0|' ,'0|' ,'0|' ,'0|' ,'0|' ,'0|' ,'0|' , '0|'    ,  '0','0','0','0' ,'' ,'',  '" + PublicClass.GetDatetime() + "' , ' ') ");
                                    }
                                }
                                catch { }
                            }
                        }
                        catch { }
                    }
                    catch { }
                }
            }
            catch { }
        }

        private void ExtractData(byte[] MainArr)
        {
            int CtrToStart = 0;
            byte[] fs = new byte[2];
            Is2Channel = false;
            try
            {
                //Reading Buffer  cnt
                fs[0] = MainArr[CtrToStart];
                fs[1] = MainArr[CtrToStart + 1];
                //string byteval = fs[0].ToString() + fs[1].ToString();
                string byteval = Common.DeciamlToHexadeciaml1(Convert.ToInt32(fs[0].ToString())) + Common.DeciamlToHexadeciaml1(Convert.ToInt32(fs[1].ToString()));
                int ival = Common.HexadecimaltoDecimal(byteval);
                int BufferCNT = ival;

                //Reading buf1  --- 1 buffer size (currently 238 bytes)
                CtrToStart = 2;
                fs = new byte[2];
                fs[0] = MainArr[CtrToStart];
                fs[1] = MainArr[CtrToStart + 1];
                byteval = Common.DeciamlToHexadeciaml1(Convert.ToInt32(fs[0].ToString())) + Common.DeciamlToHexadeciaml1(Convert.ToInt32(fs[1].ToString()));
                ival = Common.HexadecimaltoDecimal(byteval);
                int Buf1 = ival;
                //int Buf1 = 238;

                //Reading buf2  --- 2 buffer size depends on the count of the spectral lines or sample length * (t)
                CtrToStart = 4;
                fs = new byte[2];
                fs[0] = MainArr[CtrToStart];
                fs[1] = MainArr[CtrToStart + 1];
                byteval = Common.DeciamlToHexadeciaml1(Convert.ToInt32(fs[0].ToString())) + Common.DeciamlToHexadeciaml1(Convert.ToInt32(fs[1].ToString()));
                ival = Common.HexadecimaltoDecimal(byteval);
                int Buf2 = ival;

                //Reading buf3  ---=0  if one channel---- 3 buffer size depends on the count of the spectral lines or sample length * (t)
                CtrToStart = 6;
                fs = new byte[2];
                fs[0] = MainArr[CtrToStart];
                fs[1] = MainArr[CtrToStart + 1];
                byteval = Common.DeciamlToHexadeciaml1(Convert.ToInt32(fs[0].ToString())) + Common.DeciamlToHexadeciaml1(Convert.ToInt32(fs[1].ToString()));
                ival = Common.HexadecimaltoDecimal(byteval);
                int Buf3 = ival;
                if (Buf3 > 0)
                {
                    Is2Channel = true;
                }

                //Reading buf4  ---calculating for Phase value of Channel1-------------changes by vimal
                //CtrToStart = 8;
                //fs = new byte[2];
                //fs[0] = MainArr[CtrToStart];
                //fs[1] = MainArr[CtrToStart + 1];
                //byteval = Common.DeciamlToHexadeciaml1(Convert.ToInt32(fs[0].ToString())) + Common.DeciamlToHexadeciaml1(Convert.ToInt32(fs[1].ToString()));
                //ival = Common.HexadecimaltoDecimal(byteval);
                //int Buf4 = ival;

                ////Reading buf5  ---calculating for Phase value of Channel2-------------changes by vimal
                //CtrToStart = 10;
                //fs = new byte[2];
                //fs[0] = MainArr[CtrToStart];
                //fs[1] = MainArr[CtrToStart + 1];
                //byteval = Common.DeciamlToHexadeciaml1(Convert.ToInt32(fs[0].ToString())) + Common.DeciamlToHexadeciaml1(Convert.ToInt32(fs[1].ToString()));
                //ival = Common.HexadecimaltoDecimal(byteval);
                //int Buf5 = ival;


                //Reading LinesFFT  ---100, 200, 400, 800, 1600, 3200, 6400 ---- The number of spectral lines () - throwback - can take the value of the structure device [ ]
                CtrToStart = 8;
                fs = new byte[2];
                fs[0] = MainArr[CtrToStart];
                ////fs[1] = MainArr[CtrToStart + 1];
                byteval = Common.DeciamlToHexadeciaml1(Convert.ToInt32(fs[0].ToString())) + Common.DeciamlToHexadeciaml1(Convert.ToInt32(fs[1].ToString()));
                ival = Common.HexadecimaltoDecimal(byteval);
                int LinesFFT = ival;

                ///////////////Reading device[238 byte]  ---             //Reading device[238 byte]  --- 100, 200, 400, 800, 1600, 3200, 6400 ---- The number of spectral lines () - throwback - can take the value of the structure device [ ]
                CtrToStart = 10;
                fs = new byte[238];
                byteval = null;
                //int[] devicedata = new int[238];
                byte[] devicedata = new byte[238];
                for (int i = 0; i < 238; i++, CtrToStart++)
                {
                    devicedata[i] = MainArr[CtrToStart];
                }

                //////////////////////////////////////////Changes by Vimal for Phase data .......Calculating device data

                //CtrToStart = 2 + 2 * BufferCNT;
                //fs = new byte[238];
                //byteval = null;
                //byte[] devicedata = new byte[238];
                //for (int i = 0; i < 238; i++, CtrToStart++)
                //{
                //    devicedata[i] = MainArr[CtrToStart];
                //}

                GetDevicestructure(devicedata);

                //Reading ch1 float FFT[size] or int   F(t)[size] ---- CH1 or range of functions. time
                //CtrToStart = 248;///Old value
                //CtrToStart = CtrToStart + 238;///new value change by vimal
                fs = new byte[Buf2];
                //CtrToStart = 246;
                byteval = null;
                YData = new double[Number_Of_Spectrum];
                for (int i = 0; i < Number_Of_Spectrum; i++)
                {
                    float fabc = BytetoFloat(MainArr, CtrToStart);
                    YData[i] = Convert.ToDouble(fabc);
                    //CH1.Add(fabc);
                    CtrToStart += 4;

                }
                if (Is2Channel)
                {
                    //Reading ch2 float FFT[size] or int   F(t)[size] ---- Channel2 range or function. time
                    //CtrToStart = 246 + Buf2;
                    fs = new byte[Buf3];
                    byteval = null;
                    YData2 = new double[Number_Of_Spectrum];
                    for (int i = 0; i < Number_Of_Spectrum; i++)
                    {
                        float fabc = BytetoFloat(MainArr, CtrToStart);
                        YData2[i] = Convert.ToDouble(fabc);
                        //YData2[i] = Convert.ToDouble(fabc);
                        CtrToStart += 4;
                    }
                }
                /////////////////////////Code for Phase Value channel wise...........changes by vimal

                //fs = new byte[Buf4];
                ////CtrToStart = 246;
                //byteval = null;
                //RealVal = new double[Number_Of_Spectrum];
                //for (int i = 0; i < Number_Of_Spectrum; i++)
                //{
                //    double fabc = Bytetodouble(MainArr, CtrToStart);
                //    RealVal[i] = Convert.ToDouble(fabc);
                //    CtrToStart += 8;
                //}
                //ImageVal = new double[Number_Of_Spectrum];
                //CtrToStart = 23034;
                //for (int i = 0; i < Number_Of_Spectrum; i++)
                //{
                //    double fabc = Bytetodouble(MainArr, CtrToStart);
                //    ImageVal[i] = Convert.ToDouble(fabc);
                //    CtrToStart += 8;
                //}
                //PhaseChnl1 = new string[Number_Of_Spectrum];
                //for (int j = 0; j < Number_Of_Spectrum; j++)
                //{
                //    PhaseChnl1[j] = CalculatePhase(Convert.ToDouble(ImageVal[j]), Convert.ToDouble(RealVal[j]));
                //}


                //    if (Is2Channel)
                //    {
                //        //Reading ch2 float FFT[size] or int   F(t)[size] ---- Channel2 range or function. time
                //        //CtrToStart = 246 + Buf2;
                //        fs = new byte[Buf5];
                //        byteval = null;
                //        PhaseChnl2 = new double[Number_Of_Spectrum];
                //        for (int i = 0; i < Number_Of_Spectrum; i++)
                //        {
                //           // PhaseChnl2[i] = CalculatePhase(Convert.ToDouble(ImageVal[i]), Convert.ToDouble(RealVal[i]));
                //        }
                //    }
            }
            catch (Exception ex)
            {
            }
        }

        public string CalculatePhase(double Im, double Re)
        {
            string PhaseVal = Convert.ToString(Math.Atan(Im / Re));
            double PhaseNew = Math.Atan2(Im, Re);
            double anglea = Convert.ToDouble(PhaseVal) * (180 / Math.PI);
            double imag = Im;
            double real = Re;

            if (imag > 0.0 && real > 0.0)
            {
                if (anglea > 0.0 || anglea < 90.0)
                {
                    PhaseVal = Convert.ToString(anglea);
                }
                else
                {
                    anglea = anglea + 90.0;
                    if (anglea > 0.0 || anglea < 90.0)
                    {
                        PhaseVal = Convert.ToString(anglea);
                    }
                }
            }
            else if (imag > 0.0 && real < 0.0)
            {
                if (anglea > 90.0 && anglea < 180.0)
                {
                    PhaseVal = Convert.ToString(anglea);
                }
                else
                {
                    anglea = anglea + 90.0;
                    if (anglea > 90.0 && anglea < 180.0)
                    {
                        PhaseVal = Convert.ToString(anglea);
                    }
                    else
                    {
                        anglea = anglea + 90.0;
                        if (anglea > 90.0 && anglea < 180.0)
                        {
                            PhaseVal = Convert.ToString(anglea);
                        }
                    }
                }
            }
            else if (imag < 0.0 && real < 0.0)
            {
                if (anglea > 180.0 && anglea < 270.0)
                {
                    PhaseVal = Convert.ToString(anglea);
                }
                else
                {
                    anglea = anglea + 90.0;
                    if (anglea > 180.0 && anglea < 270.0)
                    {
                        PhaseVal = Convert.ToString(anglea);
                    }
                    else
                    {
                        anglea = anglea + 90.0;
                        if (anglea > 180.0 && anglea < 270.0)
                        {
                            PhaseVal = Convert.ToString(anglea);
                        }
                        else
                        {
                            anglea = anglea + 90.0;
                            if (anglea > 180.0 && anglea < 270.0)
                            {
                                PhaseVal = Convert.ToString(anglea);
                            }
                        }
                    }
                }
            }


            else if (imag < 0.0 && real > 0.0)
            {
                if (anglea > 270.0 && anglea < 360.0)
                {
                    PhaseVal = Convert.ToString(anglea);
                }
                else
                {
                    anglea = anglea + 90.0;
                    if (anglea > 270.0 && anglea < 360.0)
                    {
                        PhaseVal = Convert.ToString(anglea);
                    }
                    else
                    {
                        anglea = anglea + 90.0;
                        if (anglea > 270.0 && anglea < 360.0)
                        {
                            PhaseVal = Convert.ToString(anglea);
                        }
                        else
                        {
                            anglea = anglea + 90.0;
                            if (anglea > 270.0 && anglea < 360.0)
                            {
                                PhaseVal = Convert.ToString(anglea);
                            }
                            else
                            {
                                anglea = anglea + 90.0;
                                if (anglea > 270.0 && anglea < 360.0)
                                {
                                    PhaseVal = Convert.ToString(anglea);
                                }
                            }
                        }
                    }
                }
            }
            PhaseVal = Convert.ToString(anglea);
            if (PhaseVal == "NaN")
            {
                PhaseVal = "NA";
            }
            return PhaseVal;
        }

        /// <summary>
        /// ///////////////////////chnages for TWF extracting///////////////////////////////
        /// </summary>
        /// <param name="devicedata"></param>
        public string Retrive_YxValue(byte[] btTimeA, int CtrToStart)
        {
            string[] sarrYTData = new string[0];
            StringBuilder sbYValues = new StringBuilder();
            string YTAData = "";
            try
            {
                if (btTimeA != null)
                {
                    byte[] mainarrNew = new byte[btTimeA.GetLength(0) - 248];

                    for (int k = 0; k < mainarrNew.Length; k++)
                    {
                        mainarrNew[k] = btTimeA[k + 248];
                    }

                    //int iLength = (btTimeA.GetLength(0) + 2) / 4;
                    int iLength = (mainarrNew.GetLength(0) + 7) / 8;
                    double[] dTimeImage_A = new double[iLength];
                    for (int i = 0; i < iLength; i++)
                    {
                        dTimeImage_A[i] = BitConverter.ToDouble(mainarrNew, i * 8);
                    }
                    for (int iLoop = 0; iLoop < dTimeImage_A.Length; iLoop++)
                    {
                        sbYValues.Append(dTimeImage_A[iLoop]);
                        sbYValues.Append("|");
                    }

                    string sTimeData = System.Text.Encoding.Default.GetString(btTimeA);
                    YTAData = Convert.ToString(sbYValues);
                    _ResizeArray.IncreaseArrayString(ref sarrYTData, 1);
                    sarrYTData[sarrYTData.Length - 1] = YTAData;
                    YTAData = sarrYTData[sarrYTData.Length - 1];
                }

            }
            catch (Exception e)
            { throw e; }
            return YTAData;

        }

        /// <summary>
        /// /////////////////////////End for TWF//////////////////////////////////////////////////////////////
        /// </summary>
        /// <param name="devicedata"></param>


        //private void GetDevicestructure(byte[] devicedata)
        //{
        //    int ctrStructure = 0;
        //    try
        //    {
        //        //Read RMS
        //        _RMS = BytetoFloat(devicedata, ctrStructure);
        //        if (Is2Channel)
        //        {
        //            ctrStructure = 4;
        //            _RMS2 = BytetoFloat(devicedata, ctrStructure);
        //        }

        //        //Read P_P
        //        ctrStructure = 12;
        //        _P_P = BytetoFloat(devicedata, ctrStructure);
        //        if (Is2Channel)
        //        {
        //            ctrStructure = 16;
        //            _P_P2 = BytetoFloat(devicedata, ctrStructure);
        //        }

        //        //Read dF
        //        ctrStructure = 24;
        //        _dF = Math.Round(Convert.ToDouble(BytetoFloat(devicedata, ctrStructure)), 3);

        //        //Read Window
        //        ctrStructure = 54;
        //        _Window = Convert.ToInt32(devicedata[ctrStructure].ToString());
        //        if (Is2Channel)
        //        {
        //            ctrStructure = 55;
        //            _Window2 = Convert.ToInt32(devicedata[ctrStructure].ToString());
        //        }

        //        //Read pwr2
        //        ctrStructure = 57;
        //        _pwr2 = Convert.ToInt32(devicedata[ctrStructure].ToString());

        //        //Read Measurement
        //        ctrStructure = 58;
        //        _Measurement = Convert.ToInt32(devicedata[ctrStructure].ToString());
        //        if (Is2Channel)
        //        {
        //            ctrStructure = 59;
        //            _Measurement2 = Convert.ToInt32(devicedata[ctrStructure].ToString());
        //        }

        //        //Read channel A
        //        ctrStructure = 61;
        //        _ChnlA = Convert.ToInt32(devicedata[ctrStructure].ToString());

        //        if (_Measurement == 0) // For Time
        //        {
        //            Number_Of_Spectrum = 1 << _pwr2;
        //        }
        //        else if (_Measurement == 1) // For FFT
        //        {
        //            Number_Of_Spectrum = (1 << (_pwr2 - 6)) * 25;
        //        }

        //        HighestFrequency = dF * Number_Of_Spectrum;
        //        XData = new double[Number_Of_Spectrum];
        //        for (int i = 0; i < Number_Of_Spectrum; i++)
        //        {
        //            XData[i] = Convert.ToDouble(dF * i);
        //        }

        //        //Read channel B
        //        ctrStructure = 62;
        //        _ChnlB = Convert.ToInt32(devicedata[ctrStructure].ToString());


        //        //Read Trigger
        //        ctrStructure = 63;
        //        _Trig = Convert.ToInt32(devicedata[ctrStructure].ToString());


        //        //Read Averaging Mode
        //        ctrStructure = 64;
        //        _Avgm = Convert.ToInt32(devicedata[ctrStructure].ToString());


        //        //Read Averaging Number
        //        ctrStructure = 65;
        //        _Navg = Convert.ToInt32(devicedata[ctrStructure].ToString());


        //        //Read EPC
        //        ctrStructure = 66;
        //        _EPC = Convert.ToInt32(devicedata[ctrStructure].ToString());


        //        //Read Amplifier Mode
        //        ctrStructure = 70;
        //        _Ampmode = Convert.ToInt32(devicedata[ctrStructure].ToString());
        //        if (Is2Channel)
        //        {
        //            ctrStructure = 71;
        //            _Ampmode2 = Convert.ToInt32(devicedata[ctrStructure].ToString());
        //        }

        //        //Read Low Frequency Cut Off
        //        ctrStructure = 76;
        //        _Amphpf = Convert.ToInt32(devicedata[ctrStructure].ToString());
        //        if (Is2Channel)
        //        {
        //            ctrStructure = 77;
        //            _Amphpf2 = Convert.ToInt32(devicedata[ctrStructure].ToString());
        //        }

        //        //Read Carrier for channel
        //        ctrStructure = 79;
        //        _Ampenvcr = Convert.ToInt32(devicedata[ctrStructure].ToString());
        //        if (Is2Channel)
        //        {
        //            ctrStructure = 80;
        //            _Ampenvcr2 = Convert.ToInt32(devicedata[ctrStructure].ToString());
        //        }

        //        //Read Transducer factor/Sensitivity
        //        ctrStructure = 90;
        //        _Sens = BytetoFloat(devicedata, ctrStructure);
        //        if (Is2Channel)
        //        {
        //            ctrStructure = 94;
        //            _Sens2 = BytetoFloat(devicedata, ctrStructure);
        //        }
        //        ctrStructure = 226;
        //        ulong serialNumber = Bytetoulong(devicedata, ctrStructure);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        /// <summary>
        /// New function create by Vimal for device structure
        /// </summary>
        /// <param name="MainArr"></param>
        /// <param name="CtrToStart"></param>
        /// <returns></returns>
        private void GetDevicestructure(byte[] devicedata)
        {
            int ctrStructure = 0;
            try
            {
                //Read RMS
                _RMS = BytetoFloat(devicedata, ctrStructure);
                if (Is2Channel)
                {
                    ctrStructure = 4;
                    _RMS2 = BytetoFloat(devicedata, ctrStructure);
                }

                //Read P_P
                ctrStructure = 12;
                _P_P = BytetoFloat(devicedata, ctrStructure);
                if (Is2Channel)
                {
                    ctrStructure = 16;
                    _P_P2 = BytetoFloat(devicedata, ctrStructure);
                }

                //Read dF
                ctrStructure = 24;
                _dF = Math.Round(Convert.ToDouble(BytetoFloat(devicedata, ctrStructure)), 3);

                //Read Window
                ctrStructure = 54;
                _Window = Convert.ToInt32(devicedata[ctrStructure].ToString());
                if (Is2Channel)
                {
                    ctrStructure = 55;
                    _Window2 = Convert.ToInt32(devicedata[ctrStructure].ToString());
                }

                //Read pwr2
                ctrStructure = 57;
                _pwr2 = Convert.ToInt32(devicedata[ctrStructure].ToString());

                //Read Measurement
                ctrStructure = 58;
                _Measurement = Convert.ToInt32(devicedata[ctrStructure].ToString());
                if (Is2Channel)
                {
                    ctrStructure = 59;
                    _Measurement2 = Convert.ToInt32(devicedata[ctrStructure].ToString());
                }

                if (_Measurement == 0) // For Time
                {
                    Number_Of_Spectrum = 1 << _pwr2;
                }
                else if (_Measurement == 1) // For FFT
                {
                    int samplelength = 1 << _pwr2;
                    Number_Of_Spectrum = (1 << (_pwr2 - 6)) * 25;
                }

                //Read channel A
                ctrStructure = 61;
                _ChnlA = Convert.ToInt32(devicedata[ctrStructure].ToString());

                //Read band length
                HighestFrequency = dF * Number_Of_Spectrum;
                XData = new double[Number_Of_Spectrum];
                for (int i = 0; i < Number_Of_Spectrum; i++)
                {
                    XData[i] = Convert.ToDouble(dF * i);
                }

                //Read channel B
                ctrStructure = 62;
                _ChnlB = Convert.ToInt32(devicedata[ctrStructure].ToString());


                //Read Trigger
                ctrStructure = 63;
                _Trig = Convert.ToInt32(devicedata[ctrStructure].ToString());


                //Read Averaging Mode
                ctrStructure = 64;
                _Avgm = Convert.ToInt32(devicedata[ctrStructure].ToString());


                //Read Averaging Number
                ctrStructure = 65;
                _Navg = Convert.ToInt32(devicedata[ctrStructure].ToString());


                //Read EPC
                ctrStructure = 66;
                _EPC = Convert.ToInt32(devicedata[ctrStructure].ToString());


                //Read Amplifier Mode
                ctrStructure = 70;
                _Ampmode = Convert.ToInt32(devicedata[ctrStructure].ToString());
                if (Is2Channel)
                {
                    ctrStructure = 71;
                    _Ampmode2 = Convert.ToInt32(devicedata[ctrStructure].ToString());
                }

                //Read Low Frequency Cut Off
                ctrStructure = 76;
                _Amphpf = Convert.ToInt32(devicedata[ctrStructure].ToString());
                if (Is2Channel)
                {
                    ctrStructure = 77;
                    _Amphpf2 = Convert.ToInt32(devicedata[ctrStructure].ToString());
                }

                //Read Carrier for channel
                ctrStructure = 79;
                _Ampenvcr = Convert.ToInt32(devicedata[ctrStructure].ToString());
                if (Is2Channel)
                {
                    ctrStructure = 80;
                    _Ampenvcr2 = Convert.ToInt32(devicedata[ctrStructure].ToString());
                }

                //Read Transducer factor/Sensitivity
                ctrStructure = 90;
                _Sens = BytetoFloat(devicedata, ctrStructure);
                if (Is2Channel)
                {
                    ctrStructure = 94;
                    _Sens2 = BytetoFloat(devicedata, ctrStructure);
                }
                ctrStructure = 226;
                ulong serialNumber = Bytetoulong(devicedata, ctrStructure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private float BytetoFloat(byte[] MainArr, int CtrToStart)
        {
            float returnfloat = 0;
            try
            {
                byte[] newbyte = new byte[4];
                newbyte[0] = MainArr[CtrToStart];
                newbyte[1] = MainArr[CtrToStart + 1];
                newbyte[2] = MainArr[CtrToStart + 2];
                newbyte[3] = MainArr[CtrToStart + 3];   
                newbyte = newbyte.Reverse().ToArray();

                returnfloat = BitConverter.ToSingle(newbyte, 0);
            }
            catch
            {
            }
            return returnfloat;
        }
        private double Bytetodouble(byte[] MainArr, int CtrToStart)
        {
            double returndouble = 0;
            try
            {
                byte[] newbyte = new byte[8];
                newbyte[0] = MainArr[CtrToStart];
                newbyte[1] = MainArr[CtrToStart + 1];
                newbyte[2] = MainArr[CtrToStart + 2];
                newbyte[3] = MainArr[CtrToStart + 3];
                newbyte[4] = MainArr[CtrToStart + 4];
                newbyte[5] = MainArr[CtrToStart + 5];
                newbyte[6] = MainArr[CtrToStart + 6];
                newbyte[7] = MainArr[CtrToStart + 7];

                newbyte = newbyte.Reverse().ToArray();

                returndouble = BitConverter.ToDouble(newbyte, 0);
            }
            catch
            {
            }
            return returndouble;
        }

        private ulong Bytetoulong(byte[] MainArr, int CtrToStart)
        {
            ulong returnval = 0;
            try
            {
                byte[] newbyte = new byte[8];
                for (int i = 0; i < 8; i++)
                {
                    newbyte[i] = MainArr[CtrToStart + i];
                }

                newbyte = newbyte.Reverse().ToArray();

                returnval = BitConverter.ToUInt64(newbyte, 0);
            }
            catch
            {
            }
            return returnval;
        }
        double HighestFrequency = 0;
        public double _highestFreq
        {
            get
            {
                return HighestFrequency;
            }
            set
            {
                HighestFrequency = value;
            }
        }
        int Number_Of_Spectrum = 0;
        public int _Number_Of_Spectrum
        {
            get
            {
                return Number_Of_Spectrum;
            }
            set
            {
                Number_Of_Spectrum = value;
            }
        }


        private void ExtractOffDataDiForUsb(byte[] MainArr)
        {
            int Value = 0;
            bool AckGetBt = false;
            int CtrToStart = 0;
            int arrchannel = 0;
            string sPointName = null;
            string sPointDescription = null;
            string sFactoryName = null;
            string sResourceName = null;
            string sElementName = null;
            string sSubElementName = null;
            byte[] NameExtracter = new byte[17];
            string PreviousFacName = null;
            string PreviousEqupname = null;
            string PreviousComname = null;
            string PreviousSubCompname = null;
            string PreviousPointName = null;
            bool SamePointDifferentChannel = false;
            string NewID = null;
            double OverallValueDecoded = 0.0;
            double CalculatedFullScale = 0;

            string PointDate = null;
            string PointMonth = null;
            string PointYear = null;
            string PointHour = null;
            string PointMinute = null;
            string PointSecond = null;
            bool DateFound = false;
            int offptctr = 0;
            try
            {
                Value = 0;
                do
                {
                    try
                    {
                        int Factor = 0;
                        int KeyFactor = 0;
                        AckGetBt = false;
                        do
                        {
                            if (MainArr[CtrToStart] == 0x58 && MainArr[CtrToStart + 1] == 0x02 && MainArr[CtrToStart + 2] == 0x06 && MainArr[CtrToStart + 3] == 0x01)
                            {

                            }
                            CtrToStart++;
                        } while (true);
                    }
                    catch { }

                } while (CtrToStart < MainArr.Length - 3);
            }
            catch { }
        }


    }
}
