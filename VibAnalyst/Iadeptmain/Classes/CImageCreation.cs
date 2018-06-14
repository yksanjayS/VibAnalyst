using System;
using System.Collections.Generic;
using System.Text;
using Aladdin.HASP;
using Aladdin.Hasp;

namespace Iadeptmain.Classes
{
    public sealed class CImageCreation
    {
        Hasp m_objHasp = null;
        Hasp m_objHasp1 = null;
        HaspFeature m_objHaspFeature = HaspFeature.FromFeature(10);
        HaspFeature m_objHaspFeature1 = HaspFeature.FromFeature(1);
        private bool m_bAcknowledgement = false;
        private int m_iAuth1 = 6830;
        private int m_iAuth2 = 8503;
        private int m_iSC = 0;
        private int m_iPt = 0;

        private const string SCONSTTEST = "595963602115624431633213621186596218641133591530639169591499595962631564602109613131574176603782572214613166635111597210645185642796632111643136566248588115621845571184624109599664639145629506579955603195609315642171596146605495613181574189631255597172628119571990620579643111604165628776608674574190599187636456577197570116612112629166601417571295601188605709599152593163633421602103571119580455590468590901593100571495593146633164593199600136604184596136571175577125597130594127572985639681629117621206628941631998641681598107609121566149590167634116601761620110633374633768640130613159611194573169593651599141566192575624570871644225637607608606605146608990572561633206605165604605623187571145636459633502597911638193576192627154597183624851574523621298570883596889589990635107628982599159577327596580589624574172580291572549589119599716597390637742574175609225631173640175621100590155628138572106633309613798641687591175604192637125633172592107633101623572596148607186579176594386571801608111613173597173634212639150589116603205633145603152627195574184578193636160600126591912645144641727605165631206588770598184605152625722641804599151609214604136636448579623622137611672588458640136579217612617578221609141577175572123575205630399613149597693578194639756608147622119588195602133592127588761570210629184566176593197627174589101596928571614580155634194580160579830640148597127622138633561612138604646571890598259611552575423626136609370591840642829645920637728594397612202642155604125594149573612608461643763595175580393623102598115576489571170597107607112600938577661612545600671637833573912589877635131630445566125609209599193627182601139598113577911605927632199590574644281595386608349578148639168603816580625644955609995638177638188600168641991642149636204623158579178573284636249638204620127596114624246598814578244642403603673620108571360600141592112571106580290574113570794644187632589633132580100622200605208641210571203613168573711600171622136636440628192628196603951636627603199579304589144594128605139643168596123574127622142580168643595604173607165592818579139578200643699611175632990639100605142576395637183593131598126606706590102630678624118580233622130579547626458571163597122622213642183631165605173588105596869610187570185620666642150574297621293639204612320570150574188613175621969643209637135636159643618570129570228573158629157570560592944641205573386595486576127566258640174631140596170611118632589588208590914575169571683595116590195591963606677608209591358626182625491640169630172575507577279592177606151595170594163628152611162598167571178621194624279603145602117566347588295613105590133642699612116570103602118577180571911571159596319606120636903588136637201635417574156600834632470610765580189601212627204628612609170571437602462580138639205624882627888632497590193621673598206601144589485633194633538642692600147623618644861595206590138631428601139606252608147580136642383579159637988591406639256608322632116621726590114601723604570621194645189612290635709641196576141571230633145645902574207634177643295580192580144602127624125577212624137590127608118611209592206608690606498622144636165626153633416607173599280633190566795573196642121638167608865570832620135626156636116640116627944644569597143574758608129622121597111641112574121621118588149594201589168612360592202620120599167623141625313579202578196645186603621605172630977636481638180574191593409606426620770644195594112594229613141622149636140576188641144598445636421632143642528606123571408629923632279608190566179623180607130639208644124632127643135589122578209607126633192609816570155613134595718624784633418595168642190643165576109572537645195600193637127644201636160578525622133634152589191630539591201621204580123636752566127592831626709626981604817636183639154601143625210637147642103641122573716592189633821613868629116629767572813602125642200591151612816577138627181599827641204622566577149576187641614644165629122588211577166626173595977570925613841635911639114611180612197589194642975580383631195637159622708637104600103591158572123624101636900604190576147579147632131607213592288608977604794613231633861599152578456599750611230633123588203644239624207645204611112592192576167640102588406634143574101621451635200645453571837644118601427632202632121605189590172637164597176627850591622603163577101579174571108620159637379604120588136642162645115604797603165574132599904622707593230632114571106607202637111626198629112608341636154634182630110621194608168609479606166604388566625611122636142633209622132572207621208635960575105611196642123605382604144629405634167570124570144642505640166609579613580632188643187566785623119594672573207604140592491643577633166612880571210566764609171642433643204604954573152603300611119642109639969630130643745609737607104624150633155643200591502613117606957580108573195579887610149580640620906608653606186637688595468571477607291624358577421604683622201593123630134641491634112590136588152597471574916612571603398626453621177604854605124609636626746634488573207631102580956623143576108570140611487608874574578641510630178606491602101588387605316620357573163641106566658590118622553580173593170613148600211634920590600620453644102639101603159643197623402602195578435641154599187571584606149604208635442609249639790607101638830599424638170574179627136632142572137627180631212588628603433633333575147575161635145609168630808566174629200626171600106593195613884612121638209620922579630576104589914596723595171627195638947566682628653588169629136598948609316606174594179612141642200590340574151601101570665627254600127624212609127640846598396625122622209604102622336642490622184623136575791607323577141604140584493";
        public static string Vcode = null;
      
