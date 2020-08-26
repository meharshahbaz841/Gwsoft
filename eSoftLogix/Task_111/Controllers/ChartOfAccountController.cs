using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Task_111.Context;
using Task_111.Models;

namespace Task_111.Controllers
{
    public class ChartOfAccountController : Controller
    {
        private readonly Data_Context _db;
        public ChartOfAccountController(Data_Context db)
        {
            _db = db;
        }  

        public IActionResult Index()
        {
            return View();
        } 

        public IActionResult Showtree()
        {
            return PartialView("~/Views/ChartOfAccount/_Showtree.cshtml");
        }
        public JsonResult tree()
        {
            List<Treenode> node = new List<Treenode>();          
            // Parent node          
            foreach (var item in _db.GL_CONTROL_ACCOUNTs.Where(x=>x.PARENT_CONTROL_ACCOUNT_ID==0).ToList())
            {
                node.Add(new Models.Treenode { id=item.CHART_OF_ACCOUNT_ID.ToString(), parent = "#", text = item.CHART_OF_ACCOUNT_CODE + "-" + item.DESCRIPTION});
            }        
            // child node 
            foreach (var item in _db.GL_CONTROL_ACCOUNTs)
            {
                node.Add(new Models.Treenode { id = item.CHART_OF_ACCOUNT_ID.ToString(), parent = item.PARENT_CONTROL_ACCOUNT_ID.ToString(), text = item.CHART_OF_ACCOUNT_CODE + "-" + item.DESCRIPTION });
            }
            //nested child node
            foreach (var item in _db.GL_CHART_OF_ACCOUNTs)
            {
                node.Add(new Treenode
                {
                    id = item.GL_C_ACCOUNT_id.ToString()+"-"+item.CONTROL_ACCOUNT_ID.ToString(),
                    parent = item.GL_C_ACCOUNT_id.ToString(),
                    text =item.CONTROL_ACCOUNT_CODE.ToString() + "-" + item.DESCRIPTION
                });
            }            
            return Json(node, new JsonSerializerSettings());
        }
        //Delete Data Start From Here...
        public IActionResult DeleteParentNode(int id)
        {
            //Delete Data From Control Account
            var found = _db.GL_CONTROL_ACCOUNTs.Find(id);    
            var c = _db.GL_CONTROL_ACCOUNTs.Where(x => x.PARENT_CONTROL_ACCOUNT_ID == found.CHART_OF_ACCOUNT_ID).Count();
            var C_Count = _db.GL_CHART_OF_ACCOUNTs.Where(x => x.GL_C_ACCOUNT_id == found.CHART_OF_ACCOUNT_ID).Count();
            if (found!=null && c==0 && C_Count==0)
            {
                
                _db.GL_CONTROL_ACCOUNTs.Remove(found);
                _db.SaveChanges();
            }
            return new JsonResult("Delete Successfully");
            //return Redirect("/Home/ChartAccountsList");
        }
        public IActionResult DeleteNode(int id)
        {
            //Delete Data From Chart Account
            var found = _db.GL_CHART_OF_ACCOUNTs.Where(x => x.CONTROL_ACCOUNT_ID == id).FirstOrDefault();
            if (found!=null)
            {
                _db.GL_CHART_OF_ACCOUNTs.Remove(found);
                _db.SaveChanges();
            }

           // return Ok(200);
            return Redirect("/Home/ChartAccountsList");
        }
        // Add Control Account Start here
        [HttpGet]
        public IActionResult AddControlAccount(int id)
        {
            GL_CONTROL_ACCOUNTS model = new GL_CONTROL_ACCOUNTS();
            model.PARENT_CONTROL_ACCOUNT_ID = id;
            return PartialView("~/Views/ChartOfAccount/_AddControlAccount.cshtml",model);
        }
        [HttpPost]
        public IActionResult AddControlAccount(int id, string desc)
        {
            var parent = _db.GL_CONTROL_ACCOUNTs.Find(id);
            var getchild = _db.GL_CONTROL_ACCOUNTs.Where(x => x.PARENT_CONTROL_ACCOUNT_ID == id).Count();
            GL_CONTROL_ACCOUNTS obj = new GL_CONTROL_ACCOUNTS();
            // Find Lavel 
            var lavel = CheckLavel(id);
            
            if (lavel>=3)
            {
                AddChartAccount(id, desc);
               // return new JsonResult("Add Succesfully");
                return Redirect("/Home/ChartAccountsList");

            }
            if (getchild==0)
            {
                obj.CHART_OF_ACCOUNT_CODE = parent.CHART_OF_ACCOUNT_CODE + "" + 1.ToString("D2");
            }
            else
            {
                var Child_Code = _db.GL_CONTROL_ACCOUNTs.Where(x => x.PARENT_CONTROL_ACCOUNT_ID == id).Max(x => x.CHART_OF_ACCOUNT_CODE);
               // obj.CHART_OF_ACCOUNT_CODE = parent.CHART_OF_ACCOUNT_CODE + "" + (Convert.ToInt32(Child_Code) + 1).ToString("D2");
                obj.CHART_OF_ACCOUNT_CODE =(Convert.ToInt32(Child_Code) + 1).ToString("D2");

            }

            obj.PARENT_CONTROL_ACCOUNT_ID = id;
            obj.DESCRIPTION = desc;
            Random n = new Random();
            int num = n.Next(100);
            obj.CREATED_BY = 1;
            obj.CREATION_DATE = DateTime.Now;
            obj.Lavel = lavel;
            _db.GL_CONTROL_ACCOUNTs.Add(obj);
            _db.SaveChanges();

            //return StatusCode(200);
            return Redirect("/Home/ChartAccountsList");

        }      

