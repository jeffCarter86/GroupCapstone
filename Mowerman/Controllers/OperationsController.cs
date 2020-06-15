
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Mowerman.Data;
using Mowerman.Models;
using System.Collections;
using System.Web.Helpers;
using Microsoft.ApplicationInsights.AspNetCore;

namespace Mowerman.Controllers
{
    [Authorize(Roles = "Operation")]
    public class OperationsController : Controller
    {

        private readonly ApplicationDbContext _context;



        public OperationsController(ApplicationDbContext context)

        {

            _context = context;

        }



        // GET: Employees

        public async Task<IActionResult> Index()

        {

            //need to come back to this and try to add the system.DayOfWeek to the selectlist maybe with foreach?

            List<SelectListItem> days = new List<SelectListItem>();

            days.Add(new SelectListItem { Text = "Sunday", Value = "0" });

            days.Add(new SelectListItem { Text = "Monday", Value = "1" });

            days.Add(new SelectListItem { Text = "Tuesday", Value = "2" });

            days.Add(new SelectListItem { Text = "Wednesday", Value = "3" });

            days.Add(new SelectListItem { Text = "Thursday", Value = "4" });

            days.Add(new SelectListItem { Text = "Friday", Value = "5" });

            days.Add(new SelectListItem { Text = "Saturday", Value = "6" });

            ViewBag.Day = new SelectList(days, "Value", "Text", $"{(int)DateTime.Today.DayOfWeek}");



            //var weekDays = Enum.GetValues(typeof(DayOfWeek)).Cast<DayOfWeek>();

            //foreach (var item in weekDays)

            //{

            //    var listItem = new SelectListItem { Value = item.ToString(), Text = item.ToString() };

            //    //listItem.Selected = today.Day == item.Day;

            //    list.Add(listItem);

            //}



            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

            var operation = _context.Operations.Where(c => c.IdentityUserId == userId).SingleOrDefault();


            var today = DateTime.Today.DayOfWeek;
            var applicationDbContext = _context.Customers.Where(c => c.MowDay == today);

            return View(await applicationDbContext.ToListAsync());

        }



        //[HttpPost]

        //[ValidateAntiForgeryToken]

        public async Task<IActionResult> Filter(DayOfWeek? Day)

        {

            //Get employee

            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

            var operation = _context.Operations.Where(c => c.IdentityUserId == userId).SingleOrDefault();



            //What day of the week is it today?

            DayOfWeek today = DateTime.Today.DayOfWeek;

            //What date was Sunday of this week?

            DateTime sundayOfThisWeek = DateTime.Today.Subtract(new TimeSpan(Convert.ToInt32(today), 0, 0, 0));

            //What is the date of the the user selected? Add the int value of the day that the user selected to Sunday's date.

            DateTime selectedDate = sundayOfThisWeek.AddDays(Convert.ToDouble(Day));



            //apply filtering to db with linq

            var applicationDbContext = _context.Customers

                .Where(c => c.MowDay == Day || c.ExtraMowDay == Day)

                .Where(c => c.ZipCode == operation.ZipCode)

                .Where(c => c.StartDate > selectedDate || c.EndDate < selectedDate);



            //send data 

            ViewBag.Day = Day;

            ViewBag.Date = selectedDate.ToString("MM-dd-yyyy");

            return View(await applicationDbContext.ToListAsync());

        }



        // GET: Employees/Details/5

        public async Task<IActionResult> Details(int? id)

        {

            if (id == null)

            {

                return NotFound();

            }



            var customer = await _context.Customers

                .Include(e => e.IdentityUser)

                .FirstOrDefaultAsync(m => m.Id == id);

            if (customer == null)

            {

                return NotFound();

            }



            return View(customer);

        }



        // GET: Employees/Create

        public IActionResult Create()

        {

            Operation operation = new Operation();

            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id");

            return View(operation);

        }



        // POST: Employees/Create

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 

        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.

        [HttpPost]

        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create([Bind("Id,Name,ZipCode,IdentityUserId")] Operation operation)