        public CImageCreation()
        {
            m_objHasp = new Hasp(m_objHaspFeature);
            m_objHasp1 = new Hasp(m_objHaspFeature1);

        }
        public  string decrypt(string s)
        {
            try
            {
                string r = "";

                for (int c = 0; c < s.Length; c += 6)
                {
                    int no = Convert.ToInt32(s.Substring(c, 3)) - 523;
                    byte curchar = Convert.ToByte(no.ToString());
                    r += (char)curchar;
                }
                Vcode = r;
                return r;
            }
            catch (Exception mex)
            {
                return "";
            }

        }
        public void FirstTest(byte[] Param1)
        {
            try
            {
                if (m_objHasp != null)
                    m_objHasp.Encrypt(Param1);
                if(m_objHasp1!=null)
                    m_objHasp1.Encrypt(Param1);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message, ex.StackTrace);
            }
        }

        public void FirstTest(double[] Param1)
        {
             
            try
            {
                if (m_objHasp != null && m_objHasp1!=null)
                {
                    HaspStatus objStatus = m_objHasp.Login(decrypt(SCONSTTEST));
                    HaspStatus objStatus1 = m_objHasp1.Login(decrypt(SCONSTTEST));
                    if (HaspStatus.AlreadyLoggedIn == objStatus)
                        m_objHasp.Logout();
                    if(HaspStatus.StatusOk!=objStatus && HaspStatus.AlreadyLoggedIn == objStatus)
                        m_objHasp.Login(decrypt(SCONSTTEST));
                    if (HaspStatus.AlreadyLoggedIn == objStatus1)
                        m_objHasp1.Logout();
                    if (HaspStatus.StatusOk != objStatus && HaspStatus.AlreadyLoggedIn == objStatus1)
                        m_objHasp1.Login(decrypt(SCONSTTEST));
                    
                    m_objHasp.Encrypt(Param1);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message, ex.StackTrace);
            }
        }

        public bool Test(string sText)
        {
            bool bTest = false;
            try
            {
                if (sText == "Second")
                {
                    bTest = NewTest();
                }
                return bTest;
            }
            catch (Exception ex)
            {
                return bTest;
                System.Diagnostics.Debug.WriteLine(ex.Message, ex.StackTrace);
            }
        }

        
            private bool NewTest()
        {
            int iRlt = 0;
            int iSts = 0;
            bool bRetRes = false;

            try
            {
                object oConvRlt = (object)iRlt;
                object oConvSts = (object)iSts;

                HaspKey.Hasp(HaspService.IsHasp4, m_iSC, m_iPt, m_iAuth1, m_iAuth2, oConvRlt, null, oConvSts, null);
                

                iRlt = (int)oConvRlt;

                if (iRlt == 1 )
                {

                    
                    bRetRes = true;
                }
                else if(iRlt!=1)
                {
                    bRetRes = false;
                }

                return bRetRes;
                
            }
            catch (Exception ex)
            {
                return bRetRes;
                
            }
        }

        private bool GetAndCheck()
        {
            bool bCheckID = false;
            int idLw = 0;
            int idHgh = 0;
            int iSts = 0;

            try
            {

                object oConvidLw = (object)idLw;
                object oConvidHigh = (object)idHgh;
                object oConvSts = (object)iSts;

                HaspKey.Hasp(HaspService.HaspID,
                m_iSC,
                m_iPt,
                m_iAuth1,
                m_iAuth2,
                oConvidLw,
                oConvidHigh,
                oConvSts,
                null);

                idLw = (int)oConvidLw;
                idHgh = (int)oConvidHigh;

                int iNewOne = idHgh + idLw;

                if (iNewOne == 22545)
                    bCheckID = true;
                else
                    bCheckID = false;

                return bCheckID;

            }
            catch (Exception ex)
            {
                return bCheckID;

            }
        }

