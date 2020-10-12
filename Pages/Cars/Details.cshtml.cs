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
    public class DetailsModel : PageModel
    {
        private readonly ICarRepository carRepository;
        public DetailsModel(ICarRepository carRepository)
        {
            this.carRepository = carRepository;
        }

        public Car Car { get; set; }
        public void OnGet(int id)
        {
            Car = carRepository.GetCar(id);
        }
    }
}
