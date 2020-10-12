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
    public class CreateModel : PageModel
    {
        private readonly ICarRepository carRepository;

        public CreateModel(ICarRepository carRepository)
        {
            this.carRepository = carRepository;
        }

        public Car Car { get; set; }
        public IActionResult OnPost(Car car)
        {
            Car = carRepository.AddCar(car);

            if(Car != null)
            {
                return RedirectToPage("/Cars/Index");
            }

            return Page();
        }
    }
}
