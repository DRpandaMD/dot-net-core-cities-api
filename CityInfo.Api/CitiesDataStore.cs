using CityInfo.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CityInfo.Api
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();
        public List<CityDto> Cities { get; set; }

        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "New York City",
                    Description = "The One with the big park",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto() {
                             Id = 1,
                             Name = "Central Park",
                             Description = "The most visited urban park in the United States."},
                        new PointOfInterestDto() {
                             Id = 2,
                             Name = "Empire State Building",
                             Description = "A 102-story skyscraper located in Midtown Manhattan."},
                    }
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Paris",
                    Description = "The One with the big tower",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto() {
                             Id = 3,
                             Name = "Eiffel Tower",
                             Description = "A wroght iron lattice tower on the Champ de Mars, named after engineer Gustave Eiffel."},
                        new PointOfInterestDto() {
                             Id = 4,
                             Name = "The Louvre",
                             Description = "The worlds largest museum."},
                    }
                },
                new CityDto()
                {
                    Id = 3,
                    Name = "Las Vegas",
                    Description = "The One with the big casinos.",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto() {
                             Id = 5,
                             Name = "Red Rock Canyon",
                             Description = "A canyon of red rock."},
                        new PointOfInterestDto() {
                             Id = 6,
                             Name = "The Louvre",
                             Description = "The Strip: the main gambling point of attraction."},
                    }
                }
            };
        }
    }
}