        public bool Check(byte[] Param1)
        {
            int iFirst = 0;
            int iSecond = 0;
            int iThird = 0;
            bool bEnc = false;

            try
            {
                iSecond = Param1.Length;

                object objSecConv = (object)iSecond;
                object objThirdConv = (object)iThird;

                HaspKey.Hasp(HaspService.EncodeData, m_iSC, m_iPt, m_iAuth1, m_iAuth2, null, objSecConv, objThirdConv, Param1);

                iThird = (int)objThirdConv;
                if (iThird == 0)
                {
                    bEnc = true;
                }
                else
                    bEnc = false;

                return bEnc;
            }
            catch (Exception ex)
            {
                return bEnc;

            }
        }

        public bool UnCheck(byte[] Param2)
        {
            int iFirst = 0;
            int iSecond = 0;
            int iThird = 0;
            bool bEnc = false;

            try
            {
                iSecond = Param2.Length;

                object objSecConv = (object)iSecond;
                object objThirdConv = (object)iThird;

                HaspKey.Hasp(HaspService.DecodeData, m_iSC, m_iPt, m_iAuth1, m_iAuth2, null, objSecConv, objThirdConv, Param2);


                iThird = (int)objThirdConv;
                if (iThird == 0)
                {
                    bEnc = true;
                }
                else
                    bEnc = false;

                return bEnc;
            }
            catch (Exception ex)
            {
                return bEnc;

            }
        }

        public bool SecondTest(byte[] Param2)
        {
            
            try
            {
                if (m_objHasp != null && m_objHasp1 != null)
                {
                    m_objHasp.Logout();
                    m_objHasp1.Logout();
                    HaspStatus objStatus = m_objHasp.Login(decrypt(SCONSTTEST));
                    HaspStatus objStatus1 = m_objHasp1.Login(decrypt(SCONSTTEST));
                    if (HaspStatus.StatusOk == objStatus || HaspStatus.StatusOk == objStatus1 || HaspStatus.AlreadyLoggedIn == objStatus || HaspStatus.AlreadyLoggedIn == objStatus1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                return m_bAcknowledgement;
                System.Diagnostics.Debug.WriteLine(ex.Message, ex.StackTrace);
            }
        }

        public bool SecondTest(double[] Param2)
        {

            try
            {
                if (m_objHasp != null)
                {
                    HaspStatus objStatus = m_objHasp.Login(decrypt(SCONSTTEST));
                    HaspStatus objDecryption = m_objHasp.Decrypt(Param2);

                    if (HaspStatus.StatusOk == objStatus && HaspStatus.StatusOk == objDecryption)
                    {
                        m_bAcknowledgement = true;
                    }
                }

                return m_bAcknowledgement;

            }
            catch (Exception ex)
            {
                return m_bAcknowledgement;
                System.Diagnostics.Debug.WriteLine(ex.Message, ex.StackTrace);
            }
        }

        public byte[] GetBytes()
        {
            string sConvertedGuid = null;
            byte[] arrBytesToReturn=null;

            try
            {
                Guid objGuid = Guid.NewGuid();

                if (objGuid != null)
                {
                    sConvertedGuid = objGuid.ToString();
                    arrBytesToReturn=Encoding.ASCII.GetBytes(sConvertedGuid);
                }
                return arrBytesToReturn;

            }//end(try)
            catch (Exception ex)
            {
                return arrBytesToReturn;
                System.Diagnostics.Debug.WriteLine(ex.Message, ex.StackTrace);
            }
        }

        public double[] GetDouble()
        {
            string sConvertedGuid = null;
            double[] arrBytesToReturn = null;
            char[] carrCharacters = null;

            try
            {
                Guid objGuid = Guid.NewGuid();

                if (objGuid != null)
                {
                    sConvertedGuid = objGuid.ToString();
                    carrCharacters=sConvertedGuid.ToCharArray();
                    arrBytesToReturn=new double[carrCharacters.Length];
                    for (int iCtr = 0; iCtr < carrCharacters.Length - 1; iCtr++)
                    {
                        
                        arrBytesToReturn[iCtr]=Convert.ToDouble(carrCharacters[iCtr]);
                    }
                }
                return arrBytesToReturn;

            }//end(try)
            catch (Exception ex)
            {
                return arrBytesToReturn;
                System.Diagnostics.Debug.WriteLine(ex.Message, ex.StackTrace);
            }
        }


    }
}