        // Add Chart Account Start From Here....
        [HttpGet]
        public IActionResult AddChartAccount(int id)
        {                   
            GL_CHART_OF_ACCOUNTS model = new GL_CHART_OF_ACCOUNTS();
            model.GL_C_ACCOUNT_id = id;                       
            return PartialView("~/Views/ChartOfAccount/_AddChartAccount.cshtml",model);
        }

        [HttpPost]
        public IActionResult AddChartOfAccount(int id, string desc)
        {


            AddChartAccount(id, desc);

            //GL_CHART_OF_ACCOUNTS obj = new GL_CHART_OF_ACCOUNTS();
            //Random n = new Random();
            // int num=  n.Next(100);

            //obj.DESCRIPTION = desc;             
            //obj.GL_C_ACCOUNT_id = id;
            //obj.CONTROL_ACCOUNT_CODE = num.ToString();
            //obj.CREATED_BY = 1;
            //obj.CREATION_DATE = DateTime.Now;
            //_db.GL_CHART_OF_ACCOUNTs.Add(obj);
            //_db.SaveChanges();

            return Redirect("/Home/ChartAccountsList");
        }

        // Control Account Update Start from here....
        public IActionResult UpdateControlAccount(int id)
        {
            GL_CONTROL_ACCOUNTS data =_db.GL_CONTROL_ACCOUNTs.Find(id);          
            return PartialView("~/Views/ChartOfAccount/_UpdateContorlAccount.cshtml",data);
        }
        [HttpPost]
        public IActionResult UpdateControlAccount(int id,string desc)
        {
            GL_CONTROL_ACCOUNTS data = _db.GL_CONTROL_ACCOUNTs.Find(id);
         
            if (data!=null)
            {
                data.DESCRIPTION = desc;
                _db.Entry(data).State = EntityState.Modified;
                _db.SaveChanges();
            }
            return Redirect("/Home/ChartAccountsList");
        }  

         // Chart Account Update Start from here....
        [HttpGet]
        public IActionResult UpdateChartAccount(int id)
        {
            GL_CHART_OF_ACCOUNTS data = _db.GL_CHART_OF_ACCOUNTs.Find(id);
            return PartialView("~/Views/ChartOfAccount/_EditChartAccount.cshtml", data);
        } 
        [HttpPost]
        public IActionResult UpdateChartAccount(int id,string desc)
        {
            GL_CHART_OF_ACCOUNTS data = _db.GL_CHART_OF_ACCOUNTs.Find(id);

            if (data!=null)
            {
                data.DESCRIPTION = desc;
                _db.Entry(data).State = EntityState.Modified;
                _db.SaveChanges();
            }
            return Redirect("/Home/ChartAccountsList");
        } 