        {

            if (ModelState.IsValid)

            {

                if (operation.Id == 0)

                {

                    var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

                    operation.IdentityUserId = userId;

                    _context.Add(operation);

                }

                else

                {

                    var operationInDB = _context.Operations.Single(m => m.Id == operation.Id);

                    operationInDB.Name = operation.Name;

                    operationInDB.ZipCode = operation.ZipCode;

                }



                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));

            }

            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", operation.IdentityUserId);

            return View(operation);

        }



        // GET: Employees/Edit/5

        public async Task<IActionResult> Edit(int? id)

        {

            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

            var operation = _context.Operations.Where(c => c.IdentityUserId == userId).SingleOrDefault();

            if (id == null)

            {

                return NotFound();

            }



            var customer = await _context.Customers.FindAsync(id);

            if (customer == null)

            {

                return NotFound();

            }

            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", operation.IdentityUserId);

            return View(customer);

        }



        // POST: Employees/Edit/5

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 

        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.

        [HttpPost]

        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Edit(int? id, [Bind("Balance, Address, ZipCode, ServicesConfirmationDate, ExtraMowDayConfirmation ")] Customer customer)

        {

            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

            var operation = _context.Operations.Where(c => c.IdentityUserId == userId).SingleOrDefault();

            customer = _context.Customers.Single(m => m.Id == id);



            if (id != customer.Id)

            {

                return NotFound();

            }



            if (ModelState.IsValid)

            {

                try

                {

                    customer.ServicesConfirmationDate = DateTime.Now;

                    customer.Balance += 20;

                    _context.Update(customer);

                    await _context.SaveChangesAsync();

                }

                catch (DbUpdateConcurrencyException)

                {

                    if (!OperationExists(customer.Id))

                    {

                        return NotFound();

                    }

                    else

                    {

                        throw;

                    }

                }

                return RedirectToAction(nameof(Index));

            }

            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", customer.IdentityUserId);

            return View(customer);



        }



        // GET: Employees/Delete/5

        public async Task<IActionResult> Delete(int? id)

        {

            if (id == null)

            {

                return NotFound();

            }



            var operation = await _context.Operations

                .Include(e => e.IdentityUser)

                .FirstOrDefaultAsync(m => m.Id == id);

            if (operation == null)

            {

                return NotFound();

            }



            return View(operation);

        }



        // POST: Employees/Delete/5

        [HttpPost, ActionName("Delete")]

        [ValidateAntiForgeryToken]

        public async Task<IActionResult> DeleteConfirmed(int id)

        {

            var operation = await _context.Operations.FindAsync(id);

            _context.Operations.Remove(operation);

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));

        }



        private bool OperationExists(int id)

        {

            return _context.Operations.Any(e => e.Id == id);

        }

        public ActionResult JobWork()
        {
            var time = _context.TimeClock.Select(t => t).ToList();
            var teams = time.Select(t => t.Team).Distinct();
            var duration = time.Select(d => d.Duration);
            ViewBag.TEAMS = teams;
            ViewBag.Duration = duration;
            return View();
        }

        public IActionResult TeamEdit()
        {
            Employee team = new Employee();

            return View(team);
        }
        [HttpPost]
        public IActionResult TeamEdit(Employee Team)
        {

            _context.Employees.Update(Team);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
        public async Task<IActionResult> TeamList()

        {

            //Get employee
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

            var employee = _context.Employees.Where(c => c.IdentityUserId == userId).SingleOrDefault();

            //apply filtering to db with linq

            var applicationDbContext = _context.Employees
                .Where(c => c.Team == employee.Team);
            return View(await applicationDbContext.ToListAsync());



        }
        // GET: Employee
        public async Task<IActionResult> EmployList()
        {
            var applicationDbContext = _context.Employees

                .Include(c => c.Name);
            return View(await applicationDbContext.ToListAsync());
        }
        public IActionResult Location()
        {
            return View("Location");
        }
        
    }
}