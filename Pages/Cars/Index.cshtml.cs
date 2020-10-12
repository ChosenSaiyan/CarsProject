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
    public class IndexModel : PageModel
    {
        private readonly ICarRepository carRepository;
        public IndexModel(ICarRepository carRepository)
        {
            this.carRepository = carRepository;

        }

        public IEnumerable<Car> CarList { get; set; }
        public void OnGet()
        {
            CarList = carRepository.GetAllCars();
        }
    }
}
