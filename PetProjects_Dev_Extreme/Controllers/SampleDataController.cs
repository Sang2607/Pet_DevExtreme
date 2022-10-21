using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
    
using PetProjects_Dev_Extreme.Models;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace PetProjects_Dev_Extreme.Controllers {

    [Route("api/[controller]")]
    public class SampleDataController : Controller {
        MyDbContext _myDbContext;
        public SampleDataController(MyDbContext myDbContext)
        {
            this._myDbContext = myDbContext;
        }

        [HttpGet]
        public IActionResult Get(DataSourceLoadOptions loadOptions)
        {
            var toList = _myDbContext.students.Select(i => new
            {
                i.Name,
                i.Address,
                i.SchedulerID,
                i.Maths,
                i.ClassStudent,
                i.Chemistry,
                i.DoB,
                i.Medium,
            });
            return Json(DataSourceLoader.Load(toList, loadOptions));
        }



        //[HttpPost]
        //public IActionResult Insert(string values)
        //{
        //    var newStudent = new Student();
        //    JsonConvert.PopulateObject(values, newStudent);

        //    if (!TryValidateModel(newStudent))
        //        return BadRequest(ModelState.GetFullErrorMessage());

        //    _myDbContext.students.Add(newStudent);
        //    _myDbContext.SaveChanges();

        //    return Ok(newStudent);
        //}



        //[HttpPut]
        //public IActionResult Update(int key, string values)
        //{
        //    var order = _myDbContext.students.First(o => o.SchedulerID == key);
        //    JsonConvert.PopulateObject(values, order);

        //    if (!TryValidateModel(order))
        //        return BadRequest(ModelState.GetFullErrorMessage());

        //    _myDbContext.SaveChanges();

        //    return Ok(order);
        //}

        //[HttpDelete]
        //public void Delete(int key)
        //{
        //    var order = _myDbContext.students.First(o => o.SchedulerID == key);
        //    _myDbContext.students.Remove(order);
        //    _myDbContext.SaveChanges();
        //}


    }
}