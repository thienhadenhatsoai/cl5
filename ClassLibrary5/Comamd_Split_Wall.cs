using Autodesk.Revit.DB;
using Autodesk.Revit.UI.Selection;
using ClassLibrary5.OPP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.UI;
using Autodesk.Revit.Attributes;
using System.Data;
using System.Windows.Forms;

namespace ClassLibrary5
{
    [TransactionAttribute(TransactionMode.Manual)]

    class Comamd_Split_Wall : IExternalCommand
    {
        public class MassSelectionFilter : ISelectionFilter
        {
            public bool AllowElement(Element element)
            {
                //壁
                if (element.Category.Name == "Walls" || element.Category.Name == "Lines" || element.Category.Name == "線分" || element.Category.Name == "Doors" || element.Category.Name == "壁" || element.Category.Name == "ドア")
                {
                    return true;
                }
                return false;
            }

            public bool AllowReference(Reference refer, XYZ point)
            {
                return false;
            }
        }

        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            //    List<Element> SelectWalls()
            //{
            UIDocument uidoc = commandData.Application.ActiveUIDocument;
            //UiDocument uidoc = commandData.Application.ActiveUIDocument;
            Document doc = uidoc.Document;

            MassSelectionFilter selectionFilter = new MassSelectionFilter();
                List<Element> selectedElement = new List<Element>();
                try
                {
                    // Tạo một Selection object trống
                    Selection selection = uidoc.Selection;
                    selection.SetElementIds(new List<ElementId>());

                    // Sử dụng PickObjects để chọn các đối tượng
                    IList<Reference> references = uidoc.Selection.PickObjects(ObjectType.Element, selectionFilter, "Select by rectangle");

                    // Lấy danh sách các đối tượng đã chọn
                    List<ElementId> selectedElementIds = references.Select(r => r.ElementId).ToList();
                    selection.SetElementIds(selectedElementIds);
                    for (int i = 0; i < selectedElementIds.Count; i++)
                    {
                        selectedElement.Add(doc.GetElement(selectedElementIds[i]));
                    }
             
                foreach (Element element in selectedElement)
                    {
                 
                    cls_Wall wal = new cls_Wall();
                    wal.Number = element.Id.ToString();
                    wal.Name = element.Name;
                    //wal.Height = element.get_Parameter(BuiltInParameter.WALL_USER_HEIGHT_PARAM).AsDouble();
                    //wal.Width = element.get_Parameter(BuiltInParameter.WALL_ATTR_WIDTH_PARAM).AsDouble();
                    //wal.Length = element.get_Parameter(BuiltInParameter.CURVE_ELEM_LENGTH).AsDouble();
                    cls_Bien.listWall.Add(wal);
                    }

                form_wall_dgr form_wall = new form_wall_dgr();
                form_wall.Show();

                //List<cls_Wall> sortwallsstandard = new List<cls_Wall>();
                //cls_Wall obj = new cls_Wall();
                //int index = 1; 
                //foreach (Element element in selectedElement)
                //{
                //    cls_Wall obwall = sortwallsstandard[index];

                //    cls_Wall obwall = new cls_Wall();
                //    obwall.Elementwall = element;
                //    obwall.Line = line;
                //    obwall.StartPoint = stPoint;
                //    obwall.EndPoint = endpoint;
                //    obwall.Obwall = pickedwall;
                //    obwall.Height = walHeight;
                //    obwall.Width = wallLength.ToString();
                //    obwall.Name = element.Name;
                //    obwall.Level = thinkness.ToString();
                //    obwall.Number = (cls_Bien.ObSplitwall.Listwall.Count + 1).ToString();
                //    obwall.Inner = mat.Materialcategory.ToString();
                //    obwall.Solid = solid;
                //    obwall.LstModelLine = lstline;

                //    sortwallsstandard.Add(obwall);
                //}

                //foreach (Element element in selectedElementIds)
                //sortwallsstandard.Add(obj);

                return Result.Succeeded;
                }
                catch (Exception ex)
                {
                 message = ex.Message;
                return Result.Failed;
                }


        }
     
    }
 

}
    