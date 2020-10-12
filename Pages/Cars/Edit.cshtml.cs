using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarsProject.Models;
using CarsProject.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CarsProject.Pages.Cars
{
    public class EditModel : PageModel
    {
        private readonly ICarRepository carRepository;
        public EditModel(ICarRepository carRepository)
        {
            this.carRepository = carRepository;
        }

        public Car Car { get; set; }
        public IActionResult OnGet(int id)
        {
            Car = carRepository.GetCar(id);
            if(Car == null)
            {
                return RedirectToPage("/Error");
            }
            return Page();
        }

        public IActionResult OnPost(Car car)
        {
            if(ModelState.IsValid)
            {
                Car = carRepository.EditCar(car);
                return RedirectToPage("/Cars/Index");
            }

            return Page();
        }


    }
}
