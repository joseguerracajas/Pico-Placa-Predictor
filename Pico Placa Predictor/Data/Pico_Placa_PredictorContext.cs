#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pico_Placa_Predictor.Models;

namespace Pico_Placa_Predictor.Data
{
    public class Pico_Placa_PredictorContext : DbContext
    {
        public Pico_Placa_PredictorContext (DbContextOptions<Pico_Placa_PredictorContext> options)
            : base(options)
        {
        }

        public DbSet<Pico_Placa_Predictor.Models.Test> Test { get; set; }
    }
}
