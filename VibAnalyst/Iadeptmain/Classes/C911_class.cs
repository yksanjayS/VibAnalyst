﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Iadeptmain.Images;
using Iadeptmain.Mainforms;
using System.Collections;

namespace Iadeptmain.Classes
{
   public class C911_class
   {
        int trendValCtr = 0;
        ImageList objlistimg = new ImageList();
        string[] ColorCode = { "7667712", "16751616", "4684277", "7077677", "16777077", "9868951", "2987746", "4343957", "16777216", "23296", "16711681", "8388652", "6972", "16776961", "7722014", "32944", "7667573", "7357301", "12042869", "60269", "14774017", "5103070", "14513374", "5374161", "38476", "3318692", "29696", "6737204", "16728065", "744352" };


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

        enum window { Rectangular, Hanning };
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

        enum measurement { TimeFunction, FFT };
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


        enum trig { FreeRun, Internal, External };
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

        enum avgm { Off, TimeLinear, TimeExponential, FrequencyLinear, FrequencyExponential };
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

        #region C911_Interface Members
        frmIAdeptMain objForm = null;
        public frmIAdeptMain _Form1
        {
            get
            {
                return objForm;
            }
            set
            {
                objForm = value;
            }
        }

        frmGControls objGcontrol = null;
        public frmGControls _objgcontrol
        {
            get
            {
                return objGcontrol;
            }
            set
            {
                objGcontrol = value;
            }
        }
       
        public void ReadFFTFile(string FileName)
        {
            objlistimg.Images.Add(ImageResources.DarkRed);
            objlistimg.Images.Add(ImageResources.DarkGreen);
            objlistimg.Images.Add(ImageResources.DarkGoldenRod);
          //  objlistimg.Images.Add(ImageResources.DarkVoilet);
            objlistimg.Images.Add(ImageResources.DarkBlue);
            objlistimg.Images.Add(ImageResources.DimGrey);
            objlistimg.Images.Add(ImageResources.Chocolate);
            objlistimg.Images.Add(ImageResources.DarkKhaki);
            objlistimg.Images.Add(ImageResources.Black);
            objlistimg.Images.Add(ImageResources.Orange);
            objlistimg.Images.Add(ImageResources.Cyan);
            objlistimg.Images.Add(ImageResources.AquaMarine);
            objlistimg.Images.Add(ImageResources.Bisque);
            objlistimg.Images.Add(ImageResources.Blue);
            objlistimg.Images.Add(ImageResources.BlueViolet);
            objlistimg.Images.Add(ImageResources.Coral);
            objlistimg.Images.Add(ImageResources.Darkmagenta);
            //objlistimg.Images.Add(ImageResources.DarkseaGreen);
            //objlistimg.Images.Add(ImageResources.DarkSlateBlue);
            //objlistimg.Images.Add(ImageResources.Deeppink);
            objlistimg.Images.Add(ImageResources.DodgerBlue);
            objlistimg.Images.Add(ImageResources.FireBrick);
            objlistimg.Images.Add(ImageResources.ForestGreen);
            objlistimg.Images.Add(ImageResources.GreenYellow);
            objlistimg.Images.Add(ImageResources.HotPink);
            objlistimg.Images.Add(ImageResources.IndianRed);
            objlistimg.Images.Add(ImageResources.Darkorange);
            objlistimg.Images.Add(ImageResources.Darkorchid);
            //objlistimg.Images.Add(ImageResources.DeepSkyBlue);
            objlistimg.Images.Add(ImageResources.SandyBrown);
            trendValCtr = 0;
            //byte[] FFTData = GetByteData(FileName);
            GetByteData(FileName);
        }

        

        #endregion
        ArrayList arrallData = null;
        private void GetByteData(string FileName)
        {
            arrallData = new ArrayList();
            using (FileStream objInput = new FileStream(FileName, FileMode.Open, FileAccess.Read))
            {
                byte[] MainArr = new byte[(int)objInput.Length];
                int contents = objInput.Read(MainArr, 0, (int)objInput.Length);
                if (Directory.Exists("c:\\vvtemp\\"))
                {
                    Directory.Delete("c:\\vvtemp\\", true);
                }
                ExtractData(MainArr);
                string[] arrFilePath = FileName.ToString().Split(new string[] { "\\", ".fft" }, StringSplitOptions.RemoveEmptyEntries);
               arrallData = CalculateAllData();
               objForm.DrawLineGraphs(arrallData,"0","0");
                
            }
        }

