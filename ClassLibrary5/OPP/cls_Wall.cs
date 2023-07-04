using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.UI;

namespace ClassLibrary5.OPP
{
    public class cls_Wall
    {
        private Wall m_ObWall;
        private Element m_ElementWall;
        private Element m_ElementPart;
        private string m_Number = "";
        private string m_Name = "";
        private double m_Width = 0;
        private double m_Height = 0;

        private string m_Level = "";
        private double m_Length = 0;

        //private string m_Inner = "";
        //private string m_Outter = "";
        //private double m_Height = 0;
        //private double m_HeightCut = 0;
        //private double m_MaxHeight = 0;
        //private double m_MaxWinHeight = 0;
        //private double m_MinHeight = 0;
        //private double m_MinWinHeight = 0;
        //private double m_MinXML = 0;
        //private double m_MaxXML = 0;
        //private double m_Height1 = 0;
        //private double m_Height2 = 0;
        //private double m_Height3 = 0;
        //private PlanarFace m_BottomFace = null;
        //private Boolean m_RightToLeft = false;
        //private Boolean m_LeftToRight = true;
        ////private cls_Door m_Door = new cls_Door();
        ////private List<cls_Door> m_LstDoor new List<cls_Door>();
        //private List<cls_Wall> m_ListSplitedwal = new List<cls_Wall>();
        //private XYZ m_StartPoint = null;
        //private XYZ m_EndPoint = null;
        //private Line m_Line = null;
        ////Một số thuộc tính phục vụ việc tìm ra hướng chia của tưởng theo quy định
        //private XYZ m_PointMid = null;
        //private XYZ m_PointMax = null;
        //private XYZ m_PointMin = null;
        //private XYZ m_PointExtendMin = null;
        //private XYZ _PointExtendMax = null;
        //private Line m_LineFindwall = null;
        //private XYZ m_VectorFindWall = null;
        //private bool _Parallel0x = true;
        //private Solid m_Solid = null;
        //private string m_CornerStart = "";
        //private string m_CornerEnd = "";

        public string Number
        {
            get
            {
                return m_Number;
            }

            set
            {
                m_Number = value;
            }
        }

        public string Name
        {
            get
            {
                return m_Name;
            }

            set
            {
                m_Name = value;
            }
        }

        public double Width
        {
            get
            {
                return m_Width;
            }

            set
            {
                m_Width = value;
            }
        }

        public string Level
        {
            get
            {
                return m_Level;
            }

            set
            {
                m_Level = value;
            }
        }

        public double Length
        {
            get
            {
                return m_Length;
            }

            set
            {
                m_Length = value;
            }
        }


        public Wall ObWall
        {
            get
            {
                return m_ObWall;
            }

            set
            {
                m_ObWall = value;
            }
        }

        public double Height
        {
            get
            {
                return m_Height;
            }

            set
            {
                m_Height = value;
            }
        }
    }
}