        [HttpGet]
        public IActionResult AddControl(int id)
        {
            var model = new GL_CONTROL_ACCOUNTS();
            model.CHART_OF_ACCOUNT_ID = id;

            return PartialView("~/Views/ChartOfAccount/_AddContorlSubling.cshtml",model);
        }
        [HttpPost]
        public IActionResult AddControl(int id ,string desc)
        {
            var IS = _db.GL_CONTROL_ACCOUNTs.Where(x => x.PARENT_CONTROL_ACCOUNT_ID == null || x.PARENT_CONTROL_ACCOUNT_ID == 0).Max(x => x.CHART_OF_ACCOUNT_CODE);           
            GL_CONTROL_ACCOUNTS obj = new GL_CONTROL_ACCOUNTS();
            Random n = new Random();
            int num = n.Next(10);
            var f = _db.GL_CONTROL_ACCOUNTs.Find(id);
            var p = _db.GL_CONTROL_ACCOUNTs.Find(f.PARENT_CONTROL_ACCOUNT_ID);

            if (f!=null)
            {
                var pid = f.PARENT_CONTROL_ACCOUNT_ID;
                if (pid==null ||pid==0)
                {
                    obj.PARENT_CONTROL_ACCOUNT_ID = 0;
                    obj.CHART_OF_ACCOUNT_CODE = (Convert.ToInt32(IS) + 1).ToString();
                }
                else
                {
                    var SubCode = _db.GL_CONTROL_ACCOUNTs.Where(x => x.PARENT_CONTROL_ACCOUNT_ID == p.CHART_OF_ACCOUNT_ID).Max(x => x.CHART_OF_ACCOUNT_CODE);
                    obj.PARENT_CONTROL_ACCOUNT_ID = pid;
                    //obj.CHART_OF_ACCOUNT_CODE = p.CHART_OF_ACCOUNT_CODE + "" + (Convert.ToInt32(SubCode) + 1).ToString();
                    obj.CHART_OF_ACCOUNT_CODE =(Convert.ToInt32(SubCode) + 1).ToString();
                }
                obj.DESCRIPTION = desc;                
                obj.CREATED_BY = 1;
                obj.CREATION_DATE = DateTime.Now;
                 obj.Lavel = f.Lavel;
                _db.GL_CONTROL_ACCOUNTs.Add(obj);
                _db.SaveChanges();
            }

            return Redirect("/Home/ChartAccountsList");
        }      
        public  void AddChartAccount(int Id, string Discription)
        {
            var parent = _db.GL_CONTROL_ACCOUNTs.Find(Id);
            var count = _db.GL_CHART_OF_ACCOUNTs.Where(x => x.GL_C_ACCOUNT_id == Id).Count();
            GL_CHART_OF_ACCOUNTS obj = new GL_CHART_OF_ACCOUNTS();
            if (count==0)
            {
                obj.CONTROL_ACCOUNT_CODE = parent.CHART_OF_ACCOUNT_CODE + "" + 1.ToString().PadLeft(3, '0');
            }
            else
            {
                var GetChild = (from c in _db.GL_CHART_OF_ACCOUNTs.Where(x => x.GL_C_ACCOUNT_id == Id) select c).Max(x => x.CONTROL_ACCOUNT_CODE);
                    obj.CONTROL_ACCOUNT_CODE =(Convert.ToInt32(GetChild) + Convert.ToInt32( 1.ToString().PadLeft(3, '0'))).ToString();
            }            
            obj.DESCRIPTION = Discription;
            obj.GL_C_ACCOUNT_id = Id;
            obj.CREATED_BY = 1;
            obj.CREATION_DATE = DateTime.Now;
            _db.GL_CHART_OF_ACCOUNTs.Add(obj);
            _db.SaveChanges();
        }
        public int CheckLavel(int id)
        {
            var found = _db.GL_CONTROL_ACCOUNTs.Find(id);
            if (found.Lavel == null || found.Lavel == 0)
            {
                return 1;
            }
            if (found.Lavel == 1)
            {
                return 2;
            }
            if (found.Lavel == 2)
            {
                return 3;
            }
            return 0;
        }


    }
}