        private ArrayList CalculateAllData()
        {
            ArrayList allData = new ArrayList();
            try
            {
                if (_Ampmode == (int)ampmode.Mode_A)
                {
                    ExportDatainTextFile("Mode_A", XData, YData);

                    YData_V = Calculate_ModeV(YData, "Mode_A");
                    ExportDatainTextFile("Mode_V", XData, YData_V);

                    YData_S = Calculate_ModeS(YData, "Mode_A");
                    ExportDatainTextFile("Mode_S", XData, YData_S);
                    allData.Add(XData);
                    allData.Add(YData);

                }
                else if (_Ampmode == (int)ampmode.Mode_V)
                {
                    ExportDatainTextFile("Mode_V", XData, YData);

                    YData_A = Calculate_ModeA(YData, "Mode_V");
                    ExportDatainTextFile("Mode_A", XData, YData_A);
                    
                    YData_S = Calculate_ModeS(YData, "Mode_V");
                    ExportDatainTextFile("Mode_S", XData, YData_S);
                    allData.Add(XData);
                    allData.Add(YData_S);

                }
                else if (_Ampmode == (int)ampmode.Mode_S)
                {
                    ExportDatainTextFile("Mode_S", XData, YData);

                    YData_V = Calculate_ModeV(YData, "Mode_S");
                    ExportDatainTextFile("Mode_V", XData, YData_S);

                    YData_A = Calculate_ModeA(YData, "Mode_S");
                    ExportDatainTextFile("Mode_A", XData, YData_A);
                }
                else
                {
                    ExportDatainTextFile("Mode_E", XData, YData);
                }
            }
            catch
            {
            }
            return allData;
        }

        private double[] Calculate_ModeA(double[] YData, string FromMode)
        {
            double[] returnArray = new double[YData.Length];
            try
            {
                switch (FromMode)
                {
                    case "Mode_S":
                        {
                            for (int i = 0; i < YData.Length; i++)
                            {
                                double tempdouble = Convert.ToDouble(returnArray[i] / 1000) * Convert.ToDouble(2 * 3.14 * XData[i]);
                                returnArray[i] = Convert.ToDouble(tempdouble / 1000) * Convert.ToDouble(2 * 3.14 * XData[i]);
                                if (returnArray[i].ToString() == "NaN")
                                {
                                    returnArray[i] = 0;
                                }
                            }

                            
                            break;
                        }
                    case "Mode_V":
                        {

                            for (int i = 0; i < YData.Length; i++)
                            {
                                returnArray[i] = Convert.ToDouble(returnArray[i] / 1000) * Convert.ToDouble(2 * 3.14 * XData[i]);
                                if (returnArray[i].ToString() == "NaN")
                                {
                                    returnArray[i] = 0;
                                }
                            }
                            break;
                        }
                }
            }
            catch
            {
            }
            return returnArray;
        }

        private double[] Calculate_ModeS(double[] YData, string FromMode)
        {
            double[] returnArray = new double[YData.Length];
            try
            {
                switch (FromMode)
                {
                    case "Mode_A":
                        {
                            for (int i = 0; i < YData.Length; i++)
                            {
                                returnArray[i] = Convert.ToDouble(YData[i] * 1000000) / Convert.ToDouble(Math.Pow((2 * 3.14 * XData[i]), 2));
                                if (returnArray[i].ToString() == "NaN")
                                {
                                    returnArray[i] = 0;
                                }
                            }
                            break;
                        }
                    case "Mode_V":
                        {

                            for (int i = 0; i < YData.Length; i++)
                            {
                                double tempdouble = Convert.ToDouble(YData[i] / 1000) * Convert.ToDouble(2 * 3.14 * XData[i]);
                                returnArray[i] = Convert.ToDouble(tempdouble * 1000000) / Convert.ToDouble(Math.Pow((2 * 3.14 * XData[i]), 2));
                                if (returnArray[i].ToString() == "NaN")
                                {
                                    returnArray[i] = 0;
                                }
                            }
                            break;
                        }
                }
            }
            catch
            {
            }
            return returnArray;
        }

