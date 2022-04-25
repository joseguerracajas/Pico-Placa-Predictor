using Pico_Placa_Predictor.Models;
using Pico_Placa_Predictor.Services;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Pico_Placa_Predictor.Test
{
    public class PredictorTest
    {

        readonly PredictorService predictorService = new PredictorService();

        Predictor predictor1 = new Predictor("PDL7591", new DateOnly(2021,4,1),new TimeOnly(8,15));
        Predictor predictor2 = new Predictor("PDL7591", new DateOnly(2021, 4, 1), new TimeOnly(8, 45));
        Predictor predictor3 = new Predictor("PDL7591", new DateOnly(2021, 4, 1), new TimeOnly(9, 15));
        Predictor predictor4 = new Predictor("PDL7591", new DateOnly(2021, 4, 1), new TimeOnly(10, 15));
        Predictor predictor5 = new Predictor("PDL7591", new DateOnly(2021, 4, 1), new TimeOnly(15, 0));
        Predictor predictor6 = new Predictor("PDL7591", new DateOnly(2021, 4, 1), new TimeOnly(16, 0));
        Predictor predictor7 = new Predictor("PDL7591", new DateOnly(2021, 4, 1), new TimeOnly(8, 19));
        Predictor predictor8 = new Predictor("PDL7591", new DateOnly(2021, 4, 1), new TimeOnly(8, 21));

        Predictor predictor9 = new Predictor("PDL7591", new DateOnly(2021, 4, 4), new TimeOnly(8, 15));
        Predictor predictor10 = new Predictor("PDL7591", new DateOnly(2021, 4, 4), new TimeOnly(8, 45));
        Predictor predictor11 = new Predictor("PDL7591", new DateOnly(2021, 4, 4), new TimeOnly(9, 15));
        Predictor predictor12 = new Predictor("PDL7591", new DateOnly(2021, 4, 4), new TimeOnly(10, 15));
        Predictor predictor13 = new Predictor("PDL7591", new DateOnly(2021, 4, 4), new TimeOnly(15, 0));
        Predictor predictor14 = new Predictor("PDL7591", new DateOnly(2021, 4, 4), new TimeOnly(16, 0));
        Predictor predictor15 = new Predictor("PDL7591", new DateOnly(2021, 4, 4), new TimeOnly(8, 19));
        Predictor predictor16 = new Predictor("PDL7591", new DateOnly(2021, 4, 4), new TimeOnly(8, 21));

        Predictor predictor17 = new Predictor("PDL7591", new DateOnly(2021, 4, 5), new TimeOnly(8, 15));
        Predictor predictor18 = new Predictor("PDL7591", new DateOnly(2021, 4, 5), new TimeOnly(8, 45));
        Predictor predictor19 = new Predictor("PDL7591", new DateOnly(2021, 4, 5), new TimeOnly(9, 15));
        Predictor predictor20 = new Predictor("PDL7591", new DateOnly(2021, 4, 5), new TimeOnly(10, 15));
        Predictor predictor21 = new Predictor("PDL7591", new DateOnly(2021, 4, 5), new TimeOnly(15, 0));
        Predictor predictor22 = new Predictor("PDL7591", new DateOnly(2021, 4, 5), new TimeOnly(16, 0));
        Predictor predictor23 = new Predictor("PDL7591", new DateOnly(2021, 4, 5), new TimeOnly(8, 19));
        Predictor predictor24 = new Predictor("PDL7591", new DateOnly(2021, 4, 5), new TimeOnly(8, 21));

        [Fact]
        private void PredictTesting()
        {
            bool canBeOnRoad1 = predictorService.CanBeonRoad(predictor1);
            bool canBeOnRoad2 = predictorService.CanBeonRoad(predictor2);
            bool canBeOnRoad3 = predictorService.CanBeonRoad(predictor3);
            bool canBeOnRoad4 = predictorService.CanBeonRoad(predictor4);
            bool canBeOnRoad5 = predictorService.CanBeonRoad(predictor5);
            bool canBeOnRoad6 = predictorService.CanBeonRoad(predictor6);
            bool canBeOnRoad7 = predictorService.CanBeonRoad(predictor7);
            bool canBeOnRoad8 = predictorService.CanBeonRoad(predictor8);
            bool canBeOnRoad9 = predictorService.CanBeonRoad(predictor9);
            bool canBeOnRoad10 = predictorService.CanBeonRoad(predictor10);
            bool canBeOnRoad11 = predictorService.CanBeonRoad(predictor11);
            bool canBeOnRoad12 = predictorService.CanBeonRoad(predictor12);
            bool canBeOnRoad13 = predictorService.CanBeonRoad(predictor13);
            bool canBeOnRoad14 = predictorService.CanBeonRoad(predictor14);
            bool canBeOnRoad15 = predictorService.CanBeonRoad(predictor15);
            bool canBeOnRoad16 = predictorService.CanBeonRoad(predictor16);
            bool canBeOnRoad17 = predictorService.CanBeonRoad(predictor17);
            bool canBeOnRoad18 = predictorService.CanBeonRoad(predictor18);
            bool canBeOnRoad19 = predictorService.CanBeonRoad(predictor19);
            bool canBeOnRoad20 = predictorService.CanBeonRoad(predictor20);
            bool canBeOnRoad21 = predictorService.CanBeonRoad(predictor21);
            bool canBeOnRoad22 = predictorService.CanBeonRoad(predictor22);
            bool canBeOnRoad23 = predictorService.CanBeonRoad(predictor23);
            bool canBeOnRoad24 = predictorService.CanBeonRoad(predictor24);


            Assert.False(canBeOnRoad1);
            Assert.False(canBeOnRoad2);
            Assert.False(canBeOnRoad3);
            Assert.True(canBeOnRoad4);
            Assert.False(canBeOnRoad5);
            Assert.False(canBeOnRoad6);
            Assert.False(canBeOnRoad7);
            Assert.False(canBeOnRoad8);
            Assert.True(canBeOnRoad9);
            Assert.True(canBeOnRoad10);
            Assert.True(canBeOnRoad11);
            Assert.False(canBeOnRoad12);
            Assert.False(canBeOnRoad13);
            Assert.True(canBeOnRoad14);
            Assert.False(canBeOnRoad15);
            Assert.False(canBeOnRoad16);
            Assert.False(canBeOnRoad17);
            Assert.False(canBeOnRoad18);
            Assert.False(canBeOnRoad19);
            Assert.False(canBeOnRoad20);
            Assert.False(canBeOnRoad21);
            Assert.False(canBeOnRoad22);
            Assert.False(canBeOnRoad23);
            Assert.False(canBeOnRoad24);

            canBeOnRoad1.ShouldBe(false);
            canBeOnRoad2.ShouldBe(false);
            canBeOnRoad3.ShouldBe(false);
            canBeOnRoad4.ShouldBe(true);
            canBeOnRoad5.ShouldBe(false);
            canBeOnRoad6.ShouldBe(false);
            canBeOnRoad7.ShouldBe(false);
            canBeOnRoad8.ShouldBe(false);
            canBeOnRoad9.ShouldBe(true);
            canBeOnRoad10.ShouldBe(true);
            canBeOnRoad11.ShouldBe(true);
            canBeOnRoad12.ShouldBe(false);
            canBeOnRoad13.ShouldBe(false);
            canBeOnRoad14.ShouldBe(true);
            canBeOnRoad15.ShouldBe(false);
            canBeOnRoad16.ShouldBe(false);
            canBeOnRoad17.ShouldBe(false);
            canBeOnRoad18.ShouldBe(false);
            canBeOnRoad19.ShouldBe(false);
            canBeOnRoad20.ShouldBe(false);
            canBeOnRoad21.ShouldBe(false);
            canBeOnRoad22.ShouldBe(false);
            canBeOnRoad23.ShouldBe(false);
            canBeOnRoad24.ShouldBe(false);


        }


    }
}
