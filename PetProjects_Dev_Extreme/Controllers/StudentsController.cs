using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using PetProjects_Dev_Extreme.Models;

namespace PetProjects_Dev_Extreme.Controllers
{
    [Route("[controller]")]
    public class StudentsController : Controller
    {
        private MyDbContext _context;

        public StudentsController(MyDbContext context) {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get(DataSourceLoadOptions loadOptions) {
            var students = _context.students.Select(i => new {
                i.SchedulerID,
                i.DoB,
                i.Name,
                i.Address,
                i.ClassStudent,
                i.Maths,
                i.Physical,
                i.Chemistry,
                i.Medium
            });

            // If underlying data is a large SQL table, specify PrimaryKey and PaginateViaPrimaryKey.
            // This can make SQL execution plans more efficient.
            // For more detailed information, please refer to this discussion: https://github.com/DevExpress/DevExtreme.AspNet.Data/issues/336.
            // loadOptions.PrimaryKey = new[] { "SchedulerID" };
            // loadOptions.PaginateViaPrimaryKey = true;

            return Json(await DataSourceLoader.LoadAsync(students, loadOptions));
        }

        [HttpPost("Insert")]
        public async Task<IActionResult> Post(string values) {
            var model = new Student();
            var valuesDict = JsonConvert.DeserializeObject<IDictionary>(values);
            PopulateModel(model, valuesDict);

            if(!TryValidateModel(model))
                return BadRequest(GetFullErrorMessage(ModelState));

            var result = _context.students.Add(model);
            await _context.SaveChangesAsync();

            return Json(new { result.Entity.SchedulerID });
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Put(int key, string values) {
            var model = await _context.students.FirstOrDefaultAsync(item => item.SchedulerID == key);
            if(model == null)
                return StatusCode(409, "Object not found");

            var valuesDict = JsonConvert.DeserializeObject<IDictionary>(values);
            PopulateModel(model, valuesDict);

            if(!TryValidateModel(model))
                return BadRequest(GetFullErrorMessage(ModelState));

            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete]
        public async Task Delete(int key) {
            var model = await _context.students.FirstOrDefaultAsync(item => item.SchedulerID == key);

            _context.students.Remove(model);
            await _context.SaveChangesAsync();
        }


        private void PopulateModel(Student model, IDictionary values) {
            string SCHEDULER_ID = nameof(Student.SchedulerID);
            string DO_B = nameof(Student.DoB);
            string NAME = nameof(Student.Name);
            string ADDRESS = nameof(Student.Address);
            string CLASS_STUDENT = nameof(Student.ClassStudent);
            string MATHS = nameof(Student.Maths);
            string PHYSICAL = nameof(Student.Physical);
            string CHEMISTRY = nameof(Student.Chemistry);
            string MEDIUM = nameof(Student.Medium);

            //if(values.Contains(SCHEDULER_ID)) {
            //    model.SchedulerID = Convert.ToInt32(values[SCHEDULER_ID]);
            //}

            if(values.Contains(DO_B)) {
                model.DoB = Convert.ToDateTime(values[DO_B]);
            }

            if(values.Contains(NAME)) {
                model.Name = Convert.ToString(values[NAME]);
            }

            if(values.Contains(ADDRESS)) {
                model.Address = Convert.ToString(values[ADDRESS]);
            }

            if(values.Contains(CLASS_STUDENT)) {
                model.ClassStudent = Convert.ToString(values[CLASS_STUDENT]);
            }

            if(values.Contains(MATHS)) {
                model.Maths = Convert.ToInt32(values[MATHS]);
            }

            if(values.Contains(PHYSICAL)) {
                model.Physical = Convert.ToInt32(values[PHYSICAL]);
            }

            if(values.Contains(CHEMISTRY)) {
                model.Chemistry = Convert.ToInt32(values[CHEMISTRY]);
            }

            if(values.Contains(MEDIUM)) {
                model.Medium = Convert.ToInt32(values[MEDIUM]);
            }
        }

        private string GetFullErrorMessage(ModelStateDictionary modelState) {
            var messages = new List<string>();

            foreach(var entry in modelState) {
                foreach(var error in entry.Value.Errors)
                    messages.Add(error.ErrorMessage);
            }

            return String.Join(" ", messages);
        }
    }
}