        private double[] Calculate_ModeV(double[] YData, string FromMode)
        {
            double[] returnArray = new double[YData.Length];
            try
            {
                switch (FromMode)
                {
                    case "Mode_A":
                        {
                            for (int i = 0; i < YData.Length; i++)
                            {
                                returnArray[i] = Convert.ToDouble(YData[i] * 1000) / Convert.ToDouble(2 * 3.14 * XData[i]);
                                if (returnArray[i].ToString() == "NaN")
                                {
                                    returnArray[i] = 0;
                                }
                            }
                            break;
                        }
                    case "Mode_S":
                        {
                            for (int i = 0; i < YData.Length; i++)
                            {
                                returnArray[i] = Convert.ToDouble(YData[i] / 1000) * Convert.ToDouble(2 * 3.14 * XData[i]);
                                if (returnArray[i].ToString() == "NaN")
                                {
                                    returnArray[i] = 0;
                                }
                            }
                            break;
                        }
                }
            }
            catch
            {
            }
            return returnArray;

        }

        private void ExportDatainTextFile(string FileName, double[] XValues, double[] YValues)
        {
            try
            {
                if (!Directory.Exists("c:\\vvtemp\\"))
                {
                    Directory.CreateDirectory("c:\\vvtemp\\");
                }

                FileStream aa = new FileStream("c:\\vvtemp\\" + FileName + ".txt", FileMode.Create, FileAccess.ReadWrite);

                StreamWriter sw = new StreamWriter(aa);
                for (int i = 0; i < XValues.Length; i++)
                {
                    sw.Write(XValues[i] + "/././" + YValues[i] + ".....");
                }
                sw.Close();

                int iCCtr = trendValCtr % 30;
                objGcontrol.dataGridView2.Rows.Add(1);
                objGcontrol.dataGridView2.Rows[objGcontrol.dataGridView2.Rows.Count - 2].Cells[0].Value = FileName;
                objGcontrol.dataGridView2.Rows[objGcontrol.dataGridView2.Rows.Count - 2].Cells[2].Value = FileName;
                objGcontrol.dataGridView2.Rows[objGcontrol.dataGridView2.Rows.Count - 2].Cells[1].Value = "X";
                objGcontrol.dataGridView2.Rows[objGcontrol.dataGridView2.Rows.Count - 2].Cells[3].Value = objlistimg.Images[iCCtr];
                objGcontrol.dataGridView2.Rows[objGcontrol.dataGridView2.Rows.Count - 2].Cells[3].Tag = ColorCode[iCCtr].ToString();

                trendValCtr++;
            }
            catch
            {
            }
        }
        
