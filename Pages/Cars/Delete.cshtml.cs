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
    public class DeleteModel : PageModel
    {
        private readonly ICarRepository carRepository;
        public DeleteModel(ICarRepository carRepository)
        {
            this.carRepository = carRepository;
        }

        [BindProperty]
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

        public IActionResult OnPost()
        {
            var DeletedCar = carRepository.DeleteCar(Car.Id);

            if(DeletedCar == null)
            {
                return RedirectToPage("/Error");
            }
            return RedirectToPage("/Cars/Index");
        }
    }
}