        private void ExtractData(byte[] MainArr)
        {
            int CtrToStart = 0;
            byte[] fs = new byte[2];

            try
            {
                //List<byte> arrByte = new List<byte>();
                //foreach (byte btm in MainArr)
                //{
                //    arrByte.Add(Convert.ToByte(Common.DeciamlToHexadeciaml1(Convert.ToInt32(btm))));
                //}

                //Reading Buffer  cnt
                fs[0] = MainArr[CtrToStart];
                fs[1] = MainArr[CtrToStart + 1];
                string byteval = fs[0].ToString() + fs[1].ToString();
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

                //Reading LinesFFT  ---100, 200, 400, 800, 1600, 3200, 6400 ---- The number of spectral lines () - throwback - can take the value of the structure device [ ]
                CtrToStart = 8;
                fs = new byte[2];
                fs[0] = MainArr[CtrToStart];
                fs[1] = MainArr[CtrToStart + 1];
                byteval = Common.DeciamlToHexadeciaml1(Convert.ToInt32(fs[0].ToString())) + Common.DeciamlToHexadeciaml1(Convert.ToInt32(fs[1].ToString()));
                ival = Common.HexadecimaltoDecimal(byteval);
                int LinesFFT = ival;

                //Reading device[238 byte]  ---             //Reading device[238 byte]  --- 100, 200, 400, 800, 1600, 3200, 6400 ---- The number of spectral lines () - throwback - can take the value of the structure device [ ]
                CtrToStart = 10;
                fs = new byte[238];
                byteval = null;
                //int[] devicedata = new int[238];
                byte[] devicedata = new byte[238];
                for (int i = 0; i < 238; i++, CtrToStart++)
                {
                    //byteval = Common.DeciamlToHexadeciaml1(Convert.ToInt32(MainArr[CtrToStart].ToString()));
                    //ival = Common.HexadecimaltoDecimal(byteval);
                    //devicedata[i] = ival;   
                    devicedata[i] = MainArr[CtrToStart];

                }

                GetDevicestructure(devicedata);
                // CtrToStart = 248;
                //Reading ch1 float FFT[size] or int   F(t)[size] ---- CH1 or range of functions. time
                CtrToStart = 248;
                fs = new byte[Buf2];
                byteval = null;
                //int[] CH1 = new int[Buf2];
                //List<float> CH1 = new List<float>();
                YData = new double[Number_Of_Spectrum];
                for (int i = 0; i < Number_Of_Spectrum; i++)
                {
                    //byteval = Common.DeciamlToHexadeciaml1(Convert.ToInt32(MainArr[CtrToStart].ToString()));
                    //ival = Common.HexadecimaltoDecimal(byteval);
                    //CH1[i] = ival;
                    
                    float fabc = BytetoFloat(MainArr, CtrToStart);

                    YData[i] = Convert.ToDouble(fabc);
                    //CH1.Add(fabc);
                    CtrToStart += 4;

                }
                
                //Reading ch2 float FFT[size] or int   F(t)[size] ---- Channel2 range or function. time
                CtrToStart = 248 + Buf2;
                fs = new byte[Buf3];
                byteval = null;
                int[] CH2 = new int[Buf3];
                for (int i = 0; i < Buf3; i++, CtrToStart++)
                {
                    byteval = Common.DeciamlToHexadeciaml1(Convert.ToInt32(MainArr[CtrToStart].ToString()));
                    ival = Common.HexadecimaltoDecimal(byteval);
                    CH2[i] = ival;
                }
            }
            catch (Exception ex)
            {
            }
        }

        /// <summary>
        /// Get the Float value from the byte array
        /// </summary>
        /// <param name="MainArr"></param>
        /// <param name="CtrToStart"></param>
        /// <returns></returns>
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

        double HighestFrequency = 0;
        int Number_Of_Spectrum = 0;

        double[] XData = null;
        double[] YData = null;
        double[] YData_A = null;
        double[] YData_V = null;
        double[] YData_S = null;

        float RMS_A = 0;
        float RMS_V = 0;
        float RMS_S = 0;

        private void GetDevicestructure(byte[] devicedata)
        {
            int ctrStructure = 0;
            try
            {
                //Read RMS
                _RMS = BytetoFloat(devicedata, ctrStructure);

                //Read P_P
                ctrStructure = 12;
                _P_P = BytetoFloat(devicedata, ctrStructure);

                //Read dF
                ctrStructure = 24;
                _dF = Math.Round(Convert.ToDouble(BytetoFloat(devicedata, ctrStructure)), 3);

                //Read Window
                ctrStructure = 54;
                _Window = Convert.ToInt32(devicedata[ctrStructure].ToString());

                //Read pwr2
                ctrStructure = 57;
                _pwr2 = Convert.ToInt32(devicedata[ctrStructure].ToString());

                //Read Measurement
                ctrStructure = 58;
                _Measurement = Convert.ToInt32(devicedata[ctrStructure].ToString());

                //Read channel A
                ctrStructure = 61;
                _ChnlA = Convert.ToInt32(devicedata[ctrStructure].ToString());
                
                if(_Measurement==0) // For Time
                {
                    Number_Of_Spectrum = 1 << _pwr2;
                }
                else if (_Measurement == 1) // For FFT
                {
                    Number_Of_Spectrum = (1 << (_pwr2 - 6)) * 25;
                }

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


                //Read Low Frequency Cut Off
                ctrStructure = 76;
                _Amphpf = Convert.ToInt32(devicedata[ctrStructure].ToString());


                //Read Carrier for channel
                ctrStructure = 79;
                _Ampenvcr = Convert.ToInt32(devicedata[ctrStructure].ToString());


                //Read Transducer factor/Sensitivity
                ctrStructure = 90;
                _Sens = BytetoFloat(devicedata, ctrStructure);


            }
            catch (Exception ex)
            {
            }
        }
    }
}
